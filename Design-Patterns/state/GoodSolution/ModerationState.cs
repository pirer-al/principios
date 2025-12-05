namespace DesignPatterns.Behavioral.State.GoodSolution
{
    public class ModerationState : State
    {
        private Document _document;

        public ModerationState(Document document)
        {
            this._document = document;
        }
        
        public void Publish()
        {
            if (_document.CurrentUserRole == UserRoles.Admin)
            {
                _document.State = new PublishedState(_document);
                
            }
        }
    }
}