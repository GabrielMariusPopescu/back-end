using Euler.Problem01;
using Euler.Problem02;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Euler.UI
{
    public static class Program
    {
        private static void Main()
        {
            Console.WriteLine("Welcome to Euler Project!");
            Console.WriteLine("=========================");
            Console.WriteLine();
            foreach (var problem in Problems)
            {
                Console.WriteLine($"{problem.Key} - {problem.Value}");
            }

            Console.Write("Choose from the following problems: ");
            Console.WriteLine();
            var key = Console.ReadLine();

            if (!KeyIsValid(key))
            {
                Console.WriteLine("Unknown problem!");
                Console.WriteLine("Bye...");
                Thread.Sleep(1000);
            }
            else
            {
                switch (key)
                {
                    case "1":
                        var problem01 = new MultiplesOfThreeAndFive();
                        var tenMultiples = problem01.SumTenMultiples();
                        Console.Write($"Sum of multiples of 3 and 5 for natural numbers below 10\t= {tenMultiples.Sum()}");
                        var thousandMultiples = problem01.SumThousandMultiples();
                        Console.Write($"Sum of multiples of 3 and 5 for natural numbers below 1000\t= {thousandMultiples.Sum()}");
                        break;
                    case "2":
                        var problem02 = new EvenFibonacciNumbers();
                        var tenFibonacci = problem02.GetFibonacciNumbers(10);
                        Console.Write("Fibonacci sequence for first 10 numbers is : ");
                        tenFibonacci.ForEach(it => Console.Write($"{it} "));
                        Console.WriteLine();
                        var thirtyFourFibonacci = problem02.GetFibonacciNumbers(34);
                        Console.Write("Fibonacci sequence for first 1000 numbers is : ");
                        thirtyFourFibonacci.ForEach(it => Console.Write($"{it} "));
                        Console.WriteLine();
                        var sum = problem02.CalculateEvenElements(thirtyFourFibonacci);
                        Console.WriteLine($"Sum of even-valued terms that do not exceed four million is: {sum}");
                        break;
                }

                Console.ReadLine();
            }

        }

        //

        private static Dictionary<int, string> Problems => new Dictionary<int, string>
        {
            {1, "Multiples of 3 and 5"},
            {2, "Even Fibonacci Number"}
        };

        private static bool KeyIsValid(string key)
        {
            return !string.IsNullOrEmpty(key) ||
                   !int.TryParse(key, out var value) ||
                   !(value > Problems.Keys.Count ||
                     value < 1);
        }
    }
}