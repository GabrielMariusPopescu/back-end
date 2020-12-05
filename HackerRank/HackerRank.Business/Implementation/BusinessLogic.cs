using HackerRank.Business.Contracts;
using HackerRank.Business.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank.Business.Implementation
{
    public class BusinessLogic : IBusinessLogic
    {
        public List<string> Challenges =>
            new List<string>
            {
                "Left Rotation",
                "Sparse Array",
                "Balanced Brackets"
            };

        public Tuple<string, object, object> Run(int option)
        {
            var firstList = new List<string>();
            var secondList = new List<string>();
            switch (option)
            {
                case 1:
                    ILeftRotation leftRotation = new LefRotation();
                    var initialList = new List<int> { 1, 2, 3, 4, 5 };
                    var resultList = leftRotation.Rotate(initialList, 2).ToList();
                    firstList.AddRange(initialList.Select(initialItem => $"{initialItem} "));
                    secondList.AddRange(resultList.Select(initialResult => $"{initialResult} "));
                    return new Tuple<string, object, object>(Challenges[option], firstList, secondList);
                case 2:
                    ISparseArray sparseArray = new SparseArray();
                    var strings = new List<string> { "aba", "baba", "aba", "xzxb" };
                    var queries = new List<string> { "aba", "xzxb", "ab" };
                    var result = sparseArray.Sparse(strings, queries).ToList();
                    firstList.AddRange(strings.Select(it => $"{it} "));
                    secondList.AddRange(result.Select(initialResult => $"{initialResult} "));
                    return new Tuple<string, object, object>(Challenges[option], firstList, secondList);
                case 3:
                    IBalancedBrackets balancedBrackets = new BalancedBrackets();
                    var brackets = "{[()]}";
                    firstList.Add(brackets);
                    var areBalanced = balancedBrackets.AreBalanced(brackets);
                    secondList.Add(areBalanced);
                    return new Tuple<string, object, object>(Challenges[option], firstList, secondList);
                default:
                    return new Tuple<string, object, object>("", "", "");
            }
        }
    }
}
