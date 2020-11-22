using HackerRank.Business.Contracts;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank.Business.Services
{
    public class LefRotation : ILeftRotation
    {
        public IEnumerable<int> Rotate(IEnumerable<int> initialArray, int rotation)
        {
            var resultArray = initialArray.ToList();
            for (var i = 0; i < rotation; i++)
            {
                var item = resultArray[0];
                resultArray.RemoveAt(0);
                resultArray.Add(item);
            }

            return resultArray.ToList();
        }
    }
}