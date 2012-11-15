using SharePointAdvent.Common;
using SharePointAdvent.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharePointAdvent.ViewModel
{
    public class LotteryEntry : BindableBase, IEntry
    {
        public Uri Url { get; set; }
        public Uri Logo { get; set; } 
    }
}
