namespace DesignPatterns.Behavioral.Command.Undoable
{
    public class ItalicCommand : UndoableCommand
    {
        private HtmlDocument _doc;
        private string _prevContent;

        private History _history;
        
        public ItalicCommand(HtmlDocument document, History history)
        {
            _doc = document;
            _history = history;
        }
        
        public void Execute()
        {
            _prevContent = _doc.Content;
            _doc.MakeItalic();
            _history.Push(this);
        }

        public void Unexecute()
        {
            _doc.Content = _prevContent;
        }
    }
}