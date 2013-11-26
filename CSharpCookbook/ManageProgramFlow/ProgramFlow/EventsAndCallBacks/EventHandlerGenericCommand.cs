using System;
using CSharpCookbook.BaseCommands;

namespace CSharpCookbook.ManageProgramFlow.ProgramFlow.EventsAndCallBacks
{
    public class EventHandlerGenericCommand : DemoCommand
    {
        public EventHandlerGenericCommand()
        {
            AddResource("Handling and Raising Events", "http://msdn.microsoft.com/en-us/library/edzehd2t.aspx");
            AddResource("Events", "C# In A NutShell, Location 6197");
        }

        public override string Description
        {
            get { return "Generic Event Handler"; }
        }

        public event EventHandler<int> MyGenericEventHandler;

        public override void ExecuteDemo()
        {            
            MyGenericEventHandler += OnMyGenericEventHandler;

            MyGenericEventHandler += delegate(object sender, int i) { Console.WriteLine("Delegate Event Handler {0}", i); };

            MyGenericEventHandler += (sender, i) => Console.WriteLine("Anonymous Event Handler {0}", i);

            if (MyGenericEventHandler != null)
            {
                MyGenericEventHandler(this, 123);
            }
        }

        private void OnMyGenericEventHandler(object sender, int i)
        {
            Console.WriteLine("Method Event Handler {0}", i);
        }        
    }
}
