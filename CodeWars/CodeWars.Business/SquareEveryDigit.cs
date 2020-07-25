using System.Linq;

namespace CodeWars.Business
{
	public class SquareEveryDigit
	{
		public int Calculate(int number)
		{
			var items = number.ToString().Select(digit => int.Parse(digit.ToString()));
			var square = items.Select(item => item * item).Aggregate("", (current, sum) => current + sum);

			return int.Parse(square);
		}

	}
}
