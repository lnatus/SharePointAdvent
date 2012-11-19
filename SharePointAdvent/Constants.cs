using SharePointAdvent.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharePointAdvent
{
    class Constants
    {
        public class Lottery
        {
            public  const String Quest = "";
            public  const String Prices = "";
            public  const String Contidions = "";
            public  const String Winners = "";
        }

        public class Authors
        {
            public static IEnumerable<AuthorEntry> All()
            {
                yield return Thorsten;
                yield return Christian;
                yield return Martina;
                yield return Daniel;
                yield return Fabian;
                yield return Christoph;
                yield return Samuel;
                yield return Michael;
            }
            public static AuthorEntry Thorsten = new AuthorEntry { Blog = new Uri("http://www.dotnet-rocks.de"), Name = "Thorsten Hans", Image = new Uri("ms-appx:///Assets/Authors/Thorsten_Hans.jpg"), Topic = "Thorten's Blog besuchen" };
            public static AuthorEntry Martina = new AuthorEntry { Name = "Martina Grom", Image = new Uri("ms-appx:///Assets/Authors/Martina_Grom.png"), Blog = new Uri("http://blog.atwork.at/"), Topic = "Martina's Blog besuchen" };
            public static AuthorEntry Christian = new AuthorEntry { Name = "Christian Glessner", Image = new Uri("ms-appx:///Assets/Authors/Christian_Glessner.jpg"), Blog = new Uri("http://www.ilovesharepoint.com/"), Topic = "Christian's Blog besuchen" };
            public static AuthorEntry Michael = new AuthorEntry { Name = "Michael Greth", Image = new Uri("ms-appx:///Assets/Authors/Michael_Greth.png"), Blog = new Uri("http://blogs.mysharepoint.de/blogs/mgreth/"), Topic = "Michael's Blog besuchen" };
            public static AuthorEntry Fabian = new AuthorEntry { Name = "Fabian Moritz", Image = new Uri("ms-appx:///Assets/Authors/Fabian_Moritz.png"), Blog = new Uri("http://weblogs.mysharepoint.de/blogs/fabianm/"), Topic = "Fabian's Blog besuchen" };
            public static AuthorEntry Christoph = new AuthorEntry { Name = "Christoph Müller", Image = new Uri("ms-appx:///Assets/Authors/Christoph_Mueller.jpg"), Blog = new Uri("http://www.scolab.ch/"), Topic = "Christoph's Blog besuchen" };
            public static AuthorEntry Daniel = new AuthorEntry { Name = "Daniel Wessels", Image = new Uri("ms-appx:///Assets/Authors/Daniel_Wessels.jpg"), Blog = new Uri("http://sharepointcommunity.de/blogs/dwessels/"), Topic = "Daniel's Blog besuchen" };
            public static AuthorEntry Samuel = new AuthorEntry { Name = "Samuel Zürcher", Image = new Uri("ms-appx:///Assets/Authors/Samuel_Zuercher.jpg"), Blog = new Uri("http://sharepointszu.com/"), Topic = "Samuel's Blog besuchen" };
        }

    }
}
