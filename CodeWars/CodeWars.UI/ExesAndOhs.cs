using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace CodeWars.UI
{
	[SuppressMessage("ReSharper", "InconsistentNaming")]
	public class ExesAndOhs
	{
		public bool XO(string source)
		{
			var items = source.ToCharArray();
			var oCount = os.Select(o => items.Count(it => it.Equals(o)));
			var xCount = xs.Select(x => items.Count(it => it.Equals(x)));

			return oCount.Sum() == xCount.Sum();
		}

		//
		
		private readonly char[] os = { 'o', 'O' };
		private readonly char[] xs = {'x', 'X'};
	}
}