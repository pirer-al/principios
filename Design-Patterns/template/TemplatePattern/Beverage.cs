namespace DesignPatterns.Behavioral.Template.TemplatePattern
{
    public abstract class Beverage
    {
        public void Prepare()
        {
            BoilWater();
            PourWaterIntoCoup();
            Brew();
            AddCondiments();
        }
        
        private void BoilWater()
        {
            System.Console.WriteLine("Boiling water");
        }

        private void PourWaterIntoCoup()
        {
            System.Console.WriteLine("Pouring water into cup");
        }

        protected abstract void Brew();

        protected virtual void AddCondiments() {}
    }
}