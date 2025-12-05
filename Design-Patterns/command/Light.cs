namespace DesignPatterns.Behavioral.Command
{
    // Receiver
    public class Light
    {
        public void TurnOn()
        {
            System.Console.WriteLine("Light has turned on");
        }

        public void TurnOff()
        {
            System.Console.WriteLine("Light has been turned off");
        }
    }
}