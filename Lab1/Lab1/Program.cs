using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab1
{
    public static class Program
    {
        public static void Main()
        {
            int[] vector = { };
            int dimension;
            var sum = 0;
            var largestElement = 0;
            var largestElementIndex = 0;
            var smallestElement = 0;
            var dict = new Dictionary<int, int>();

            Console.Write("Introduceti dimensiune vector: ");
            var number = Console.ReadLine();

            var isANumber = int.TryParse(number, out dimension);
            if (isANumber)
            {
                vector = new int[dimension];
            }

            Console.Write("Introduceti elementele vectorului: ");
            var elements = Console.ReadLine();
            var items = elements?.Split(' ');

            for (var i = 0; i < items.Length; i++)
            {
                var item = items[i];
                var tryParse = int.TryParse(item, out var el);
                if (tryParse)
                {
                    vector[i] = el;
                    sum += el;
                }

                if (vector[i] > largestElement)
                {
                    largestElement = vector[i];
                    largestElementIndex = i;
                }
            }

            for (var i = 0; i < vector.Length; i++)
            {
                if (vector[i] <= smallestElement)
                {
                    smallestElement = vector[i];
                    dict.Add(i, smallestElement);
                }
            }

            Console.WriteLine();
            for (var i = 0; i < vector.Length; i++)
            {
                Console.Write("Vector[" + i + "]: " + vector[i] + ",");
            }

            Console.WriteLine();
            Console.WriteLine("Suma elementelor vectorului:" + sum);
            Console.WriteLine("Cel mai mare element al vectorului este : " + largestElement + " si indicele acetuia este: " + largestElementIndex);
            Console.WriteLine("Cele mai mici elemente ale vectorului sunt: " + string.Join(",", dict.Values.ToList()) + " si indicele acestora sun: " + string.Join(",", dict.Keys.ToList()));
        }
    }
}
