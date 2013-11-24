using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using CSharpCookbook.BaseCommands;

namespace CSharpCookbook.ManageProgramFlow.ManageMultithreading.Synchronize
{
    public class WaitCommand : DemoCommand
    {
        public WaitCommand()
        {
            AddResource("Monitor Class", "http://msdn.microsoft.com/en-us/library/system.threading.monitor.aspx");
        }
        
        public override string Description
        {
            get { return "Monitor"; }
        }

        public override void ExecuteDemo()
        {
            Console.WriteLine("Monitor Start");
            var taskConsume = Task.Factory.StartNew(Consume);
            var taskProduce = Task.Factory.StartNew(Produce);
            Task.WaitAll(taskConsume, taskProduce);
            Console.WriteLine("Monitor Complete");
        }

        private readonly Queue<int> _list = new Queue<int>();

        private void Consume()
        {
            lock (_list)
            {
                while (!_list.Any())
                {
                    Monitor.Wait(_list);
                    Console.WriteLine("Dequeue : {0}", _list.Dequeue());
                }
            }
        }

        private void Produce()
        {
            lock (_list)
            {

                Console.WriteLine("Enqueue : 1");
                _list.Enqueue(1);
                Monitor.PulseAll(_list);
            }
        }
    }
}
