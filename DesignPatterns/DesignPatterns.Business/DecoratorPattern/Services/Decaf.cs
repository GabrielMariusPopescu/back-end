namespace DesignPatterns.Business.DecoratorPattern.Services
{
    public class Decaf
    {
        public virtual double GetCost(double percentage) => 5 * percentage;
    }
}
