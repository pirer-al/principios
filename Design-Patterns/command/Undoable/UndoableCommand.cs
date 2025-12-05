namespace DesignPatterns.Behavioral.Command.Undoable
{
    public interface UndoableCommand : Command
    {
        void Unexecute();
    }
}