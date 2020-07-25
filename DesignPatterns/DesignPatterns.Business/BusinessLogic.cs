using DesignPatterns.Business.StrategyPattern;
using DesignPatterns.Business.StrategyPattern.Contracts;
using DesignPatterns.Business.StrategyPattern.Services;
using System.Collections.Generic;

namespace DesignPatterns.Business
{
    public class BusinessLogic
    {
        public string GetPattern()
        {
            var list = new List<string> { "a", "b", "c", "d" };
            IStrategy strategy = new ReversedStrategy();
            var context = new Context(strategy);
            var result = context.Execute(list);
            return string.Join(" -> ", result);
        }
    }
}
