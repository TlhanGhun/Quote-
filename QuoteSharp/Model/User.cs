using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuoteSharp
{
    public class User
    {
        public decimal id { get; set; }
        public string fullname { get; set; }
        public string username { get; set; }
        public string bio { get; set; }
        public string avatar { get; set; }
        public string twitter { get; set; }
        public string location { get; set; }
        public string url { get; set; }
        public DateTime? created { get; set; }

        public decimal followerCount { get; set; }
        public decimal followingCount { get; set; }

        public override string ToString()
        {
            return string.Format("User {0} => {1}", id, username); ;
        }
    }
}
