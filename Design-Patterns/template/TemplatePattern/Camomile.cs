namespace DesignPatterns.Behavioral.Template.TemplatePattern
{
    public class Camomile : Beverage
    {
        protected override void Brew()
        {
            System.Console.WriteLine("Brewing for 5 min");
        }

    }
}