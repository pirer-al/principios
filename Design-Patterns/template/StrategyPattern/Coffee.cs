namespace DesignPatterns.Behavioral.Template.StrategyPattern
{
    public class Coffe : Beverage
    {
        public void Prepare()
        {
            Brew();
            AddCondiments();
        }

        private void Brew()
        {
            System.Console.WriteLine("Brewing tea for 5 minutes");
        }

        private void AddCondiments()
        {
            if (CustomerWantsCondiments())
            {
                System.Console.WriteLine("Adding lemon to tea");
            }
        }
        
        private bool CustomerWantsCondiments()
        {
            System.Console.WriteLine("Would you like lemon with your tea? (y/n)");
            var input = Console.ReadLine();
            return true ? input == "y" : false;
        }
    }
}