using System.Threading.Tasks;
using Playground.Model;

namespace Playground.Downloaders.Interfaces
{
    public interface IDownloader
    {
        WebsiteDataModel Download(string url);
    }
}
