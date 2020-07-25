using System.Linq;

namespace CodeWars.UI
{
	public class Persist
	{
		public int Persistence(long number)
		{
			var result = MultiplyItem(number.ToString().ToCharArray());
			var count = 1;
			if (result.Length == 1)
			{
				return --count;
			}

			while (result.Length > 1)
			{
				count++;
				result = MultiplyItem(result);
			}

			return count;
		}

		//

		private char[] MultiplyItem(char[] items)
		{
			var result = items.Where(item => !item.Equals('0')).Aggregate<char, long>(1, (current, item) => current * int.Parse(item.ToString()));
			return result.ToString().ToCharArray();
		}
	}
}