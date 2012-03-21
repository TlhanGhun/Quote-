using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;

namespace QuoteSharp
{
    public class ListOfPages
    {
        public decimal totalCount { get; set; }
        public decimal pageSize { get; set; }
        public ObservableCollection<Page> entities { get; set; }
    }
}
