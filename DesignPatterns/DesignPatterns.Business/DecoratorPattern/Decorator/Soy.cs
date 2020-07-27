using DesignPatterns.Business.DecoratorPattern.Beverage;

namespace DesignPatterns.Business.DecoratorPattern.Decorator
{
    public class Soy : Flavour
    {
        public Soy(Drink drink)
            : base(drink) =>
            this.drink = drink;

        public override string GetDescription() => $"{drink.GetDescription()} with soy condiment";

        public override double GetCost() => drink.GetCost() + 4;

        //

        private readonly Drink drink;
    }
}
