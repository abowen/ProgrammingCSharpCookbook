using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using CSharpCookbook.BaseCommands;

namespace CSharpCookbook.ManageProgramFlow.Asynchronous.Tasks
{
    public class ContinueWithCommand : DemoCommand
    {
        public ContinueWithCommand()
        {
            AddResource("Task.ContinueWith Method", "http://msdn.microsoft.com/en-us/library/system.threading.tasks.task.continuewith%28v=vs.110%29.aspx");
        }

        public override string Description { get { return "Task.ContinueWith"; } }

        public override void ExecuteDemo()
        {            
            var getTask = Task<double>.Factory.StartNew(() =>
            {
                Console.WriteLine("ContinueWithCommand StartNew");                
                return Calculate(1000);
            });
            Console.WriteLine("ContinueWithCommand Waiting");
            getTask.ContinueWith(t => Console.WriteLine("ContinueWithCommand ContinueWith"));            
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
    }
}
