using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Playground.Downloaders.Implementation;
using Playground.Model;
using Playground.Runners.Interfaces;

namespace Playground.Runners.Implementation
{
    public class RunnerAsyncParallel : RunnerBase, IRunnerAsync
    {
        public RunnerAsyncParallel()
        {
            this.downloaderAsync = new DownloaderAsync();
        }

        public async Task RunAsync(Action<WebsiteDataModel> callback)
        {
            base.CheckValidCallback(callback);

            var tasks = new Collection<Task<WebsiteDataModel>>();

            foreach (var site in base.BuildData())
            {
                tasks.Add(this.downloaderAsync.DownloadAsync(site));
            }
            var results = await Task.WhenAll(tasks);

            foreach (var item in results)
            {
                callback(item);
            }
        }
    }
}
