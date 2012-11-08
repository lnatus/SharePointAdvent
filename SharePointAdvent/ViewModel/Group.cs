using System.Collections.ObjectModel;
using SharePointAdvent.Common;
using SharePointAdvent.Contracts;

namespace SharePointAdvent.ViewModel
{
    public class Group : BindableBase
    {
        private ObservableCollection<IEntry> _entries = new ObservableCollection<IEntry>();
        private string _title;

        /// <summary>
        /// Initializes a new instance of the <see cref="Group" /> class.
        /// </summary>
        /// <param name="title">The title.</param>
        public Group(string title)
        {
           Title = title;
        }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        /// <summary>
        /// Gets the entries.
        /// </summary>
        /// <value>
        /// The entries.
        /// </value>
        public ObservableCollection<IEntry> Entries
        {
            get { return _entries; }
        }
    }
}