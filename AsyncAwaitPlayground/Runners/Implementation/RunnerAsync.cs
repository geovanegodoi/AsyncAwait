using System;
using System.Threading.Tasks;
using Playground.Downloaders.Implementation;
using Playground.Model;
using Playground.Runners.Interfaces;

namespace Playground.Runners.Implementation
{
    public class RunnerAsync : RunnerBase, IRunnerAsync
    {
        public RunnerAsync()
        {
            this.downloader = new DownloaderSync();
        }

        public async Task RunAsync(Action<WebsiteDataModel> callback)
        {
            base.CheckValidCallback(callback);

            foreach (var site in base.BuildData())
            {
                var result = await Task.Run(() => this.downloader.Download(site));
                callback(result);
            }
        }
    }
}
