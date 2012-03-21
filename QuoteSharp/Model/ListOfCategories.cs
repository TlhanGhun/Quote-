using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;

namespace QuoteSharp
{
    public class ListOfCategories
    {
        public decimal totalCount { get; set; }
        public decimal pageSize { get; set; }

        public ObservableCollection<Category> entities { get; set; }
    }
}
