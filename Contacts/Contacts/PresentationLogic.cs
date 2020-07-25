using System;
using System.Collections.Generic;
using System.Linq;
using Contacts.Business.Contracts;
using Contacts.Business.Helpers;
using Contacts.Business.Services;

namespace Contacts
{
    public class PresentationLogic
    {
        public PresentationLogic()
        {
            application = new Application();
        }
        public void DisplayWelcomeMessage()
        {
            Console.WriteLine(application.SetDecoration());
            Console.WriteLine(application.GetName());
            Console.WriteLine(application.SetDecoration());
            Console.WriteLine(Environment.NewLine);
        }

        //

        private readonly IApplication application;

        public void ExitApplication()
        {
            Console.Write("Press 'Enter' to exit the application...");
            Console.ReadLine();
        }

        public void DisplayOriginalFiles(IEnumerable<string> files)
        {
            Console.WriteLine(application.SetDecoration());
            var names = files.Select(file => file.GetAfter("\\")).ToList();
            names.ForEach(Console.WriteLine);
            Console.WriteLine(application.SetDecoration());
        }
    }
}