using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;
using Playground.Model;
using Playground.Runners.Implementation;
using Playground.Runners.Interfaces;

namespace Playground
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void BtnExecuteNormal_Click(object sender, EventArgs e)
        {
            IRunner runner = new RunnerSync();
            this.RunJob(runner.Run);
        }
        
        private void BtnExecuteAsync_Click(object sender, EventArgs e)
        {
            IRunnerAsync runner = new RunnerAsync();
            this.RunJobAsync(runner.RunAsync);
        }

        private void BtnExecuteAsyncParallel_Click(object sender, EventArgs e)
        {
            IRunnerAsync runner = new RunnerAsyncParallel();
            this.RunJobAsync(runner.RunAsync);
        }

        private void RunJob(Action<Action<WebsiteDataModel>> jobRunner)
        {
            txtLog.Clear();

            var stopWatch = Stopwatch.StartNew();

            jobRunner(ReportWebsite);

            stopWatch.Stop();

            this.LogCompleted(stopWatch.ElapsedMilliseconds);
        }

        private async Task RunJobAsync(Func<Action<WebsiteDataModel>, Task> jobRunner)
        {
            txtLog.Clear();

            var stopWatch = Stopwatch.StartNew();

            await jobRunner(ReportWebsite);

            stopWatch.Stop();

            this.LogCompleted(stopWatch.ElapsedMilliseconds);
        }

        private void ReportWebsite(WebsiteDataModel model)
        {
            txtLog.Text += $"{model.Url} downloaded : {model.Data.Length} characters long in {model.Elapsed} miliseconds.{Environment.NewLine}";
        }


        private void LogCompleted(long elapsedTime)
        {
            txtLog.Text += $"Total execution time: {elapsedTime}{Environment.NewLine}";
        }
    }
}
