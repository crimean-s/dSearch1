using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dSearch.Framework.FrameworkItems
{
    public enum SearchResultType { Local, Web}
    public class SearchResult
    {
        public int ID { get; set; } //?? не знаю нужно ли, но на всяк
        public string Tittle { get; set; }
        public string Url { get; set; }    
        public SearchResultType Type { get; set; }

        //можно расширить или изменить по необходимости
    }
}
