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
    using F = System.Func<float, float>;

    static partial class Float32
    {
        public static F Abs = x => Math.Abs(x);
        public static F Min(float x) => y => Math.Min(x, y);
        public static F Max(float x) => y => Math.Max(x, y);
        public static F Floor() => x => (float) Math.Floor(x);
        public static F Ceiling() => x => (float) Math.Ceiling(x);
        public static F Pow(float y) => x => (float) Math.Pow(x, y);
        public static F Round(int decimals) => x => (float) Math.Round(x, decimals);
        public static F Round(int decimals, MidpointRounding mode) => x => (float) Math.Round(x, decimals, mode);
        public static Func<int, F> Round(MidpointRounding mode) => decimals => x => (float) Math.Round(x, decimals, mode);
        public static F Sqrt = x => (float)Math.Sqrt(x);

        public static Func<string, float> Parse() => x => float.Parse(x, CultureInfo.InvariantCulture);
        public static Func<string, float> Parse(NumberStyles style) => x => float.Parse(x, style, CultureInfo.InvariantCulture);
        public static Func<float, string> Format(string format) => x => x.ToString(format, CultureInfo.InvariantCulture);
    }
}

namespace Partials
{
    using System;
    using System.Globalization;
    using F = System.Func<double, double>;

    static partial class Float64
    {
        public static F Abs = x => Math.Abs(x);
        public static F Min(double x) => y => Math.Min(x, y);
        public static F Max(double x) => y => Math.Max(x, y);
        public static F Floor() => Math.Floor;
        public static F Ceiling() => Math.Ceiling;
        public static F Pow(double y) => x => Math.Pow(x, y);
        public static F Round(int decimals) => x => Math.Round(x, decimals);
        public static F Round(int decimals, MidpointRounding mode) => x => Math.Round(x, decimals, mode);
        public static Func<int, F> Round(MidpointRounding mode) => decimals => x => Math.Round(x, decimals, mode);
        public static F Sqrt = x => Math.Sqrt(x);

        public static Func<string, double> Parse() => x => double.Parse(x, CultureInfo.InvariantCulture);
        public static Func<string, double> Parse(NumberStyles style) => x => double.Parse(x, style, CultureInfo.InvariantCulture);
        public static Func<double, string> Format(string format) => x => x.ToString(format, CultureInfo.InvariantCulture);
    }
}
