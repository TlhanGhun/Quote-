//-----------------------------------------------------------------------
// <copyright>
//  Copyright (c) 2012, Sven Walther
//  All rights reserved. 

//  Redistribution and use in source and binary forms, with or without
//  modification, are permitted provided that the following conditions are met: 

//  1. Redistributions of source code must retain the above copyright notice, this
//     list of conditions and the following disclaimer. 
//  2. Redistributions in binary form must reproduce the above copyright notice,
//     this list of conditions and the following disclaimer in the documentation
//     and/or other materials provided with the distribution. 

//  THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND
//  ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED
//  WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE
//  DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT OWNER OR CONTRIBUTORS BE LIABLE FOR
//  ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES
//  (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES;
//  LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND
//  ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT
//  (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS
//  SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.

//  The views and conclusions contained in the software and documentation are those
//  of the authors and should not be interpreted as representing official policies, 
//  either expressed or implied, of the FreeBSD Project.
// </copyright>
// <author>Sven Walther</author>
//-----------------------------------------------------------------------

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
        public float popularity { get; set; }

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
