using HackerRank.Business.Contracts;
using HackerRank.Business.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace HackerRank.Tests
{
    [TestClass]
    public class LeftRotationTests
    {
        [TestInitialize]
        public void Init()
        {
            leftRotation = new LefRotation();
        }

        [TestMethod]
        public void RotateLeftOnce()
        {
            var initialArray = new[] { 1, 2, 3, 4, 5 };
            var expectedArray = new[] { 3, 4, 5, 1, 2 };
            var actual = leftRotation.Rotate(initialArray, 2);
            Assert.IsTrue(expectedArray.SequenceEqual(actual));
        }

        //

        private ILeftRotation leftRotation;
    }
}
