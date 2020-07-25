using DesignPatterns.Business.StrategyPattern.Contracts;
using System.Collections.Generic;

namespace DesignPatterns.Business.StrategyPattern
{
    public class Context
    {
        public Context(IStrategy strategy)
        {
            this.strategy = strategy;
        }

        public List<string> Execute(List<string> list)
        {
            return strategy.Run(list);
        }

        //

        private readonly IStrategy strategy;
    }
}
