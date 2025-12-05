namespace DesignPatterns.Behavioral.Command.Undoable
{
    public class UndoCommand : Command
    {
        private History _history;
        
        public UndoCommand(History history)
        {
            _history = history;
        }
        public void Execute()
        {
            if (_history.Size() > 0)
            {
                var lastCommand = _history.Pop();
                lastCommand.Unexecute();
            }
        }
    }
}