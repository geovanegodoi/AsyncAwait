using System;
using System.Threading.Tasks;
using Playground.Model;

namespace Playground.Runners.Interfaces
{
    public interface IRunnerAsync
    {
        Task RunAsync(Action<WebsiteDataModel> callback);
    }
}