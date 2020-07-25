using System.Collections.Generic;
using Contacts.Business.Contracts;

namespace Contacts.Business
{
    public class BusinessLogic : IBusinessLogic
    {
        public BusinessLogic(IFileProcessor fileProcessor)
        {
            this.fileProcessor = fileProcessor;
        }

        public IEnumerable<string> OriginalFiles { get; set; }

        public void GetOriginalFiles()
        {
            var directories = fileProcessor.GetOneDriveDirectories();
            OriginalFiles = fileProcessor.GetFiles(directories);
        }

        public void MergeFiles()
        {
            var lines = fileProcessor.Read(OriginalFiles);
            var dict = fileProcessor.SeparateFiles(lines);
        }

        //

        private readonly IFileProcessor fileProcessor;
    }
}
