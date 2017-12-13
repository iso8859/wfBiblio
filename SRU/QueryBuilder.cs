using consoleBnf.search;


namespace consoleBnf.query{
    public class QueryBuilder{
        public static string Build(string _url, QueryFilter filter, QueryFilterType filterType, string searchtext, string recordSchema = "dublincore")
        {
            var _filter = NoticeTranslator.Translate(filter);
            var _filterType = NoticeTranslator.Translate(filterType);
            return _url + _filter + " " + _filterType + " " + string.Format("\"{0}\"", searchtext) + "&recordSchema=" + recordSchema;
        }
    }
}
