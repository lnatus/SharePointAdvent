using SharePointAdvent.Contracts;
using SharePointAdvent.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace SharePointAdvent.Helper
{
    class EntryItemTemplateSelectorSnapped : DataTemplateSelector
    {
        protected override DataTemplate SelectTemplateCore(object item, DependencyObject container)
        {
            if (item == null || !(item is IEntry))
            {
                return base.SelectTemplateCore(item, container);
            }

            object resource;

            if (item is ArticleEntry)
            {
                if (Application.Current.Resources.TryGetValue("ArticleEntryItemTemplateSnapped", out resource))
                {
                    return resource as DataTemplate;
                }
            }
            else if (item is AuthorEntry)
            {
                if (Application.Current.Resources.TryGetValue("AuthorEntryItemTemplateSnapped", out resource))
                {
                    return resource as DataTemplate;
                }
            }
            else if (item is SponsorEntry)
            {
                if (Application.Current.Resources.TryGetValue("SponsorEntryItemTemplateSnapped", out resource))
                {
                    return resource as DataTemplate;
                }
            }
            else if (item is LotteryEntry)
            {
                if (Application.Current.Resources.TryGetValue("LotteryEntryItemTemplateSnapped", out resource))
                {
                    return resource as DataTemplate;
                }
            }

            return base.SelectTemplateCore(item, container);
        }
    }
}
