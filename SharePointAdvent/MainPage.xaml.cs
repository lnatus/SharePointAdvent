using System;
using System.Collections.Generic;
using SharePointAdvent.ViewModel;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using SharePointAdvent.Contracts;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml.Media.Imaging;
using SharePointAdvent.Helper;
using SharePointAdvent.Service;
using Windows.UI.Popups;
using Windows.System;

// The Grouped Items Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234231

namespace SharePointAdvent
{
    public sealed partial class MainPage
    {
        private BitmapImage _bi;

        public MainPage()
        {
            _bi = new BitmapImage();
            this.InitializeComponent();
            this.ApplicationViewStates.CurrentStateChanging += ApplicationViewStates_CurrentStateChanging;
        }

        private void ApplicationViewStates_CurrentStateChanging(object sender, VisualStateChangedEventArgs e)
        {
            _bi.UriSource = e.NewState.Name.Equals("Snapped")
                          ? new Uri(new Uri("ms-appx:///"),"Assets/snapped.png")
                          : new Uri(new Uri("ms-appx:///"), "Assets/bg.png");

            BgBrush.ImageSource = _bi;
        }

        protected override void LoadState(Object navigationParameter, Dictionary<String, Object> pageState)
        {
                StateLoader.Load(this.DefaultViewModel);
        }

        async void ItemView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var item = e.ClickedItem as IEntry;

            if (e.ClickedItem is ArticleEntry)
            {
               if(DateChecker.Check(((ArticleEntry)e.ClickedItem).Day))
                 await Launcher.LaunchUriAsync(((ArticleEntry)e.ClickedItem).Url);
            }

            if (e.ClickedItem is SponsorEntry)
            {
               await  Launcher.LaunchUriAsync(((SponsorEntry)e.ClickedItem).Link);
            }

            if (e.ClickedItem is AuthorEntry)
            {
               await Launcher.LaunchUriAsync(((AuthorEntry)e.ClickedItem).Blog);
            }

            if (e.ClickedItem is LotteryEntry)
            {
                await Launcher.LaunchUriAsync(((LotteryEntry)e.ClickedItem).Url);
            }
        }

        private void BtnRefreshClick(object sender, RoutedEventArgs e)
        {
            StateLoader.Load(this.DefaultViewModel);
        }
    }
}
