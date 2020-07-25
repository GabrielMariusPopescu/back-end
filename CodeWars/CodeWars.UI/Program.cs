using System;
using System.Collections.Generic;
using System.Threading;
using CodeWars.Business;

namespace CodeWars.UI
{
	public static class Program
	{
		private static void Main()
		{
			Console.WriteLine("Welcome to Code Wars Project!");
			Console.WriteLine("=============================");
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
						var problem01 = new SquareEveryDigit();
						var square = problem01.Calculate(9119);
						Console.WriteLine($"Square every digit for: {9119} is {square}");
						break;
					case "2":
						var problem02 = new WhichAreIn();
						var inner = new[] {"arp", "live", "strong"};
						var outer = new[] {"lively", "alive", "harp", "sharp", "armstrong"};
						var values = problem02.Find(inner, outer);
						Console.WriteLine(string.Join(" ", values));
						break;
					case "3":
						var problem03 = new IQ();
						var test = problem03.Test("8 8 9 6 6 6 5 1 1 4 8 8 2 9 2 1 8 7 2 1 8 8 8 2 0 3 0 4 8 2 9 0 1 0 0 2 4 4 6");
						Console.WriteLine($"The weird item is at {test} position");
						break;
					case "4":
						var problem04 = new ExesAndOhs();
						var areEven1 = problem04.XO("xo");
						var areEven2 = problem04.XO("xxOo");
						var areEven3 = problem04.XO("xxxm");
						var areEven4 = problem04.XO("Oo");
						var areEven5 = problem04.XO("ooom");
						Console.WriteLine($"AreEven 1 are Even? {areEven1}");
						Console.WriteLine($"AreEven 2 are Even? {areEven2}");
						Console.WriteLine($"AreEven 3 are Even? {areEven3}");
						Console.WriteLine($"AreEven 4 are Even? {areEven4}");
						Console.WriteLine($"AreEven 5 are Even? {areEven5}");
						break;
					case "5":
						var problem05 = new Persist();
						var count1 = problem05.Persistence(39);
						var count2 = problem05.Persistence(4);
						var count3 = problem05.Persistence(25);
						var count4 = problem05.Persistence(999);
						var count5 = problem05.Persistence(945453465745653499);
						var count6 = problem05.Persistence(100);
						Console.WriteLine($"Count1 iterate {count1} times;");
						Console.WriteLine($"Count2 iterate {count2} times;");
						Console.WriteLine($"Count3 iterate {count3} times;");
						Console.WriteLine($"Count4 iterate {count4} times;");
						Console.WriteLine($"Count4 iterate {count5} times;");
						Console.WriteLine($"Count3 iterate {count6} times;");
						break;
				}
			}

			Console.ReadLine();
		}

		//

		private static Dictionary<int, string> Problems => new Dictionary<int, string>
		{
			{1, "Square Every Digit"},
			{2, "Which are in"},
			{3, "IQ Test"},
			{4, "Exes and Ohs"},
			{5, "Persist"}
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
