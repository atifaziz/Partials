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
    using System.Globalization;
    using F = System.Func<int, int>;

    static partial class Int
    {
        public static F Abs = x => Math.Abs(x);
        public static F Min(int x) => y => Math.Min(x, y);
        public static F Max(int x) => y => Math.Max(x, y);

        public static Func<string, int> Parse() => Parse(CultureInfo.InvariantCulture);
        public static Func<string, int> Parse(NumberStyles style) => Parse(style, CultureInfo.InvariantCulture);
        public static Func<string, int> Parse(IFormatProvider provider) => s => int.Parse(s, provider);
        public static Func<string, int> Parse(NumberStyles style, IFormatProvider provider) => s => int.Parse(s, style, provider);
    }
}
