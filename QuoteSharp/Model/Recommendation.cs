using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.Specialized;
using System.Collections.ObjectModel;

namespace QuoteSharp
{
    public class Recommendation
    {
        public decimal id { get; set; }
        public decimal user_id { get; set; }
        public decimal article_id { get; set; }
        public decimal page_id { get; set; }
        public string quote { get; set; }
        public decimal commentCount { get; set; }

        public User user
        {
            get
            {
                if (_user == null)
                {
                    _user = API.getUser(user_id);
                }
                return _user;
            }
            set
            {
                _user = value;
            }
        }
        private User _user { get; set; }

        public Article article
        {
            get
            {
                if (_article == null)
                {
                    _article = API.getArticle(article_id);
                }
                return _article;
            }
            set
            {
                _article = value;
            }
        }
        private Article _article { get; set; }

        public Page domain
        {
            get
            {
                if (_domain == null)
                {
                    _domain = API.getPage(page_id);
                }
                return _domain;
            }
            set
            {
                _domain = value;
            }
        }
        private Page _domain { get; set; }

        public ObservableCollection<Comment> comments {get;set;}

        public Recommendation()
        {
            comments = new ObservableCollection<Comment>();
        }

        public override string ToString()
        {
            return string.Format("Recommendations {0} => {1}", id, quote); ;
        }
    }
}
