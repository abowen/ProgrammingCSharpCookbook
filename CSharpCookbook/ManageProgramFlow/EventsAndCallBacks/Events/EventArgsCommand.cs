using System;
using CSharpCookbook.BaseCommands;

namespace CSharpCookbook.ManageProgramFlow.ProgramFlow.EventsAndCallBacks
{
    public class EventArgsCommand : DemoCommand
    {
        public EventArgsCommand()
        {
            AddResource("Raise and Consume Events", "http://msdn.microsoft.com/en-us/library/9aackb16(v=vs.110).aspx");
            AddResource("Events", "C# In A NutShell, Location 6197");
        }

        public override string Description
        {
            get { return "Custom Event Args"; }
        }

        public event EventHandler<MyCustomEventArgs> MyEventHandler;

        public override void ExecuteDemo()
        {            
            MyEventHandler += OnMyEventHandler;
            MyEventHandler += delegate(object sender, MyCustomEventArgs args) { Console.WriteLine("Delegate Event Args {0}", args.MyValue); };
            MyEventHandler += (sender, args) => Console.WriteLine("Anonymous Event Args {0}", args.MyValue);

            var handler = MyEventHandler;
            if (handler != null)
            {
                handler(this, new MyCustomEventArgs() { MyValue = 123});
            }
        }

        private void OnMyEventHandler(object sender, MyCustomEventArgs eventArgs)
        {
            Console.WriteLine("Method Event Args {0}", eventArgs.MyValue);
        }
    }

    public class MyCustomEventArgs : EventArgs
    {
        public int MyValue { get; set; }
    }
}
