using System;

namespace SoftwareDevelopmentSkillsAssessments
{
    public static class Program
    {
        public static void Main()
        {
            var number = ExampleOne("123456");
            var number2 = ExampleOneRefactored("123456");
            Console.WriteLine(number);
            Console.WriteLine(number2);

            Console.ReadLine();
        }

        //

        private static string ExampleOne(string employeeNumber)
        {
            if (employeeNumber.Length < 6)
            {
                if (employeeNumber.Length == 1)
                    employeeNumber = "00000" + employeeNumber;
                else if (employeeNumber.Length == 2)
                    employeeNumber = "0000" + employeeNumber;
                else if (employeeNumber.Length == 3)
                    employeeNumber = "000" + employeeNumber;
                else if (employeeNumber.Length == 4)
                    employeeNumber = "00" + employeeNumber;
                else if (employeeNumber.Length == 5)
                    employeeNumber = "0" + employeeNumber;
            }

            return employeeNumber;
        }

        private static string ExampleOneRefactored(string employeeNumber)
        {
            var length = employeeNumber.Length;
            if (length >= 6)
                return employeeNumber;

            var zeros = new string('0', 6 - length);
            return $"{zeros}{employeeNumber}";
        }
    }
}
