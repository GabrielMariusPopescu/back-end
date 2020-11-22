using System.Collections.Generic;

namespace HackerRank.Business.Contracts
{
    public interface ILeftRotation
    {
        IEnumerable<int> Rotate(IEnumerable<int> initialArray, int rotation);
    }
}
