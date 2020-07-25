using System;

namespace Feeder.UI
{
    public static class Program
    {
        private static void Main()
        {
            Welcome();
            WORKER.DoWork();
            Goodbye();
            Console.ReadLine();
        }

        //

        private static readonly Worker WORKER = new Worker();
        private static void Welcome()
        {
            var currentProject = AppDomain.CurrentDomain.FriendlyName;

            Console.WriteLine("==================");
            Console.WriteLine($"= {currentProject.Substring(0, currentProject.IndexOf('.'))} Program =");
            Console.WriteLine("==================");
            Console.WriteLine();
        }

        private static void Goodbye()
        {
            Console.Clear();
            Console.WriteLine("Thank you for using this program!");
            Console.WriteLine("Press 'Enter' to exit...");
        }

    }
}
