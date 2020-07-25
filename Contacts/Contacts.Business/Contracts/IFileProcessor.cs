using System.Collections.Generic;

namespace Contacts.Business.Contracts
{
    public interface IFileProcessor
    {
        IEnumerable<string> GetOneDriveDirectories();
        IEnumerable<string> GetFiles(IEnumerable<string> directories);
        IEnumerable<string[]> Read(IEnumerable<string> originalFiles);
        Dictionary<IEnumerable<string>, IEnumerable<string>> SeparateFiles(IEnumerable<string[]> items);
    }
}