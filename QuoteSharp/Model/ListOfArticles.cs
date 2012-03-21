using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;

namespace QuoteSharp
{
    public class ListOfArticles
    {
        public decimal totalCount { get; set; }
        public decimal pageSize { get; set; }
        public Page page{ get; set; }

        public ObservableCollection<Article> entities { get; set; }

        public ListOfArticles()
        {
            entities = new ObservableCollection<Article>();
            totalCount = 0;
            pageSize = 0;
        }
    }
}
