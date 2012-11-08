using System;
using SharePointAdvent.Common;
using SharePointAdvent.Contracts;

namespace SharePointAdvent.ViewModel
{
    public class ArticleEntry : BindableBase, IEntry
    {
        private int _day;
        private Uri _url;


        public Boolean IsEnabled { get; set; }
        public String Author { get; set; }

        /// <summary>
        /// Gets or sets the day of month.
        /// </summary>
        /// <value>
        /// The day of month.
        /// </value>
        public int Day
        {
            get { return _day; }
            set { SetProperty(ref _day, value); }
        }

        /// <summary>
        /// Gets or sets the URL.
        /// </summary>
        /// <value>
        /// The URL.
        /// </value>
        public Uri Url
        {
            get { return _url; }
            set { SetProperty(ref _url, value); }
        }
    }
}