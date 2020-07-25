using System.Collections.Generic;
using System.Linq;

namespace Euler.Problem01
{
    public class MultiplesOfThreeAndFive
    {
        public List<int> SumTenMultiples()
        {
            return SumMultiples(firstTenNaturalNumbers);
        }

        public List<int> SumThousandMultiples()
        {
            return SumMultiples(firstThousandNaturalNumbers);
        }

        //

        private readonly List<int> firstTenNaturalNumbers = Enumerable.Range(1, 9).ToList();
        private readonly List<int> firstThousandNaturalNumbers = Enumerable.Range(1, 999).ToList();

        private List<int> SumMultiples(IEnumerable<int> range)
        {
            var sum = new List<int>();
            foreach (var number in range)
            {
                if (number % 3 == 0 &&
                    number % 5 == 0)
                    sum.Add(number);

                else if (number % 3 == 0)
                    sum.Add(number);

                else if (number % 5 == 0)
                    sum.Add(number);
            }

            return sum;
        }
    }
}
