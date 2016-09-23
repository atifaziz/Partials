namespace Partials
{
    using System;

    static partial class Arr
    {
        public static Func<string[], string> JoinStrings(string separator) => ss => string.Join(separator, ss);
    }
}