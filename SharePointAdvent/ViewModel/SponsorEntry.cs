using System;
using SharePointAdvent.Common;
using SharePointAdvent.Contracts;

namespace SharePointAdvent.ViewModel
{
    public class SponsorEntry : BindableBase, IEntry
    {
        private Uri _logo;
        private Uri _link;

        /// <summary>
        /// Gets or sets the logo.
        /// </summary>
        /// <value>
        /// The logo.
        /// </value>
        public Uri Logo
        {
            get { return _logo; }
            set
            {
                SetProperty(ref _logo, value);
            }
        }

        /// <summary>
        /// Gets or sets the link.
        /// </summary>
        /// <value>
        /// The link.
        /// </value>
        public Uri Link
        {
            get { return _link; }
            set { SetProperty(ref _link, value); }
        }
    }
}