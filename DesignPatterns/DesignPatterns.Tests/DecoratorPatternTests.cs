using DesignPatterns.Business.DecoratorPattern.Beverage;
using DesignPatterns.Business.DecoratorPattern.Decorator;
using NUnit.Framework;

namespace DesignPatterns.Tests
{
    [TestFixture]
    public class DecoratorPatternTests
    {
        [SetUp]
        public void Init()
        {
            espresso = new Espresso();
            decaf = new Decaf();

            espressoWithCaramel = new Caramel(espresso);
            espressoWithSoy = new Soy(espresso);
            decafWithCaramel = new Caramel(decaf);
            decafWithSoy = new Soy(decaf);

            combinedCaramelWithSoyEspresso = new Caramel(new Soy(espresso));
            combinedSoyWithCaramelDecaf = new Soy(new Caramel(decaf));
        }

        [Test]
        public void DrinkAsEspresso()
        {
            var description = espresso.GetDescription();
            Assert.AreEqual("espresso", description);

            var cost = espresso.GetCost();
            Assert.AreEqual(3.50, cost);

        }

        [Test]
        public void DrinkAsDecaf()
        {
            var description = decaf.GetDescription();
            Assert.AreEqual("decaf", description);

            var cost = decaf.GetCost();
            Assert.AreEqual(2.00, cost);
        }

        [Test]
        public void EspressoWithCaramel()
        {
            var description = espressoWithCaramel.GetDescription();
            Assert.AreEqual("espresso with caramel flavour", description);

            var cost = espressoWithCaramel.GetCost();
            Assert.AreEqual(5.50, cost);
        }

        [Test]
        public void EspressoWithSoy()
        {
            var description = espressoWithSoy.GetDescription();
            Assert.AreEqual("espresso with soy flavour", description);

            var cost = espressoWithSoy.GetCost();
            Assert.AreEqual(7.50, cost);
        }

        [Test]
        public void DecafWithCaramel()
        {
            var description = decafWithCaramel.GetDescription();
            Assert.AreEqual("decaf with caramel flavour", description);

            var cost = decafWithCaramel.GetCost();
            Assert.AreEqual(4.00, cost);
        }

        [Test]
        public void DecafWithSoy()
        {
            var description = decafWithSoy.GetDescription();
            Assert.AreEqual("decaf with soy flavour", description);

            var cost = decafWithSoy.GetCost();
            Assert.AreEqual(6.00, cost);
        }

        [Test]
        public void AddCaramelAndSoyInEspresso()
        {
            var description = combinedCaramelWithSoyEspresso.GetDescription();
            Assert.AreEqual("espresso with soy flavour with caramel flavour", description);

            var cost = combinedCaramelWithSoyEspresso.GetCost();
            Assert.AreEqual(9.50, cost);
        }

        [Test]
        public void AddSoyAndCaramelInDecaf()
        {
            var description = combinedSoyWithCaramelDecaf.GetDescription();
            Assert.AreEqual("decaf with caramel flavour with soy flavour", description);

            var cost = combinedSoyWithCaramelDecaf.GetCost();
            Assert.AreEqual(8.00, cost);
        }

        //

        private Drink espresso;
        private Drink decaf;

        private Flavour espressoWithCaramel;
        private Flavour espressoWithSoy;
        private Flavour decafWithCaramel;
        private Flavour decafWithSoy;

        private Flavour combinedCaramelWithSoyEspresso;
        private Flavour combinedSoyWithCaramelDecaf;
    }
}
