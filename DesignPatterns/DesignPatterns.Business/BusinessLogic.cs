using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DesignPatterns.Business
{
    public class BusinessLogic : IBusinessLogic
    {
        public IEnumerable<string> ReadNotes() =>
            Directory.GetFiles("../../../DesignPatterns.Business/", "NOTES.txt", SearchOption.AllDirectories)
                     .ToList();
    }
}
