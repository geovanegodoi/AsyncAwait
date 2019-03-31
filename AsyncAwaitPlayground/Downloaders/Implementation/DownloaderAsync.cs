using System;
using System.Diagnostics;
using System.Net;
using System.Threading.Tasks;
using Playground.Downloaders.Interfaces;
using Playground.Model;
using WindowsFormsApp1.Downloaders.Implementation;

namespace Playground.Downloaders.Implementation
{
    public class DownloaderAsync : DownloaderBase, IDownloaderAsync
    {
        public async Task<WebsiteDataModel> DownloadAsync(string url)
        {
            base.CheckValidUrl(url);

            var output     = new WebsiteDataModel();
            var client     = new WebClient();
            var clock      = Stopwatch.StartNew();

            output.Url     = url;
            output.Data    = await client.DownloadStringTaskAsync(new Uri(url));
            clock.Stop();
            output.Elapsed = clock.ElapsedMilliseconds;

            return output;
        }
    }
}
