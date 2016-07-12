#region Copyright (c) 2016 Atif Aziz. All rights reserved.
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to
// deal in the Software without restriction, including without limitation the
// rights to use, copy, modify, merge, publish, distribute, sublicense, and/or
// sell copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS
// IN THE SOFTWARE.
//
#endregion

namespace Partials
{
    using System;
    using System.Text.RegularExpressions;

    static partial class Rgx
    {
        public static Func<string, bool> IsMatch(string pattern) => IsMatch(pattern, RegexOptions.None);
        public static Func<string, bool> IsMatch(string pattern, RegexOptions options) => s => Regex.IsMatch(s, pattern, options);
        public static Func<string, Match> Match(string pattern) => Match(pattern, RegexOptions.None);
        public static Func<string, Match> Match(string pattern, RegexOptions options) => s => Regex.Match(s, pattern, options);
        public static Func<string, MatchCollection> Matches(string pattern) => Matches(pattern, RegexOptions.None);
        public static Func<string, MatchCollection> Matches(string pattern, RegexOptions options) => s => Regex.Matches(s, pattern, options);
        public static Func<string, string> Replace(string pattern, string replacement) => Replace(pattern, replacement, RegexOptions.None);
        public static Func<string, string> Replace(string pattern, string replacement, RegexOptions options) => s => Regex.Replace(s, pattern, replacement, options);
        public static Func<string, string> Replace(string pattern, MatchEvaluator evaluator) => Replace(pattern, evaluator, RegexOptions.None);
        public static Func<string, string> Replace(string pattern, MatchEvaluator evaluator, RegexOptions options) => s => Regex.Replace(s, pattern, evaluator, options);
    }
}
