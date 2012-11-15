using System;
using System.Collections.ObjectModel;
using SharePointAdvent.Common;
using SharePointAdvent.Helper;
using SharePointAdvent.Service;
using Newtonsoft.Json;
using System.Collections.Generic;
using Windows.UI.Popups;

namespace SharePointAdvent.ViewModel
{
    public class MainPageViewModel : BindableBase
    {
        private readonly ObservableCollection<Group> _groups = new ObservableCollection<Group>();

        public ObservableCollection<Group> Groups
        {
            get { return _groups; }
        }

        public async void LoadDataAsync()
        {
            try
            {
                //Get dynamic content from web url.
                var json = await DownloadService.GetContentAsync("http://dotnetrocks-web.sharepoint.com/Documents/SharePointAdvent.js");
                var articles = JsonConvert.DeserializeObject<List<ArticleEntry>>(json);
                Groups.Add(EntryGenerator.GenerateArticles(articles));

                //Generate static content.
                Groups.Add(EntryGenerator.GenerateSponsors());
                Groups.Add(EntryGenerator.GenerateAuthors());
                Groups.Add(EntryGenerator.GenerateLottery());
            }
            catch (Exception)
            {
                var msgDialog = new MessageDialog("Der aktuelle Kalender konnte nicht geladen werden, bitte überprüfen Sie Ihre Internetverbindung.");
                msgDialog.Commands.Add(new UICommand("Erneut verbinden", new UICommandInvokedHandler(UICommandInvokedHandler)));
                msgDialog.Commands.Add(new UICommand("Schliessen", new UICommandInvokedHandler(UICommandInvokedHandler)));
                msgDialog.DefaultCommandIndex = 1;
                msgDialog.ShowAsync();
            }
        }

        private void UICommandInvokedHandler(IUICommand command)
        {
            if(command.Label.Equals("Schliessen")) return;
            LoadDataAsync();
        }
    }
}