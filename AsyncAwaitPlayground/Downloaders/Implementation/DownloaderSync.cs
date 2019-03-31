using System.Diagnostics;
using System.Net;
using Playground.Downloaders.Interfaces;
using Playground.Model;
using WindowsFormsApp1.Downloaders.Implementation;

namespace Playground.Downloaders.Implementation
{
    public class DownloaderSync : DownloaderBase, IDownloader
    {
        public WebsiteDataModel Download(string url)
        {
            base.CheckValidUrl(url);

            var output     = new WebsiteDataModel();
            var client     = new WebClient();
            var clock      = Stopwatch.StartNew();

            output.Url     = url;
            output.Data    = client.DownloadString(url);
            clock.Stop();
            output.Elapsed = clock.ElapsedMilliseconds;

            return output;
        }
    }
}
