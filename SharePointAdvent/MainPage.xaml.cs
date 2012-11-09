using System;
using System.Collections.Generic;
using SharePointAdvent.ViewModel;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using SharePointAdvent.Contracts;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml.Media.Imaging;
using SharePointAdvent.Helper;

// The Grouped Items Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234231

namespace SharePointAdvent
{
    /// <summary>
    /// A page that displays a grouped collection of items.
    /// </summary>
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

        /// <summary>
        /// Populates the page with content passed during navigation.  Any saved state is also
        /// provided when recreating a page from a prior session.
        /// </summary>
        /// <param name="navigationParameter">The parameter value passed to
        /// <see cref="Frame.Navigate(Type, Object)"/> when this page was initially requested.
        /// </param>
        /// <param name="pageState">A dictionary of state preserved by this page during an earlier
        /// session.  This will be null the first time a page is visited.</param>
        protected override void LoadState(Object navigationParameter, Dictionary<String, Object> pageState)
        {
            // TODO: Create an appropriate data model for your problem domain to replace the sample data
            //var sampleDataGroups = SampleDataSource.GetGroups((String)navigationParameter);
            var model = new MainPageViewModel();
            model.LoadDataAsync();
            this.DefaultViewModel["Groups"] = model.Groups;
        }

        /// <summary>
        /// Invoked when a group header is clicked.
        /// </summary>
        /// <param name="sender">The Button used as a group header for the selected group.</param>
        /// <param name="e">Event data that describes how the click was initiated.</param>
        void Header_Click(object sender, RoutedEventArgs e)
        {
            //// Determine what group the Button instance represents
            //var group = (sender as FrameworkElement).DataContext;

            //// Navigate to the appropriate destination page, configuring the new page
            //// by passing required information as a navigation parameter
            //this.Frame.Navigate(typeof(GroupDetailPage), ((SampleDataGroup)group).UniqueId);
        }

        /// <summary>
        /// Invoked when an item within a group is clicked.
        /// </summary>
        /// <param name="sender">The GridView (or ListView when the application is snapped)
        /// displaying the item clicked.</param>
        /// <param name="e">Event data that describes the item clicked.</param>
        async void ItemView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var item = e.ClickedItem as IEntry;

            if (e.ClickedItem is ArticleEntry)
            {
               if(DateChecker.Check(((ArticleEntry)e.ClickedItem).Day))
                 await Windows.System.Launcher.LaunchUriAsync(((ArticleEntry)e.ClickedItem).Url);
            }

            if (e.ClickedItem is SponsorEntry)
            {
               await  Windows.System.Launcher.LaunchUriAsync(((SponsorEntry)e.ClickedItem).Link);
            }

            if (e.ClickedItem is AuthorEntry)
            {
               await Windows.System.Launcher.LaunchUriAsync(((AuthorEntry)e.ClickedItem).Blog);
            }
        }
    }
}
