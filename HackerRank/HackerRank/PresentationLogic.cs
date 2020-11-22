﻿using ExtensionMethods.String;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace HackerRank
{
    public class PresentationLogic
    {
        public string GetAssembly()
        {
            var assembly = Assembly.GetExecutingAssembly();
            return assembly.FullName.GetBeforeFirst(",");
        }

        public void Display(char decorator, string assembly, string message)
        {
            var item = new string(decorator, message.Length + assembly.Length + 5);
            Console.WriteLine(item);
            Console.WriteLine($"{decorator} {message} {assembly} {decorator}");
            Console.WriteLine(item);
            Console.WriteLine();
        }

        public void Display(Tuple<string, object, object> tuple)
        {
            var (item1, item2, item3) = tuple;
            Display('-', item1, "Execution of");
            var initialList = (List<int>)item2;
            var resultList = (List<int>)item3;
            initialList?.ForEach(Console.Write);
            Console.WriteLine();
            resultList?.ForEach(Console.Write);
            Console.WriteLine();
        }

        public void ListChallenges(IEnumerable<string> challenges)
        {
            var index = 0;
            foreach (var challenge in challenges)
            {
                Console.WriteLine($"{index}: {challenge}");
                index++;
            }
        }

        public int SelectChallenge()
        {
            var value = Console.ReadLine();
            return int.TryParse(value, out var option) ? option : 0;
        }
    }
}