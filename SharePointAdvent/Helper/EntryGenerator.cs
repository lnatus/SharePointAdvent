using SharePointAdvent.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharePointAdvent.Helper
{
    public class EntryGenerator
    {

        public static Group GenerateArticles(List<ArticleEntry> collection)
        {
            var articles = new Group("Kalender");
            foreach (var article in collection)
	        {
                articles.Entries.Add(article);
	        }

            return articles;
        }

        public static Group GenerateSponsors()
        {
         
            var sponsors = new Group("Sponsoren");
            for (var i = 1; i < 11; i++)
            {
                sponsors.Entries.Add(new SponsorEntry
                {
                    Logo = new Uri("http://google.de"),
                    Link = new Uri("http://google.de")
                });
            }

            return sponsors;
        }

        public static Group GenerateAuthors()
        {
            var authors = new Group("Autoren");
            for (var i = 1; i < 8; i++)
            {
                authors.Entries.Add(new AuthorEntry
                {
                    Name = string.Format("Name{0}", i),
                    Image = new Uri("http://google.de"),
                    Topic = string.Format("Topic{0}", i)
                });
            }

            return authors;
        }

    }
}
