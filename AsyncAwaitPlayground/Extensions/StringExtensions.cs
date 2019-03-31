using System;

namespace Playground.Extensions
{
    public static class StringExtensions
    {
        public static string Append(this string source, string append)
        {
            return source + append;
        }

        public static string AppendLine(this string source, string append)
        {
            return source.Append(append + Environment.NewLine);
        }
    }
}
