using System.Collections.Generic;

namespace DesignPatterns.Business.StrategyPattern.Contracts
{
    public interface IStrategy
    {
        List<string> Run(object data);
    }
}