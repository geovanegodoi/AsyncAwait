using System.Threading.Tasks;
using Playground.Model;

namespace Playground.Downloaders.Interfaces
{
    public interface IDownloaderAsync
    {
        Task<WebsiteDataModel> DownloadAsync(string url);
    }
}
