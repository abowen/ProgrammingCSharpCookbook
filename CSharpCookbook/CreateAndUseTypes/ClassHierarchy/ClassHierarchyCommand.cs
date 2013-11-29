using CSharpCookbook.BaseCommands;
using CSharpCookbook.CreateAndUseTypes.ClassHierarchy.Interfaces;

namespace CSharpCookbook.CreateAndUseTypes.ClassHierarchy
{
    public class ClassHierarchyCommand : DisplayCommand
    {
        public override string Description
        {
            get { return "Class Hierarchy"; }
        }

        public ClassHierarchyCommand()
        {
            AddCommand(new InterfaceCommand());
            AddCommand(new ComparableCommand());
            AddCommand(new EnumerableCommand());
        }
    }
}