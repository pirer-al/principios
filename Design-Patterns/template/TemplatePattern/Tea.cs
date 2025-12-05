namespace DesignPatterns.Behavioral.Template.TemplatePattern
{
    public class Tea : Beverage
    {
        protected override void Brew()
        {
            System.Console.WriteLine("Brewing for 3 min");
        }

        protected override void AddCondiments()
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