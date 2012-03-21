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
// <summary>Some helper methods for HTTP requests</summary>
//-----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuoteSharp;

namespace Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            /* This is quite simple testing
             * 
             * Methodes do return NULL is no result is available - I do not check here but you should in your application...
             * I decided to create own objects for every result so you can easily see all attributes in debug 
             * And I decided to keep this test code very, very simple (no extra methods / functions)
             * 
             */
            Console.WriteLine("Test tool for API calls in Quote#");
            Console.WriteLine("###################\n");
            // Categories
            ListOfCategories listCategories = API.getCategories();
            Console.WriteLine("-> List of categories");
            foreach (Category category in listCategories.entities)
            {
                Console.WriteLine(" " + category.ToString());
            }

            Console.WriteLine("\n###################\n");
            Console.WriteLine("-> Recommendations\n");
            // Recommendations
            int id = 900;
            Console.Write("Id of recommendation to fetch (default is 900): ");
            string idString = Console.ReadLine();
            try
            {
                id = Convert.ToInt32(idString);
            }
            catch
            {
                Console.WriteLine("Using default 900");
                id = 900;
            }
            Recommendation reco = API.getRecommendation(id);
            Console.WriteLine(reco.ToString() + "\n");
            
            Console.Write("Id of article to fetch recommendations of (default is 123): ");
            idString = Console.ReadLine();
            try
            {
                id = Convert.ToInt32(idString);
            }
            catch
            {
                Console.WriteLine("Using default 123");
                id = 123;
            }
            ListOfRecommendations listRecosArticle = API.getRecommendationsListByArticle(id);
            Console.WriteLine("Fetched for article " + listRecosArticle.article.ToString());
            foreach(Recommendation recoInArticle in listRecosArticle.entities) {
                Console.WriteLine(" " + recoInArticle.ToString());
            }

            Console.Write("\nUsername to fetch recommendations of (default is quotefm): ");
            string username = Console.ReadLine();
            if (string.IsNullOrEmpty(username))
            {
                Console.WriteLine("Using default username quotefm");
                username = "quotefm";
            }
            ListOfRecommendations listRecosUser = API.getRecommendationsListByUser(username);
            Console.WriteLine("Fetched for username " + username);
            foreach (Recommendation recoOfUser in listRecosUser.entities)
            {
                Console.WriteLine(" " + recoOfUser.ToString());
            }


            Console.WriteLine("\n###################\n");
            Console.WriteLine("-> Articles\n");
            // Articles
            Console.Write("Id of article to fetch (default is 2111): ");
            idString = Console.ReadLine();
            try
            {
                id = Convert.ToInt32(idString);
            }
            catch
            {
                Console.WriteLine("Using default 2111");
                id = 2111;
            }
            Article article = API.getArticle(id);
            Console.WriteLine(article.ToString());

            Console.Write("\nList of category ids to fetch articles for (commasepareted - default is 1,3): ");
            string catIds = Console.ReadLine();
            List<decimal> ids = new List<decimal>();
            if(!string.IsNullOrEmpty(catIds)) {
                string[] catIdsArray = catIds.Split(',');
                foreach(string catIdString in catIdsArray) {
                    try {
                        int catId = Convert.ToInt32(catIdString);
                        ids.Add(catId);
                    }
                    catch {}
                }
            }
            if(ids.Count == 0) {
                Console.WriteLine("Using default 1,3");
                ids.Add(1);
                ids.Add(3);
            }
            ListOfArticles listArticlesCategory = API.getArticlesListByCategories(ids);
            foreach (Article articleOfCat in listArticlesCategory.entities)
            {
                Console.WriteLine(" " + articleOfCat.ToString());
            }

            Console.Write("\nId of article page fetch articles of (default is 123): ");
            idString = Console.ReadLine();
            try
            {
                id = Convert.ToInt32(idString);
            }
            catch
            {
                Console.WriteLine("Using default 123");
                id = 123;
            }
            ListOfArticles listArticlesByPage = API.getArticlesListByPage(123);
            Console.WriteLine("Page is " + listArticlesByPage.page.ToString());
            foreach (Article articleOfPage in listArticlesByPage.entities)
            {
                Console.WriteLine(" " + article.ToString());
            }

            Console.WriteLine("\n###################\n");
            Console.WriteLine("-> Pages\n");
            //Pages

            Console.Write("Id of page to fetch (default is 4223): ");
            idString = Console.ReadLine();
            try
            {
                id = Convert.ToInt32(idString);
            }
            catch
            {
                Console.WriteLine("Using default 4223");
                id = 4223;
            }
            Page pageById = API.getPage(id);
            Console.WriteLine(pageById.ToString());

            Console.Write("\nDomain to fetch page of (default is spiegel.de): ");
            string domain = Console.ReadLine();
            if (string.IsNullOrEmpty(domain))
            {
                Console.WriteLine("Using default domain spiegel.de");
                domain = "spiegel.de";
            }
            Page pageByDomain = API.getPage(domain);
            Console.WriteLine(pageByDomain.ToString());


            Console.WriteLine("\n###################\n");
            Console.WriteLine("-> Users\n");
            // Users
            Console.Write("Id of user to fetch (default is 1): ");
            idString = Console.ReadLine();
            try
            {
                id = Convert.ToInt32(idString);
            }
            catch
            {
                Console.WriteLine("Using default 1");
                id = 1;
            }
            User userById = API.getUser(id);
            Console.WriteLine(userById.ToString());

            Console.Write("\nUsername to fetch (default is quotefm): ");
            username = Console.ReadLine();
            if (string.IsNullOrEmpty(username))
            {
                Console.WriteLine("Using default username quotefm");
                username = "quotefm";
            }
            User userByUsername = API.getUser(username);
            Console.WriteLine(userByUsername.ToString());

            Console.WriteLine("\nFollowers of " + username);
            ListOfUsers listUserFollowers = API.getUsersListOfFollowers(username);
            foreach (User follower in listUserFollowers.entities)
            {
                Console.WriteLine(" " + follower.ToString());
            }

            Console.WriteLine("\nFollowings of " + username);
            ListOfUsers listUserFollowings = API.getUsersListOfFollowings(username);
            foreach (User following in listUserFollowings.entities)
            {
                Console.WriteLine(" " + following.ToString());
            }

            Console.WriteLine("Completed... Press enter to close");
            Console.ReadLine();
        }
    }
}
