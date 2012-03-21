using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;

namespace QuoteSharp
{
    public class ListOfUsers
    {
        public decimal totalCount { get; set; }
        public decimal pageSize { get; set; }

        public User user { get; set; }

        public ObservableCollection<User> entities { get; set; }
    }
}
