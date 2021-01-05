using System;

namespace SoftwareDevelopmentSkillsAssessments
{
    public static class Program
    {
        static Program()
        {
            employee = new Employee();
            coin = new Coin();
        }


        public static void Main()
        {
            var employeeNumberOne = employee.ExampleOne("123456");
            var employeeNumberTwo = employee.ExampleOneRefactored("123456");
            Console.WriteLine(employeeNumberOne);
            Console.WriteLine(employeeNumberTwo);

            Console.Write("Enter the amount you want to change: ");
            var origAmount = Convert.ToDouble(Console.ReadLine());
            var toChange = origAmount;
            var coins = new int[4];
            coin.Change(origAmount, coins);
            Console.WriteLine("The best way to change " + toChange + " cents is: ");
            coin.Show(coins);

        }

        //

        private static readonly Employee employee;
        private static readonly Coin coin;
    }
}
