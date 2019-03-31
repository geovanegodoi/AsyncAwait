using System;
using System.Threading.Tasks;
using Playground.Model;

namespace Playground.Runners.Interfaces
{
    public interface IRunner
    {
        void Run(Action<WebsiteDataModel> callback);
    }
}