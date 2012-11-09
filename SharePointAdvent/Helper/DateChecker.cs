using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharePointAdvent.Helper
{
    public class DateChecker
    {
        public static Boolean Check(int day)
        {
            if (DateTime.Now > new DateTime(2012, 12, day+1)) return true;
            if(DateTime.Now > new DateTime(2012, 12, day) && DateTime.Now > new DateTime(2012,12,day,8,0,0)) return true;
            return false;
        }
    }
}
