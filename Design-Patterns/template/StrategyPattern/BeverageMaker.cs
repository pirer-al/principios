namespace DesignPatterns.Behavioral.Template.StrategyPattern
{
    public class BeverageMaker
    {
        private Beverage _beverage;

        public BeverageMaker(Beverage beverage)
        {
            _beverage = beverage;
        }

        public void MakeBeverage()
        {
            BoilWater();
            PourWaterIntoCoup();
            _beverage.Prepare();
        }

        public void SetBeverage(Beverage beverage)
        {
            _beverage = beverage;
        }

        private void BoilWater()
        {
            System.Console.WriteLine("Boiling water");
        }
        
        private void PourWaterIntoCoup()
        {
            System.Console.WriteLine("Pouring water into coup");
        }

    }
}