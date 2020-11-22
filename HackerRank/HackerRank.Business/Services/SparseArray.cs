using HackerRank.Business.Contracts;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank.Business.Services
{
    public class SparseArray : ISparseArray
    {
        public IEnumerable<int> Sparse(List<string> strings, IEnumerable<string> queries)
        {
            return queries
                   .Select(query => strings.Count(s => s.Equals(query)))
                   .ToArray();
        }
    }
}