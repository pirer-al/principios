namespace DesignPatterns.Behavioral.Command.Undoable
{
    public class History
    {
        private List<UndoableCommand> _commands = new();

        public void Push(UndoableCommand undoableCommand)
        {
            _commands.Add(undoableCommand);
        }

        public UndoableCommand Pop()
        {
            var last = _commands.Last();
            _commands.Remove(last);
            return last;
        }

        public int Size()
        {
            return _commands.Count;
        }
    }
}