using consoleBnf.search;

namespace consoleBnf.query
{
   
    public enum OperatorQuery{
        
        [NoticeCriteria("And")]
        And,
        [NoticeCriteria("And")]
        Or
    }

    public enum QueryFilter{
        [NoticeCriteria("bib.anywhere")]
        Anywhere,
        [NoticeCriteria("bib.title")]
        Title,
        [NoticeCriteria("bib.author")]
        Author,
        [NoticeCriteria("bib.isbn")]
        Isbn
    }

    public enum QueryFilterType{
        [NoticeCriteria("all")]
        All,
        [NoticeCriteria("any")]
        Any,
        [NoticeCriteria("adj")]
        Adj
    }
}