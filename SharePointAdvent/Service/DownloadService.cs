using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SharePointAdvent.Service
{
    public class DownloadService
    {
       
        public static async Task<String> GetContentAsync(String url)
        {
            var httpClient = new HttpClient();
            return await httpClient.GetStringAsync(url);
        }
    }
}
