using HackerRank.Business.Contracts;
using HackerRank.Business.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerRank.Tests
{
    [TestClass]
    public class BalancedBracketsTests
    {
        [TestInitialize]
        public void Init()
        {
            balancedBrackets = new BalancedBrackets();
        }

        [TestMethod]
        [DataRow("{[()]}")]
        [DataRow("{{[[(())]]}}")]
        [DataRow("{{([])}}")]
        [DataRow("{(([])[])[]}")]
        [DataRow("{(([])[])[]}[]")]
        public void FirstSetReturnsTrue(string brackets)
        {
            var actual = balancedBrackets.AreBalanced(brackets);
            Assert.AreEqual("YES", actual);
        }

        [TestMethod]
        [DataRow("{[(])}")]
        [DataRow("{{)[](}}")]
        [DataRow("{(([])[])[]]}")]
        public void SecondSetReturnsFalse(string brackets)
        {
            var actual = balancedBrackets.AreBalanced(brackets);
            Assert.AreEqual("NO", actual);
        }

        //

        private IBalancedBrackets balancedBrackets;

    }
}
