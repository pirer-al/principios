namespace OopPrinciples.Abstraction
{
    public class EmailService
    {
        private void Connect()
        {
            Console.WriteLine("Connecting to email server");
        }
        private void Authenticate()
        {
            Console.WriteLine("Authenticating");
        }
        public void SendEmail()
        {
            Connect();
            Authenticate();
            Console.WriteLine("Sending email...");
            Disconnect();
        }
        private void Disconnect()
        {
            Console.WriteLine("Disconnecting from email server...");
        }

    }
}