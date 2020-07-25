using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace CodeWars.Business
{
	[SuppressMessage("ReSharper", "InconsistentNaming")]
	public class IQ
	{
		public int Test(string numbers)
		{
			var items = numbers.Split(' ');

			var evenOrOdd = EvenOrOdd(items);

			for (var i = 0; i < items.Count(); i++)
			{
				if (evenOrOdd)
				{
					if (int.Parse(items[i]) % 2 == 0)
					{
						continue;
					}

					return i + 1;
				}

				if (int.Parse(items[i]) % 2 != 0)
				{
					continue;
				}

				return i + 1;
			}

			return 0;
		}

		//

		private bool EvenOrOdd(string[] items)
		{
			var even = new List<int>();
			var odd = new List<int>();
			var count = 0;
			foreach (var item in items)
			{
				count++;
				if (int.Parse(item) % 2 == 0)
					even.Add(count);
				if (int.Parse(item) % 2 != 0)
					odd.Add(count);
			}

			return even.Count >= odd.Count;
		}
	}
}
