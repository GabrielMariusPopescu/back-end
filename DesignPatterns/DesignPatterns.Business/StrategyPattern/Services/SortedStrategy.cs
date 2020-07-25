using DesignPatterns.Business.StrategyPattern.Contracts;
using System.Collections.Generic;

namespace DesignPatterns.Business.StrategyPattern.Services
{
    public class SortedStrategy : IStrategy
    {
        public List<string> Run(object data)
        {
            var list = (List<string>)data;
            list?.Sort();
            return list;
        }
    }
}
