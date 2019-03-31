using System;
using System.Threading.Tasks;
using Playground.Downloaders.Interfaces;
using Playground.Model;

namespace WindowsFormsApp1.Downloaders.Implementation
{
    public abstract class DownloaderBase
    {
        protected void CheckValidUrl(string url)
        {
            if (string.IsNullOrEmpty(url))
                throw new ArgumentException($"Invalid argument {nameof(url)}");
        }
    }
}
