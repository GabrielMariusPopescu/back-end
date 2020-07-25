using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace CodeWars.Business
{
	public class WhichAreIn
	{
		public string[] Find(string[] array1, string[] array2)
		{
			var result = new List<string>();
			foreach (var innerItem in array2.SelectMany(outerItem => array1, (outerItem, innerItem) => new {outerItem, innerItem})
			                               .Select(it => new {it, regex = new Regex(it.innerItem, RegexOptions.Compiled)})
			                               .Where(it => it.regex.IsMatch(it.it.outerItem))
			                               .Where(it => !result.Contains(it.it.innerItem))
			                               .Select(it => it.it.innerItem)) 
				result.Add(innerItem);

			return result.OrderBy(it=>it).ToArray();
		}
	}
}
