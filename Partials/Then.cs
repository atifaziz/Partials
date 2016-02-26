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

    namespace Then
    {
        static partial class Func
        {
            public static Func<T, TResult> Id<T, TResult>(this Func<T, TResult> f) => x => f(x);
            public static Func<T1, TResult> Then<T1, T2, TResult>(this Func<T1, T2> f, Func<T2, TResult> g) => x => g(f(x));
            public static Func<T1, TResult> Then<T1, T2, T3, TResult>(this Func<T1, T2> f, Func<T2, T3> g, Func<T3, TResult> h) => f.Then(g).Then(h);
        }
    }
}