namespace DesignPatterns.Behavioral.State.GoodSolution
{
    public class PublishedState : State
    {
        private Document _document; 
        
        public PublishedState(Document document)
        {
            _document = document;
        }
        
        public void Publish()
        {
            // do nothing if already in published state
        }
    }
}