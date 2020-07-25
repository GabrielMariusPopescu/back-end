using System.Collections.Generic;
using System.Linq;

namespace Euler.Problem02
{
    public class EvenFibonacciNumbers
    {
        public List<int> GetFibonacciNumbers(int number)
        {
            var fibonacci = new List<int>();
            for (var i = 0; i < number; i++)
            {
                fibonacci.Add(GetFibonacciSequence(i));
            }

            return fibonacci;
        }

        public int CalculateEvenElements(List<int> items)
        {
            return items.Where(item => item % 2 == 0).Sum();
        }

        //

        private int GetFibonacciSequence(int number)
        {
            var current = 0;
            var next = 1;
            for (var i = 0; i < number; i++)
            {
                var temp = current;
                current = next;
                next = temp + current;
            }

            return current;
        }
    }
}
