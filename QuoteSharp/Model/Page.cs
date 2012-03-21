using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuoteSharp
{
    public class Page
    {
        public decimal id { get; set; }
        public string name { get; set; }
        public string description { get; set; }

        public override string ToString()
        {
            return string.Format("Page {0} => {1}", id, name); ;
        }
    }
}
