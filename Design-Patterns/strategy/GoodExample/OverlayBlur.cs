namespace DesignPatterns.Behavioral.Strategy.GoodExample
{
    public class OverlayBlur : IOverlay
    {
        public void Apply()
        {
            System.Console.WriteLine("Applying blur overlay");
        }
    }
}