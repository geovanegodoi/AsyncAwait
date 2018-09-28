using System;
using System.Threading;
using System.Threading.Tasks;
using static System.Console;

namespace AsyncAwaitBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            RunAsync();
        }

        static void RunSync()
        {
            WriteLine(">>> RunSync::Begin");

            for (int i = 0; i < 10; i++)
            {
                Write(". ");
                Thread.Sleep(1000);
            }
            WriteLine("");
            WriteLine("<<< RunSync::End");
        }

        static async Task RunAsync()
        {
            WriteLine(">>> RuncAsync::Begin");
            await Task.Run(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    Write(". ");
                    Thread.Sleep(1000);
                }
            });            
            WriteLine("");
            WriteLine("<<< RuncAsync::End");
        }
    }
}
