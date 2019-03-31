using System;
using Playground.Downloaders.Implementation;
using Playground.Model;
using Playground.Runners.Interfaces;

namespace Playground.Runners.Implementation
{
    public class RunnerSync : RunnerBase, IRunner
    {
        public RunnerSync()
        {
            this.downloader = new DownloaderSync();
        }

        public void Run(Action<WebsiteDataModel> callback)
        {
            base.CheckValidCallback(callback);

            foreach (var site in base.BuildData())
            {
                var result = this.downloader.Download(site);
                callback(result);
            }
        }
    }
}
