namespace DesignPatterns.Business.DecoratorPattern.Services
{
    public class Espresso : Beverage
    {
        public override double GetCost(double percentage) => 15 * percentage;
    }
}
