using System;
using System.Collections;
using System.Collections.Generic;

namespace consoleBnf.search
{
    public class NoticeCriteriaAttribute : Attribute
    {
        string _value;
        public string Value{
            get{
                return _value;
            }
        }

        public NoticeCriteriaAttribute(string value){
            _value = value;
        }
    }

    /// <summary>
    /// Gestion des critères de recherche
    /// </summary>
    internal class NoticeTranslator{
        static Dictionary<Enum,NoticeCriteriaAttribute> _cachevalues = new Dictionary<Enum, NoticeCriteriaAttribute>();
        public static string Translate(Enum value){
            string result = string.Empty;
            var type = value.GetType();

            if(_cachevalues.ContainsKey(value))
                return (_cachevalues[value] as NoticeCriteriaAttribute).Value;

            else
            {
                var info = type.GetField(value.ToString());
                NoticeCriteriaAttribute[] attrs = info.GetCustomAttributes(typeof (NoticeCriteriaAttribute),false) as NoticeCriteriaAttribute[];
                if (attrs.Length > 0)
                {
                    _cachevalues.Add(value, attrs[0]);
                    result = attrs[0].Value;
                }
            }

            return result;
        }
    }
}
