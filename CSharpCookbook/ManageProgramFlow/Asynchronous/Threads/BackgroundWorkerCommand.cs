using System;
using System.ComponentModel;
using System.Threading;
using CSharpCookbook.BaseCommands;

namespace CSharpCookbook.ManageProgramFlow.Asynchronous.Threads
{
    public class BackgroundWorkerCommand : DemoCommand
    {
        public BackgroundWorkerCommand()
        {
            AddResource("BackgroundWorker Class", "http://msdn.microsoft.com/en-US/library/system.componentmodel.backgroundworker.aspx");
        }

        public override string Description { get { return "BackgroundWorker"; } }

        public override void ExecuteDemo()
        {
            InitializeBackgroundWorker();
            _backgroundWorker.RunWorkerAsync();
            Thread.Sleep(5000);
            Console.WriteLine();
        }

        private BackgroundWorker _backgroundWorker;
        public int BackgroundWorkerValue { get; set; }


        private void InitializeBackgroundWorker()
        {
            _backgroundWorker = new BackgroundWorker();
            _backgroundWorker.WorkerSupportsCancellation = true;
            _backgroundWorker.WorkerReportsProgress = true;
            _backgroundWorker.DoWork += BackgroundWorkerOnDoWork;
            _backgroundWorker.ProgressChanged += (sender, args) =>
            {
                BackgroundWorkerValue = args.ProgressPercentage;
                Console.Write("\r {0:000}%", BackgroundWorkerValue);
            };            
        }

        private void BackgroundWorkerOnDoWork(object sender, DoWorkEventArgs doWorkEventArgs)
        {
            var worker = sender as BackgroundWorker;
            for (int i = 1; i <= 100; i++)
            {
                if (worker.CancellationPending)
                {
                    doWorkEventArgs.Cancel = true;
                    break;
                }
                Thread.Sleep(33);
                worker.ReportProgress(i);
            }            
        }

        private void BackgroundWorkerCancel()
        {
            if (_backgroundWorker.WorkerSupportsCancellation)
            {
                _backgroundWorker.CancelAsync();
            }
        }
    }
}
