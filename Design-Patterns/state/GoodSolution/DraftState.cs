namespace DesignPatterns.Behavioral.State.GoodSolution
{
    public class DraftState: State
    {
        public Document _document;
        
        public DraftState(Document document)
        {
            _document = document;
        }
        
        public void Publish()
        {
            _document.State = new ModerationState(_document);
        }
    }
}