using SharePointAdvent.Contracts;
using SharePointAdvent.ViewModel;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace SharePointAdvent.Helper
{
    public class EntryItemTemplateSelector : DataTemplateSelector
    {
        protected override DataTemplate SelectTemplateCore(object item, DependencyObject container)
        {
            if(item == null || !(item is IEntry))
            {
                return base.SelectTemplateCore(item, container);
            }

            object resource;

            if (item is ArticleEntry)
            {
                if(Application.Current.Resources.TryGetValue("ArticleEntryItemTemplate", out resource))
                {
                    return resource as DataTemplate;
                }
            }
            else if (item is AuthorEntry)
            {
                if (Application.Current.Resources.TryGetValue("AuthorEntryItemTemplate", out resource))
                {
                    return resource as DataTemplate;
                }
            } 
            else if (item is SponsorEntry)
            {
                if (Application.Current.Resources.TryGetValue("SponsorEntryItemTemplate", out resource))
                {
                    return resource as DataTemplate;
                }
            }

            return base.SelectTemplateCore(item, container);
        }
    }
}