using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpCookbook.ManageProgramFlow.Tasks
{
    public class ContinueWithCommand : ICommand
    {
        public string Description { get { return "Task.ContinueWith"; } }

        public void Execute()
        {
            Console.WriteLine("TaskFactoryCommand Entry");
            var getTask = Task<double>.Factory.StartNew(() =>
            {
                var input = 1000;
                return Calculate(input);
            });
            Console.WriteLine("TaskFactoryCommand Waiting");
            getTask.ContinueWith(t => Console.WriteLine("TaskFactoryCommand ContinueWith"));
            Console.WriteLine("TaskFactoryCommand Complete");
            Thread.Sleep(5000);
        }

        private static double Calculate(int input)
        {
            Console.WriteLine("TaskFactoryCommand Calculate Start");
            var values = Enumerable.Range(0, input); 
            var otherValues = values.Select(value => Math.Sqrt(value));
            var result = otherValues.Sum();
            Console.WriteLine("TaskFactoryCommand Calculate Complete: {0}", result);
            return result;
        }
    }
}
