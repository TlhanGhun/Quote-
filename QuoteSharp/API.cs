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
using System.Net;
using System.Web;
using System.IO;
using Newtonsoft.Json;

namespace QuoteSharp
{
    public class API
    {
        public const string ApiBaseUrl = "https://quote.fm/api";

        #region Recommendations
        public static Recommendation getRecommendation(decimal id)
        {
            if (id == 0)
            {
                return null;
            }
            Recommendation recommendation;
            Response webResponse = SendGetRequest(string.Format("{0}{1}?id={2}", ApiBaseUrl, "/recommendation/get/", id.ToString()));
            recommendation = JsonConvert.DeserializeObject<Recommendation>(webResponse.Content);
            return recommendation;
        }

        public static ListOfRecommendations getRecommendationsListByArticle(decimal id)
        {
            return getRecommendationsListByArticle(id, 0);
        }

        public static ListOfRecommendations getRecommendationsListByArticle(decimal id, decimal page)
        {
            if (id == 0)
            {
                return null;
            }
            ListOfRecommendations listOfRecommendations;
            Response webResponse;
            if (page == 0)
            {
                webResponse = SendGetRequest(string.Format("{0}{1}?id={2}", ApiBaseUrl, "/recommendation/listByArticle/", id.ToString()));
            }
            else
            {
                webResponse = SendGetRequest(string.Format("{0}{1}?id={2}&page=", ApiBaseUrl, "/recommendation/listByArticle/", id.ToString(), page.ToString()));
            }
            listOfRecommendations = JsonConvert.DeserializeObject<ListOfRecommendations>(webResponse.Content);
            return listOfRecommendations;
        }

        public static ListOfRecommendations getRecommendationsListByUser(string username)
        {
            return getRecommendationsListByUser(username, 0);
        }

        public static ListOfRecommendations getRecommendationsListByUser(string username, decimal page)
        {
            if (string.IsNullOrEmpty(username))
            {
                return null;
            }
            ListOfRecommendations listOfRecommendations;
            Response webResponse;
            if (page == 0)
            {
                webResponse = SendGetRequest(string.Format("{0}{1}?username={2}", ApiBaseUrl, "/recommendation/listByUser/", System.Web.HttpUtility.UrlEncode(username)));
            }
            else
            {
                webResponse = SendGetRequest(string.Format("{0}{1}?username={2}&page=", ApiBaseUrl, "/recommendation/listByUser/", System.Web.HttpUtility.UrlEncode(username.ToString()), page.ToString()));
            }
            if (webResponse.Content != null)
            {
                listOfRecommendations = JsonConvert.DeserializeObject<ListOfRecommendations>(webResponse.Content);
            }
            else
            {
                listOfRecommendations = null;
            }

            return listOfRecommendations;
        }
        #endregion

        #region Articles
        public static Article getArticle(decimal id)
        {
            if (id == 0)
            {
                return null;
            }
            Article article;
            Response webResponse = SendGetRequest(string.Format("{0}{1}?id={2}", ApiBaseUrl, "/article/get/", id.ToString()));
            article = JsonConvert.DeserializeObject<Article>(webResponse.Content);
            return article;
        }


        public static ListOfArticles getArticlesListByPage(decimal id)
        {
            return getArticlesListByPage(id, 0);
        }

        public static ListOfArticles getArticlesListByPage(decimal id, decimal page)
        {
            if (id == 0)
            {
                return null;
            }
            ListOfArticles listOfArticles;
            Response webResponse;
            if (page == 0)
            {
                webResponse = SendGetRequest(string.Format("{0}{1}?id={2}", ApiBaseUrl, "/article/listByPage/", id.ToString()));
            }
            else
            {
                webResponse = SendGetRequest(string.Format("{0}{1}?id={2}&page=", ApiBaseUrl, "/article/listByPage/", id.ToString(), page.ToString()));
            }
            listOfArticles = JsonConvert.DeserializeObject<ListOfArticles>(webResponse.Content);
            return listOfArticles;
        }

        public static ListOfArticles getArticlesListByCategories(List<Category> categories, string language = "", string scope = "", decimal page = 0)
        {
            if (categories == null)
            {
                return null;
            }
            List<decimal> ids = new List<decimal>();
            foreach (Category category in categories)
            {
                if (category != null)
                {
                    ids.Add(category.id);
                }
            }
            return getArticlesListByCategories(ids, language, scope, page);
        }

        public static ListOfArticles getArticlesListByCategories(List<decimal> ids, string language = "", string scope = "", decimal page = 0)
        {
            if (ids == null)
            {
                return null;
            }
            if (ids.Count() == 0)
            {
                return new ListOfArticles();
            }
            ListOfArticles listOfArticles;
            Response webResponse;

            string requstUrl = string.Format("{0}{1}?ids={2}", ApiBaseUrl, "/article/listByCategories/", string.Join(",", ids));
            if (!string.IsNullOrEmpty(language))
            {
                requstUrl = requstUrl + "&language=" + System.Web.HttpUtility.UrlEncode(language);
            }
            if (!string.IsNullOrEmpty(scope))
            {
                requstUrl = requstUrl + "&scope=" + System.Web.HttpUtility.UrlEncode(scope);
            }
            webResponse = SendGetRequest(requstUrl);
            listOfArticles = JsonConvert.DeserializeObject<ListOfArticles>(webResponse.Content);

            return listOfArticles;
        }
        #endregion

        #region Pages
        public static Page getPage(decimal id)
        {
            if (id == 0)
            {
                return null;
            }
            Page page;
            Response webResponse = SendGetRequest(string.Format("{0}{1}?id={2}", ApiBaseUrl, "/page/get/", id.ToString()));
            page = JsonConvert.DeserializeObject<Page>(webResponse.Content);
            return page;
        }

        public static Page getPage(string domain)
        {
            if (string.IsNullOrEmpty(domain))
            {
                return null;
            }
            Page page;
            Response webResponse = SendGetRequest(string.Format("{0}{1}?domain={2}", ApiBaseUrl, "/page/get/", System.Web.HttpUtility.UrlEncode(domain)));
            page = JsonConvert.DeserializeObject<Page>(webResponse.Content);
            return page;
        }

        public static ListOfPages getPagesList(decimal page = 0)
        {
            ListOfPages listOfPages;
            Response webResponse;

            string requstUrl = string.Format("{0}{1}", ApiBaseUrl, "/page/list");
            if (page != 0)
            {
                requstUrl = requstUrl + "?page=" + page.ToString();
            }
            webResponse = SendGetRequest(requstUrl);
            listOfPages = JsonConvert.DeserializeObject<ListOfPages>(webResponse.Content);

            return listOfPages;
        }

        #endregion

        #region Users
        public static User getUser(decimal id)
        {
            if (id == 0)
            {
                return null;
            }
            User user;
            Response webResponse = SendGetRequest(string.Format("{0}{1}?id={2}", ApiBaseUrl, "/user/get/", id.ToString()));
            user = JsonConvert.DeserializeObject<User>(webResponse.Content);
            return user;
        }

        public static User getUser(string username)
        {
            if (string.IsNullOrEmpty(username))
            {
                return null;
            }
            User user;
            Response webResponse = SendGetRequest(string.Format("{0}{1}?username={2}", ApiBaseUrl, "/user/get/", System.Web.HttpUtility.UrlEncode(username)));
            try
            {
                user = JsonConvert.DeserializeObject<User>(webResponse.Content);
            }
            catch (Exception exp)
            {
                if (webResponse != null)
                {   
                    return null;
                }
                else
                {
                    return null;
                }
            }


            return user;
        }

        public static ListOfUsers getUsersListOfFollowers(string username)
        {
            return getUsersListOfFollowers(username, 0);
        }

        public static ListOfUsers getUsersListOfFollowers(string username, decimal page)
        {
            if (string.IsNullOrEmpty(username))
            {
                return null;
            }
            ListOfUsers listOfUsers;
            Response webResponse;
            if (page == 0)
            {
                webResponse = SendGetRequest(string.Format("{0}{1}?username={2}", ApiBaseUrl, "/user/listFollowers/", System.Web.HttpUtility.UrlEncode(username)));
            }
            else
            {
                webResponse = SendGetRequest(string.Format("{0}{1}?username={2}&page=", ApiBaseUrl, "/user/listFollowers/", System.Web.HttpUtility.UrlEncode(username), page.ToString()));
            }
            listOfUsers = JsonConvert.DeserializeObject<ListOfUsers>(webResponse.Content);
            return listOfUsers;
        }

        public static ListOfUsers getUsersListOfFollowings(string username)
        {
            return getUsersListOfFollowings(username, 0);
        }

        public static ListOfUsers getUsersListOfFollowings(string username, decimal page)
        {
            if (string.IsNullOrEmpty(username))
            {
                return null;
            }
            ListOfUsers listOfUsers;
            Response webResponse;
            if (page == 0)
            {
                webResponse = SendGetRequest(string.Format("{0}{1}?username={2}", ApiBaseUrl, "/user/listFollowings/", System.Web.HttpUtility.UrlEncode(username)));
            }
            else
            {
                webResponse = SendGetRequest(string.Format("{0}{1}?username={2}&page=", ApiBaseUrl, "/user/listFollowings/", System.Web.HttpUtility.UrlEncode(username), page.ToString()));
            }
            listOfUsers = JsonConvert.DeserializeObject<ListOfUsers>(webResponse.Content);
            return listOfUsers;
        }
        #endregion

        #region Categories

        public static ListOfCategories getCategories()
        {

            ListOfCategories listOfCategories;
            Response webResponse = SendGetRequest(string.Format("{0}{1}", ApiBaseUrl, "/category/list/"));
            listOfCategories = JsonConvert.DeserializeObject<ListOfCategories>(webResponse.Content);
            return listOfCategories;
        }

        #endregion

        #region HTTP helper functions

        public static Response SendGetRequest(string url)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(url);
                request.Method = "GET";
                request.AllowAutoRedirect = true;
                request.Accept = "*/*";
                request.UserAgent = " QuoteSharp (https://github.com/TlhanGhun/Quote-)";


                Response returnValue = GetResponse(request);
                return returnValue;
            }
            catch (System.Exception e)
            {
                Console.WriteLine(e.Message);
                Response nullResponse = new Response();
                nullResponse.Success = false;
                nullResponse.Error = e.Message;
                return nullResponse;
            }
        }

          #region Private

        private static string ProcessUrl(string url)
        {
            string theQuestionMark = "?";
            if (url.Contains(theQuestionMark))
            {
                url = url.Replace(theQuestionMark, System.Web.HttpUtility.UrlEncode(theQuestionMark));
            }
            return url;
        }

        private static Response GetResponse(HttpWebRequest request)
        {

            HttpWebResponse response;
            try
            {
                HttpWebResponse responseTemp = (HttpWebResponse)request.GetResponse();
                response = responseTemp;
            }
            catch (System.Exception e)
            {
                // some proxys have problems with Continue-100 headers
                request.ProtocolVersion = HttpVersion.Version10;
                request.ServicePoint.Expect100Continue = false;
                System.Net.ServicePointManager.Expect100Continue = false;
                HttpWebResponse responseTemp = (HttpWebResponse)request.GetResponse();
                response = responseTemp;
                System.Console.WriteLine(e.Message);
            }

            Response returnValue = new Response();

            returnValue.FullHeaders = response.Headers;
            returnValue = parseHeaders(returnValue);

            using (StreamReader reader = new StreamReader(response.GetResponseStream()))
            {
                returnValue.Content = reader.ReadToEnd();
                return returnValue;
            }
        }

        private static Response parseHeaders(Response response)
        {
            for (int i = 0; i < response.FullHeaders.Count; i++)
            {
                KeyValuePair<string, string> header = new KeyValuePair<string, string>(response.FullHeaders.GetKey(i), response.FullHeaders.Get(i));
                switch (header.Key)
                {
                    case "Status":
                        response.Status = header.Value;
                        if (header.Value.StartsWith("200"))
                        {
                            response.Success = true;
                        }
                        else
                        {
                            response.Success = false;
                        }
                        break;

           
                    default:
                        // any other response we are not interested...
                        break;
                }
            }
            return response;
        }



        #endregion

        public class Response
        {
            public bool Success { get; set; }
            public string Status { get; set; }
            public string Error { get; set; }
            public string Content { get; set; }
         
            public WebHeaderCollection FullHeaders { get; set; }

        }

        #endregion

        #region Test all API calls

        public static void testAllApiCalls()
        {
            // Categories
            ListOfCategories listCategories = getCategories();

            // Recommendations
            Recommendation reco = getRecommendation(900);
            ListOfRecommendations listRecosArticle = getRecommendationsListByArticle(123);
            ListOfRecommendations listRecosUser = getRecommendationsListByUser("svenwal");

            // Articles
            Article article = getArticle(2111);
            List<decimal> ids = new List<decimal>();
            ids.Add(1);
            ids.Add(3);
            ListOfArticles listArticlesCategory = getArticlesListByCategories(ids);
            ListOfArticles listArticlesByPage = getArticlesListByPage(123);

            // Pages
            Page pageById = getPage(4223);
            Page pageByDomain = getPage("spiegel.de");

            // Users
            User userById = getUser(4404);
            User userByUsername = getUser("svenwal");
            ListOfUsers listUserFollowers = getUsersListOfFollowers("pwaldhauer");
            ListOfUsers listUserFollowings = getUsersListOfFollowings("pwaldhauer");

            Console.WriteLine("Completed...");
        }

        #endregion
    }
}
