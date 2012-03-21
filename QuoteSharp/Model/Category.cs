using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuoteSharp
{
    public class Category
    {
        public decimal id { get; set; }
        public string name { get; set; }
        public decimal order { get; set; }

        public override string ToString()
        {
            return string.Format("Category {0} => {1}", id, name); ;
        }
    }
}
