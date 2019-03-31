using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Playground.Downloaders.Interfaces;
using Playground.Model;
using Playground.Runners.Interfaces;

namespace Playground.Runners.Implementation
{
    public abstract class RunnerBase
    {
        protected IDownloader downloader;
        protected IDownloaderAsync downloaderAsync;

        protected void CheckValidCallback(Action<WebsiteDataModel> callback)
        {
            if (callback == null)
                throw new ArgumentException($"Invalid argument {nameof(callback)}");
        }

        protected ICollection<string> BuildData()
        {
            var output = new Collection<string>
            {
                "https://www.yahoo.com",
                "https://www.google.com",
                "https://www.microsoft.com",
                "https://www.cnn.com",
                "https://www.codeproject.com",
                "https://www.stackoverflow.com",
                "https://www.facebook.com",
                "https://www.globo.com",
                "https://www.github.com",
                "https://www.terra.com.br"
            };
            return output;
        }
    }
}
