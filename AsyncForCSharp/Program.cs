using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Threading.Tasks;
using static System.Console;

namespace AsyncForCSharp
{
    public enum Option
    {
        Syncronous = 1, Assyncronous, ParallelAsync
    }

    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                WriteLine("Async For CSharp");
                WriteLine("[1] Download Syncronous");
                WriteLine("[2] Download Assyncronous");
                WriteLine("[3] Download Parallel Assyncronous");
                Write("Choose an option: ");
                if (int.TryParse(ReadLine(), out int option) && 1 <= option && option <= 3)
                {
                    switch((Option)option)
                    {
                        case Option.Syncronous   : ExecuteSync();  break;
                        case Option.Assyncronous : ExecuteAsync(); break;
                        case Option.ParallelAsync : ExecuteParallelAsync(); break;
                    }
                }
                else
                    WriteLine("Invalid option!!!");

                WriteLine("");
                WriteLine("");
            }
        }

        private static void ExecuteSync()
        {
            var watch = Stopwatch.StartNew();

            RunDownloadSync();

            watch.Stop();

            var elapsed = watch.ElapsedMilliseconds;

            WriteLine($"Total execution time: {elapsed}");
        }

        private static async void ExecuteAsync()
        {
            var watch = Stopwatch.StartNew();

            await RunDownloadAsync();

            watch.Stop();

            var elapsed = watch.ElapsedMilliseconds;

            WriteLine($"Total execution time: {elapsed}");
        }

        private static async void ExecuteParallelAsync()
        {
            var watch = Stopwatch.StartNew();

            await RunDownloadParallelAsync();

            watch.Stop();

            var elapsed = watch.ElapsedMilliseconds;

            WriteLine($"Total execution time: {elapsed}");
        }


        private static List<string> PrepareData()
        {
            WriteLine("");

            var output = new List<string>()
            {
                "https://www.yahoo.com",
                "https://google.com",
                "https://microsoft.com",
                "https://cnn.com",
                "https://codeproject.com",
                "https://stackoverflow.com"
            };
            return output;
        }

        private static void RunDownloadSync()
        {
            var websites = PrepareData();

            foreach (var site in websites)
            {
                WebsiteDataModel results = DownloadWebsite(site);
                ReportwebsiteInfo(results);
            }
        }

        private static async Task RunDownloadAsync()
        {
            var websites = PrepareData();

            foreach (var site in websites)
            {
                var result = await Task.Run(() => DownloadWebsite(site));
                ReportwebsiteInfo(result);
            }
        }

        private static async Task RunDownloadParallelAsync()
        {
            var websites = PrepareData();
            var tasks = new List<Task<WebsiteDataModel>>();

            foreach (var site in websites)
            {
                tasks.Add(DownloadWebsiteAsync(site));
            }
            var results = await Task.WhenAll(tasks);

            foreach (var item in results)
            {
                ReportwebsiteInfo(item);
            }
        }

        private static WebsiteDataModel DownloadWebsite(string site)
        {
            var output = new WebsiteDataModel();
            var client = new WebClient();

            output.WebsiteUrl = site;
            output.WebsiteData = client.DownloadString(site);

            return output;
        }

        private static async Task<WebsiteDataModel> DownloadWebsiteAsync(string site)
        {
            var output = new WebsiteDataModel();
            var client = new WebClient();

            output.WebsiteUrl  = site;
            output.WebsiteData = await client.DownloadStringTaskAsync(site);

            return output;
        }

        private static void ReportwebsiteInfo(WebsiteDataModel data)
        {
            WriteLine($"{data.WebsiteUrl} downloaded: {data.WebsiteData.Length} characters long.");
        }
    }

    class WebsiteDataModel
    {
        public string WebsiteUrl;
        public string WebsiteData;
    }
}
