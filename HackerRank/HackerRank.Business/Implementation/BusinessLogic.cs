using HackerRank.Business.Contracts;
using HackerRank.Business.Services;
using System;
using System.Collections.Generic;

namespace HackerRank.Business.Implementation
{
    public class BusinessLogic : IBusinessLogic
    {
        public List<string> Challenges =>
            new List<string>
            {
                "Exit",
                "Left Rotation"
            };

        public Tuple<string, object, object> Run(int option)
        {
            switch (option)
            {
                case 1:
                    ILeftRotation leftRotation = new LefRotation();
                    var initialList = new List<int> { 1, 2, 3, 4, 5 };
                    var resultList = leftRotation.Rotate(initialList, 2);
                    return new Tuple<string, object, object>(Challenges[option], initialList, resultList);
                default:
                    return new Tuple<string, object, object>("", "", "");
            }
        }
    }
}
