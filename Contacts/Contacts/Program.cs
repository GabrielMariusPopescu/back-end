using Contacts.Business;
using Contacts.Business.Contracts;
using Contacts.Business.Services;

namespace Contacts
{
    public static class Program
    {
        static Program()
        {
            PRESENTATION_LOGIC = new PresentationLogic();
            BUSINESS_LOGIC = new BusinessLogic(new FileProcessor());
        }

        public static void Main()
        {
            PRESENTATION_LOGIC.DisplayWelcomeMessage();
            BUSINESS_LOGIC.GetOriginalFiles();
            PRESENTATION_LOGIC.DisplayOriginalFiles(BUSINESS_LOGIC.OriginalFiles);
            BUSINESS_LOGIC.MergeFiles();

            PRESENTATION_LOGIC.ExitApplication();
        }


        //

        private static readonly PresentationLogic PRESENTATION_LOGIC;
        private static readonly IBusinessLogic BUSINESS_LOGIC;
    }
}