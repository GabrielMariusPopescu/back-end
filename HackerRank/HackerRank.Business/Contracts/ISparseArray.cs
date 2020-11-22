using System.Collections.Generic;

namespace HackerRank.Business.Contracts
{
    public interface ISparseArray
    {
        IEnumerable<int> Sparse(List<string> strings, IEnumerable<string> queries);
    }
}