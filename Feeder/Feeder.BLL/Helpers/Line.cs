using System;

namespace Feeder.BLL.Helpers
{
    public static class Line
    {
        public static string GetBefore(this string source, string before)
        {
            var position = source.IndexOf(before, StringComparison.Ordinal);
            return source.Substring(0, position);
        }
    }
}