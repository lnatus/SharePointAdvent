using System;
using System.Collections.ObjectModel;
using SharePointAdvent.Common;
using SharePointAdvent.Helper;
using SharePointAdvent.Service;
using Newtonsoft.Json;
using System.Collections.Generic;

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

            //Get dynamic content from web url.
            var json = await DownloadService.GetContentAsync("http://dotnetrocks-web.sharepoint.com/Documents/SharePointAdvent.js");
            var articles = JsonConvert.DeserializeObject<List<ArticleEntry>>(json);
            Groups.Add(EntryGenerator.GenerateArticles(articles));

            //Generate static content.
            Groups.Add(EntryGenerator.GenerateSponsors());
            Groups.Add(EntryGenerator.GenerateAuthors());
           
        }

    }
}