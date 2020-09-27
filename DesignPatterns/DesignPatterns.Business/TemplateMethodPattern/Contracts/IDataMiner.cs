using System.Collections.Generic;

namespace DesignPatterns.Business.TemplateMethodPattern.Contracts
{
    public interface IDataMiner
    {
        IEnumerable<string> StartMining(string file);
    }
}
