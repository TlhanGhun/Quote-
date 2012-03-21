using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuoteSharp
{
    public class Comment
    {
        public decimal id { get; set; }
        public User user { get; set; }
        public string text { get; set; }
        public DateTime? created { get; set; }

        public override string ToString()
        {
            return string.Format("Comment {0} => {1} => {2}", id, text,user); ;
        }
    }
}
