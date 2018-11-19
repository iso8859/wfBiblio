using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using System.Dynamic;
using System.Xml;
using System.Xml.XPath;

// Avec l'aide de Franck Kambiwa

namespace consoleBnf.query
{
    public class NoticeQuery
    {
        static public string url 
        { 
            get => "http://catalogue.bnf.fr/api/SRU?version=1.2&operation=searchRetrieve&query=";
        }

        static HttpClient Client()
        {
            var result = new HttpClient();
            return result;
        }

        static private async Task<string> SendUrl(QueryFilter filter, QueryFilterType filterType, string textsearch, string recordSchema = "dublincore")
        {
            try
            {
                var final_url = QueryBuilder.Build(url,  filter, filterType, textsearch, recordSchema);
                var request = new HttpRequestMessage(HttpMethod.Get, final_url);
                var response = Client().SendAsync(request).Result;
                var content = await response.Content.ReadAsStringAsync();
                response.EnsureSuccessStatusCode();
                
                return content;
            }

            catch(Exception e){
                return string.Empty;
            }
        }

        // http://catalogue.bnf.fr/api
        // Format dublincore : bof pas terrible, le format des champs est parasité
        static public IEnumerable<wfBiblio.Notice> GetNotice(QueryFilter filter, QueryFilterType type, string search)
        {
            System.Text.RegularExpressions.Regex isbn = new System.Text.RegularExpressions.Regex(@"ISBN\s*(?<Val>\d*)");
            var content = SendUrl(filter, type, search);
            var tmp = content.Result;
            // System.IO.File.WriteAllText("out.xml", tmp);
            var xmldoc = XDocument.Parse(tmp);
            // Très peu de code pour l'avoir en dynamic
            //tmp = JsonConvert.SerializeXNode(xmldoc);
            //System.IO.File.WriteAllText("out.json", tmp);
            //dynamic r = JsonConvert.DeserializeObject<ExpandoObject>(tmp);

            var xml_root = xmldoc.Elements().First();
            XNamespace ns = "http://www.loc.gov/zing/srw/";
            var elts = xml_root.Descendants(ns + "records");
            XNamespace ns_elt = "http://purl.org/dc/elements/1.1/";
            foreach (var elt in elts.Elements())
            {
                var recordData = elt.Element(ns + "recordData").Elements().First();
                var result = new wfBiblio.Notice
                {
                    auteur = recordData.Element(ns_elt + "creator").Value,
                    éditeur = recordData.Element(ns_elt + "publisher").Value,
                    titre = recordData.Element(ns_elt + "title").Value,
                    année = recordData.Element(ns_elt + "date").Value
                };
                foreach (var id in recordData.Elements(ns_elt + "identifier"))
                { 
                    var m = isbn.Match(id.Value);
                    if (m.Success)
                    {
                        result.isbn = m.Groups["Val"].Value;
                        break;
                    }
                }
                yield return result;
            }
        }

        // Format unimarcxchange
        static public IEnumerable<wfBiblio.Notice> GetNotice2(QueryFilter filter, QueryFilterType type, string search)
        {
            var content = SendUrl(filter, type, search, "unimarcxchange");
            var tmp = content.Result;
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(tmp);

            XPathNavigator nav = doc.CreateNavigator();
            XmlNamespaceManager nsmgr = new XmlNamespaceManager(nav.NameTable);
            nsmgr.AddNamespace("srw", @"http://www.loc.gov/zing/srw/");
            nsmgr.AddNamespace("mxc", @"info:lc/xmlns/marcxchange-v2");

            foreach (XmlNode record in doc.SelectNodes("//srw:searchRetrieveResponse/srw:records/srw:record/srw:recordData/mxc:record/mxc:datafield[@tag='200' and @ind1='1']/mxc:subfield[@code='b' and text()='Texte imprimé']", nsmgr))
            {
                var t1 = record.ParentNode.ParentNode;
                var result = new wfBiblio.Notice
                {
                    titre = t1.SelectSingleNode("mxc:datafield[@tag='200' and @ind1='1']/mxc:subfield[@code='a']", nsmgr)?.InnerText,
                    complémentTitre = t1.SelectSingleNode("mxc:datafield[@tag='200' and @ind1='1']/mxc:subfield[@code='e']", nsmgr)?.InnerText,
                    auteur = t1.SelectSingleNode("mxc:datafield[@tag='200' and @ind1='1']/mxc:subfield[@code='f']", nsmgr)?.InnerText,
                    éditeur = t1.SelectSingleNode("mxc:datafield[@tag='210']/mxc:subfield[@code='c']", nsmgr)?.InnerText,
                    collection = t1.SelectSingleNode("mxc:datafield[@tag='225']/mxc:subfield[@code='a']", nsmgr)?.InnerText,
                    isbn = t1.SelectSingleNode("mxc:datafield[@tag='073']/mxc:subfield[@code='a']", nsmgr)?.InnerText,
                    année = t1.SelectSingleNode("mxc:datafield[@tag='210']/mxc:subfield[@code='d']", nsmgr)?.InnerText
                };
                if (string.IsNullOrEmpty(result.éditeur))
                    result.éditeur = t1.SelectSingleNode("mxc:datafield[@tag='219']/mxc:subfield[@code='c']", nsmgr)?.InnerText;
                if (string.IsNullOrEmpty(result.année))
                    result.année = t1.SelectSingleNode("mxc:datafield[@tag='219']/mxc:subfield[@code='d']", nsmgr)?.InnerText;
                if (string.IsNullOrEmpty(result.collection))
                    result.collection = t1.SelectSingleNode("mxc:datafield[@tag='210']/mxc:subfield[@code='c']", nsmgr)?.InnerText;
                yield return result;
            }
        }

    }
}