using SharePointAdvent.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Foundation.Collections;

namespace SharePointAdvent.Helper
{
    public class StateLoader
    {
        public static void Load(IObservableMap<string, object> defaultViewModel)
        {
            var model = new MainPageViewModel();
            model.LoadDataAsync();
            defaultViewModel["Groups"] = model.Groups;
        }
    }
}
