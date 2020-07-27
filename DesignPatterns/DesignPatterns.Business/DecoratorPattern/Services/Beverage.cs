namespace DesignPatterns.Business.DecoratorPattern.Services
{
    public abstract class Beverage
    {
        public virtual string GetDescription(string beverage) =>
            $"{beverage} description";

        public virtual double GetCost(double percentage) =>
            10 * percentage;
    }
}
