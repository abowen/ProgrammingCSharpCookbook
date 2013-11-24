using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using CSharpCookbook.Interfaces;

namespace CSharpCookbook.ManageProgramFlow.Tasks
{
    public class ContinueWithCommand : ICommand, IMsdn
    {
        public string Description { get { return "Task.ContinueWith"; } }

        public void Execute()
        {
            Console.WriteLine("ContinueWithCommand Entry");
            var getTask = Task<double>.Factory.StartNew(() =>
            {
                var input = 1000;
                return Calculate(input);
            });
            Console.WriteLine("ContinueWithCommand Waiting");
            getTask.ContinueWith(t => Console.WriteLine("ContinueWithCommand ContinueWith"));
            Console.WriteLine("ContinueWithCommand Complete");
            Thread.Sleep(5000);
        }

        private static double Calculate(int input)
        {
            Console.WriteLine("ContinueWithCommand Calculate Start");
            var values = Enumerable.Range(0, input); 
            var otherValues = values.Select(value => Math.Sqrt(value));
            var result = otherValues.Sum();
            Console.WriteLine("ContinueWithCommand Calculate Complete: {0}", result);
            return result;
        }

        public string Title { get { return "Task.ContinueWith Method"; } }
        public string Website { get { return @"http://msdn.microsoft.com/en-us/library/system.threading.tasks.task.continuewith%28v=vs.110%29.aspx"; } }
    }
}
