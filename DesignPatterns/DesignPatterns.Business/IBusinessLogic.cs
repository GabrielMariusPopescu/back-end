using System.Collections.Generic;

namespace DesignPatterns.Business
{
    public interface IBusinessLogic
    {
        IEnumerable<string> ReadNotes();
    }
}
