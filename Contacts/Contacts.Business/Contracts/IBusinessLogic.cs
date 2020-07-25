using System.Collections.Generic;

namespace Contacts.Business.Contracts
{
    public interface IBusinessLogic
    {
        IEnumerable<string> OriginalFiles { get; set; }
        void GetOriginalFiles();
        void MergeFiles();
    }
}