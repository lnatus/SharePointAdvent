using System;
using SharePointAdvent.Common;
using SharePointAdvent.Contracts;

namespace SharePointAdvent.ViewModel
{
    public class AuthorEntry : BindableBase , IEntry
    {
        private string _name;
        private Uri _image;
        private string _topic;

        public Uri Blog { get; set; } 

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name
        {
            get { return _name; }
            set { SetProperty(ref _name, value); }
        }

        /// <summary>
        /// Gets or sets the image.
        /// </summary>
        /// <value>
        /// The image.
        /// </value>
        public Uri Image
        {
            get { return _image; }
            set { SetProperty(ref _image, value); }
        }

        /// <summary>
        /// Gets or sets the topic.
        /// </summary>
        /// <value>
        /// The topic.
        /// </value>
        public string Topic
        {
            get { return _topic; }
            set { SetProperty(ref _topic, value); }
        }
    }
}