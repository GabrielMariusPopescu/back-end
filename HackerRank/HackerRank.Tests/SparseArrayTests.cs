using HackerRank.Business.Contracts;
using HackerRank.Business.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank.Tests
{
    [TestClass]
    public class SparseArrayTests
    {
        [TestInitialize]
        public void Init()
        {
            sparseArray = new SparseArray();
        }

        [TestMethod]
        public void SparseFirstTest()
        {
            var array = new List<string> { "aba", "baba", "aba", "xzxb" };
            var query = new List<string> { "aba", "xzxb", "ab" };
            var result = sparseArray.Sparse(array, query);
            var itemsPresent = new List<int> { 2, 1, 0 };
            Assert.IsTrue(itemsPresent.SequenceEqual(result));
        }

        [TestMethod]
        public void SparseSecondTest()
        {
            var array = new List<string> { "abcde", "sdaklfj", "asdjf", "na", "basdn", "sdaklfj", "asdjf", "na", "asdjf", "na", "basdn", "sdaklfj", "asdjf" };
            var query = new List<string> { "abcde", "sdaklfj", "asdjf", "na", "basdn" };
            var result = sparseArray.Sparse(array, query);
            var itemsPresent = new List<int> { 1, 3, 4, 3, 2 };
            Assert.IsTrue(itemsPresent.SequenceEqual(result));
        }


        [TestMethod]
        public void SparseThirdTest()
        {
            var array = new List<string> { "def", "de", "fgh" };
            var query = new List<string> { "de", "lmn", "fgh" };
            var result = sparseArray.Sparse(array, query);
            var itemsPresent = new List<int> { 1, 0, 1 };
            Assert.IsTrue(itemsPresent.SequenceEqual(result));
        }


        [TestMethod]
        public void SparseFourthTest()
        {
            var array = new List<string> { "lekgdisnsbfdzpqlkg", "eagemhdygyv", "jwvwwnrhuai", "urcadmrwlqe", "mpgqsvxrijpombyv", "mpgqsvxrijpombyv", "urcadmrwlqe",
                "mpgqsvxrijpombyv", "eagemhdygyv", "eagemhdygyv", "jwvwwnrhuai", "urcadmrwlqe", "jwvwwnrhuai", "kvugevicpsdf", "kvugevicpsdf", "mpgqsvxrijpombyv", "urcadmrwlqe",
                "mpgqsvxrijpombyv", "exdafbnobg", "qhootohpnfvbl", "suffrbmqgnln", "exdafbnobg", "exdafbnobg", "eagemhdygyv", "mpgqsvxrijpombyv", "urcadmrwlqe", "jwvwwnrhuai",
                "lekgdisnsbfdzpqlkg", "mpgqsvxrijpombyv", "lekgdisnsbfdzpqlkg", "jwvwwnrhuai", "exdafbnobg", "mpgqsvxrijpombyv", "kvugevicpsdf", "qhootohpnfvbl", "urcadmrwlqe",
                "kvugevicpsdf", "mpgqsvxrijpombyv", "lekgdisnsbfdzpqlkg", "mpgqsvxrijpombyv", "kvugevicpsdf", "qhootohpnfvbl", "lxyqetmgdbmh", "urcadmrwlqe", "urcadmrwlqe",
                "kvugevicpsdf", "lxyqetmgdbmh", "urcadmrwlqe", "lxyqetmgdbmh", "jwvwwnrhuai", "qhootohpnfvbl", "qhootohpnfvbl", "jwvwwnrhuai", "lekgdisnsbfdzpqlkg", "kvugevicpsdf",
                "mpgqsvxrijpombyv", "exdafbnobg", "kvugevicpsdf", "lekgdisnsbfdzpqlkg", "qhootohpnfvbl", "exdafbnobg", "qhootohpnfvbl", "exdafbnobg", "mpgqsvxrijpombyv",
                "suffrbmqgnln", "mpgqsvxrijpombyv", "qhootohpnfvbl", "jwvwwnrhuai", "mpgqsvxrijpombyv", "qhootohpnfvbl", "lekgdisnsbfdzpqlkg", "eagemhdygyv", "jwvwwnrhuai",
                "kvugevicpsdf", "eagemhdygyv", "eagemhdygyv", "lxyqetmgdbmh", "qhootohpnfvbl", "lxyqetmgdbmh", "exdafbnobg", "qhootohpnfvbl", "qhootohpnfvbl", "exdafbnobg",
                "suffrbmqgnln", "mpgqsvxrijpombyv", "urcadmrwlqe", "eagemhdygyv", "lxyqetmgdbmh", "urcadmrwlqe", "suffrbmqgnln", "qhootohpnfvbl", "kvugevicpsdf", "lekgdisnsbfdzpqlkg",
                "lxyqetmgdbmh", "mpgqsvxrijpombyv", "jwvwwnrhuai", "lxyqetmgdbmh", "lxyqetmgdbmh", "lekgdisnsbfdzpqlkg", "qhootohpnfvbl", };

            var query = new List<string> {
                "exdafbnobg", "eagemhdygyv", "mpgqsvxrijpombyv", "kvugevicpsdf", "lekgdisnsbfdzpqlkg", "kvugevicpsdf", "exdafbnobg", "qhootohpnfvbl",
                "eagemhdygyv", "kvugevicpsdf", "suffrbmqgnln", "jwvwwnrhuai", "lekgdisnsbfdzpqlkg", "lekgdisnsbfdzpqlkg", "mpgqsvxrijpombyv", "jwvwwnrhuai",
                "kvugevicpsdf", "lekgdisnsbfdzpqlkg", "exdafbnobg", "suffrbmqgnln", "qhootohpnfvbl", "eagemhdygyv", "exdafbnobg", "suffrbmqgnln", "jwvwwnrhuai",
                "qhootohpnfvbl", "eagemhdygyv", "exdafbnobg", "exdafbnobg", "jwvwwnrhuai", "qhootohpnfvbl", "lxyqetmgdbmh", "qhootohpnfvbl", "suffrbmqgnln",
                "lxyqetmgdbmh", "qhootohpnfvbl", "eagemhdygyv", "jwvwwnrhuai", "eagemhdygyv", "qhootohpnfvbl", "mpgqsvxrijpombyv", "qhootohpnfvbl",
                "jwvwwnrhuai", "exdafbnobg", "eagemhdygyv", "eagemhdygyv", "kvugevicpsdf", "kvugevicpsdf", "jwvwwnrhuai", "urcadmrwlqe", "lxyqetmgdbmh",
                "qhootohpnfvbl", "exdafbnobg", "exdafbnobg", "eagemhdygyv", "qhootohpnfvbl", "exdafbnobg", "exdafbnobg", "lekgdisnsbfdzpqlkg", "jwvwwnrhuai",
                "eagemhdygyv", "urcadmrwlqe", "kvugevicpsdf", "lekgdisnsbfdzpqlkg", "jwvwwnrhuai", "eagemhdygyv", "lekgdisnsbfdzpqlkg", "exdafbnobg",
                "kvugevicpsdf", "jwvwwnrhuai", "exdafbnobg", "lxyqetmgdbmh", "exdafbnobg", "lxyqetmgdbmh", "jwvwwnrhuai", "mpgqsvxrijpombyv", "eagemhdygyv",
                "urcadmrwlqe", "kvugevicpsdf", "qhootohpnfvbl", "jwvwwnrhuai", "eagemhdygyv", "urcadmrwlqe", "urcadmrwlqe", "exdafbnobg", "qhootohpnfvbl",
                "exdafbnobg", "eagemhdygyv", "exdafbnobg", "jwvwwnrhuai", "eagemhdygyv", "jwvwwnrhuai", "mpgqsvxrijpombyv", "urcadmrwlqe", "urcadmrwlqe",
                "eagemhdygyv", "eagemhdygyv", "jwvwwnrhuai", "suffrbmqgnln", "eagemhdygyv"
            };
            var result = sparseArray.Sparse(array, query);
            var itemsPresent = new List<int> {
                9, 8, 16, 10, 9, 10, 9, 14, 8, 10, 4, 10, 9, 9, 16, 10, 10, 9, 9, 4, 14, 8, 9, 4, 10, 14, 8, 9, 9, 10, 14, 9, 14, 4, 9, 14, 8, 10, 8, 14, 16,
                14, 10, 9, 8, 8, 10, 10, 10, 11, 9, 14, 9, 9, 8, 14, 9, 9, 9, 10, 8, 11, 10, 9, 10, 8, 9, 9, 10, 10, 9, 9, 9, 9, 10, 16, 8, 11, 10, 14, 10, 8,
                11, 11, 9, 14, 9, 8, 9, 10, 8, 10, 16, 11, 11, 8, 8, 10, 4, 8
            };
            Assert.IsTrue(itemsPresent.SequenceEqual(result));
        }
        //

        private ISparseArray sparseArray;
    }
}
