using System;
using CSharpCookbook.BaseCommands;

namespace CSharpCookbook.ManageProgramFlow.ProgramFlow.EventsAndCallBacks
{
    public class EventHandlerCommand : DemoCommand
    {
        public EventHandlerCommand()
        {
            AddResource("Raise and Consume Events", "http://msdn.microsoft.com/en-us/library/9aackb16(v=vs.110).aspx");
            AddResource("Events", "C# In A NutShell, Location 6197");
        }

        public override string Description
        {
            get { return "Event Handler"; }
        }

        public event EventHandler MyEventHandler;

        public override void ExecuteDemo()
        {            
            MyEventHandler += OnMyEventHandler;
            MyEventHandler += delegate(object sender, EventArgs args) { Console.WriteLine("Delegate Event Handler"); };
            MyEventHandler += (sender, args) => Console.WriteLine("Anonymous Event Handler");

            var handler = MyEventHandler;
            if (handler != null)
            {
                handler(this, null);
            }
        }

        private void OnMyEventHandler(object sender, EventArgs eventArgs)
        {
            Console.WriteLine("Method Event Handler");
        }
    }
}
