using System;
using System.Collections.Generic;

namespace HackerRank.Business.Contracts
{
    public interface IBusinessLogic
    {
        List<string> Challenges { get; }

        Tuple<string, object, object> Run(int option);
    }
}
