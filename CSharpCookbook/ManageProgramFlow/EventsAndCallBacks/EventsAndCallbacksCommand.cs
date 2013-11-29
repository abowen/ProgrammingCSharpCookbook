using CSharpCookbook.BaseCommands;
using CSharpCookbook.ManageProgramFlow.EventsAndCallBacks.Delegates;
using CSharpCookbook.ManageProgramFlow.ProgramFlow.EventsAndCallBacks;

namespace CSharpCookbook.ManageProgramFlow.EventsAndCallBacks
{
    public class EventsAndCallbacksCommand: DisplayCommand
    {
        public override string Description
        {
            get { return "Events And Callbacks"; }
        }

        public EventsAndCallbacksCommand()
        {
            AddCommand(new DelegateCommand());
            AddCommand(new EventHandlerCommand());
            AddCommand(new EventHandlerGenericCommand());
            AddCommand(new EventArgsCommand());
        }
    }
}
