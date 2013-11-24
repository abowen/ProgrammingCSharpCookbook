using System;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using CSharpCookbook.BaseCommands;

namespace CSharpCookbook.ManageProgramFlow.Asynchronous.Tasks
{
    public class WaitCommand : DemoCommand
    {
        public WaitCommand()
        {
            AddResource("Task.WaitAny", "http://msdn.microsoft.com/en-us/library/system.threading.tasks.task.waitany%28v=vs.110%29.aspx");
        }

        public override string Description { get { return "Task.Wait"; } }

        public override void ExecuteDemo()
        {            
            var sites = new[] { @"http://www.google.com.au", @"http://www.yahoo.com.au", @"http://www.bing.com.au" };

            var stopwatch = Stopwatch.StartNew();
            var tasks = (from site in sites
                        select Task.Factory.StartNew(() => DownloadSite(site)))
                        .ToArray();

            Task.WaitAny(tasks);
            Console.WriteLine("WaitAny {0}ms", stopwatch.ElapsedMilliseconds);

            Task.WaitAll(tasks);
            Console.WriteLine("WaitAll {0}ms", stopwatch.ElapsedMilliseconds);
            stopwatch.Stop();            
        }

        private static void DownloadSite(string site)
        {            
            using (var client = new WebClient())
            {
                var download = client.DownloadString(site);
                Contract.Assert(!string.IsNullOrWhiteSpace(download));
            }                        
        }
    }
}
