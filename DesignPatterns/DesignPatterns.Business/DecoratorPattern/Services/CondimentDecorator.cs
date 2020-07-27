namespace DesignPatterns.Business.DecoratorPattern.Services
{
    public class CondimentDecorator : Beverage
    {
        public override string GetDescription(string beverage)
        {
            return $"{beverage} condiment";
        }
    }
}
