using System;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using CSharpCookbook.Interfaces;

namespace CSharpCookbook.ManageProgramFlow.Tasks
{
    public class TaskWaitCommand : ICommand, IMsdn
    {
        public string Description { get { return "Task.Wait"; } }

        public void Execute()
        {
            Console.WriteLine("TaskWaitCommand Entry");

            var sites = new[] { @"http://www.google.com.au", @"http://www.yahoo.com.au", @"http://www.bing.com.au" };

            var stopwatch = Stopwatch.StartNew();
            var tasks = (from site in sites
                        select Task.Factory.StartNew(() => DownloadSite(site)))
                        .ToArray();

            Task.WaitAny(tasks);
            Console.WriteLine("TaskWaitCommand WaitAny {0}ms", stopwatch.ElapsedMilliseconds);

            Task.WaitAll(tasks);
            Console.WriteLine("TaskWaitCommand WaitAll {0}ms", stopwatch.ElapsedMilliseconds);
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

        public string Title { get { return "Task.WaitAny Method"; } }
        public string Website { get { return @"http://msdn.microsoft.com/en-us/library/system.threading.tasks.task.waitany%28v=vs.110%29.aspx"; } }
    }
}
