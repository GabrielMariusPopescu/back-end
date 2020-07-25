using DesignPatterns.Business.StrategyPattern;
using DesignPatterns.Business.StrategyPattern.Contracts;
using DesignPatterns.Business.StrategyPattern.Services;
using NUnit.Framework;
using System.Collections.Generic;

namespace DesignPatterns.Tests
{
    [TestFixture]
    public class StrategyPatternTests
    {
        [SetUp]
        public void Init()
        {
            letters = new List<string> { "a", "b", "c", "d" };
        }

        [Test]
        public void ReversedAndUpperStrategies()
        {
            ISort sort = new ReversedSort();
            IDisplay display = new UppercaseDisplay();
            var context = new Context(sort, display);
            var reversedSort = context.Sort(letters);
            var uppercase = context.Display(letters);
            Assert.AreEqual("d,c,b,a", string.Join(",", reversedSort));
            Assert.AreEqual("D,C,B,A", string.Join(",", uppercase));
        }

        [Test]
        public void NormalAndLowerStrategies()
        {
            ISort sort = new SortedSort();
            IDisplay display = new LowercaseDisplay();
            var context = new Context(sort, display);
            var normalSort = context.Sort(letters);
            var lowercase = context.Display(letters);
            Assert.AreEqual("a,b,c,d", string.Join(",", normalSort));
            Assert.AreEqual("a,b,c,d", string.Join(",", lowercase));
        }

        [Test]
        public void ReversedAndLowerStrategies()
        {
            ISort sort = new ReversedSort();
            IDisplay display = new LowercaseDisplay();
            var context = new Context(sort, display);
            var reversedSort = context.Sort(letters);
            var lowercase = context.Display(letters);
            Assert.AreEqual("d,c,b,a", string.Join(",", reversedSort));
            Assert.AreEqual("d,c,b,a", string.Join(",", lowercase));
        }

        [Test]
        public void NormalAndUpperStrategies()
        {
            ISort sort = new SortedSort();
            IDisplay display = new UppercaseDisplay();
            var context = new Context(sort, display);
            var normalSort = context.Sort(letters);
            var lowercase = context.Display(letters);
            Assert.AreEqual("a,b,c,d", string.Join(",", normalSort));
            Assert.AreEqual("A,B,C,D", string.Join(",", lowercase));
        }

        //

        private List<string> letters;
    }
}
