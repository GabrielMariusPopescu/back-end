using System;

namespace Contacts.Business.Helpers
{
    public static class StringExtensions
    {
        public static string GetAfter(this string source, string after)
        {
            var position = source.LastIndexOf(after, StringComparison.Ordinal);
            var adjPos = position + after.Length;
            return source.Substring(adjPos);
        }
    }
}
