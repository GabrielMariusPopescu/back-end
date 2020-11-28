using HackerRank.Business.Contracts;
using HackerRank.Business.Implementation;
using System;

namespace HackerRank
{
    public static class Program
    {
        static Program()
        {
            presentationLogic = new PresentationLogic();
            businessLogic = new BusinessLogic();
        }

        private static readonly PresentationLogic presentationLogic;
        private static readonly IBusinessLogic businessLogic;

        //

        private static void Main()
        {
            var assembly = presentationLogic.GetAssembly();
            presentationLogic.Display('=', assembly, "Welcome to");
            presentationLogic.ListChallenges(businessLogic.Challenges);
            var option = presentationLogic.SelectChallenge();
            if (option == 0)
                presentationLogic.Display('=', assembly, "Thank you for using");

            var tuple = businessLogic.Run(option);
            presentationLogic.Display(tuple);

            presentationLogic.Display('=', assembly, "Thank you for using");
            Environment.Exit(0);
        }
    }
}
