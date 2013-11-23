namespace CSharpCookbook
{
    public interface ICommand
    {
        string Description { get; }
        void Execute();
    }
}
