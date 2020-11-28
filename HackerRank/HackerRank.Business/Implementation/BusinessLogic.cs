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
                "Exit",
                "Left Rotation",
                "Sparse Array",
                "Array Manipulation"
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
                    IArrayManipulation arrayManipulation = new ArrayManipulation();

                default:
                    return new Tuple<string, object, object>("", "", "");
            }
        }
    }
}
