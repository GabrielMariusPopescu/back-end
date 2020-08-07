using DesignPatterns.Business.DecoratorPattern.Beverage;

namespace DesignPatterns.Business.DecoratorPattern.Decorator
{
    public abstract class Flavour : Drink
    {
        protected Flavour(Drink drink) => this.drink = drink;

        public override string GetDescription() => string.Empty;

        public override double GetCost() => 0.0;

        //

        private readonly Drink drink;
    }
}
