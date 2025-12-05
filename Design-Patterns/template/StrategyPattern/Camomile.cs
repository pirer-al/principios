namespace DesignPatterns.Behavioral.Template.StrategyPattern
{
    public class Camomile : Beverage
    {
        public void Prepare()
        {
            Brew();
        }

        private void Brew()
        {
            System.Console.WriteLine("Brewing tea for 3 minutes");
        }
    }
}