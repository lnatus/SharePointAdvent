using Newtonsoft.Json;
using SharePointAdvent.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Resources;

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
            var sponsorGroup = new Group("Sponsoren");
            var json = LoadFromResource("Sponsors");
            var sponsors = JsonConvert.DeserializeObject<List<SponsorEntry>>(json);

            foreach (var sponsor in sponsors)
            {
                sponsorGroup.Entries.Add(sponsor);
            }

            return sponsorGroup;
        }

        public static Group GenerateAuthors()
        {
            var authorGroup = new Group("Autoren");
           
            foreach (var item in Constants.Authors.All())
	{
		 authorGroup.Entries.Add(item);
	}
            return authorGroup;
        }

        public static Group GenerateLottery()
        {
            var lotteryGroup = new Group("Gewinnspiel");
            lotteryGroup.Entries.Add(new LotteryEntry { Title="Die Preise", Logo = new Uri("ms-appx:///Assets/Lottery.png"), Url = new Uri("http://sharepointadvent.de") });
            lotteryGroup.Entries.Add(new LotteryEntry { Title="Die Aufgabe", Logo = new Uri("ms-appx:///Assets/Lottery.png"), Url = new Uri("http://sharepointadvent.de") });
            lotteryGroup.Entries.Add(new LotteryEntry { Title="Die Teilnahmebedingungen", Logo = new Uri("ms-appx:///Assets/Lottery.png"), Url = new Uri("http://sharepointadvent.de") });
            lotteryGroup.Entries.Add(new LotteryEntry { Title="Die Gewinner", Logo = new Uri("ms-appx:///Assets/Lottery.png"), Url = new Uri("http://sharepointadvent.de") });
            return lotteryGroup;
        }

        private static String LoadFromResource(String res)
        {
            var loader = new ResourceLoader(res);
            return loader.GetString("JSON");
        }

    }
}
