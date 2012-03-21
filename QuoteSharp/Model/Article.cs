using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuoteSharp
{
    public class Article
    {
        public decimal id { get; set; }
        public string url { get; set; }
        public string title { get; set; }
        public decimal length { get; set; }
        public string language { get; set; }
        public DateTime? created { get; set; }

        public Recommendation topquote { get; set; }
        public decimal recommendationCount { get; set; }

        public Page page { get; set; }

        public override string ToString()
        {
            return string.Format("Article {0} => {1}", id, title); ;
        }
    }
}
