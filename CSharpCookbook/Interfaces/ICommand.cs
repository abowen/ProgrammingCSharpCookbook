namespace CSharpCookbook.Interfaces
{
    public interface ICommand
    {
        string Description { get; }
        void Execute();
    }
}
