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
    using System.Text;

    static partial class Str
    {
        public static readonly Func<string, int> Length = s => s.Length;

        public static Func<string, bool> Equals(string value) => value.Equals;
        public static Func<string, bool> Equals(string value, StringComparison comparisonType) => s => value.Equals(s, comparisonType);

        public static Func<string, char[]> ToCharArray() => s => s.ToCharArray();
        public static Func<string, char[]> ToCharArray(int startIndex, int length) => s => s.ToCharArray(startIndex, length);

        public new static readonly Func<string, int> GetHashCode = s => s.GetHashCode();

        public static Func<string, string[]> Split(params char[] separator) => s => s.Split(separator);
        public static Func<string, string[]> Split(char[] separator, int count) => s => s.Split(separator, count);
        public static Func<string, string[]> Split(char[] separator, StringSplitOptions options) => s => s.Split(separator, options);
        public static Func<string, string[]> Split(char[] separator, int count, StringSplitOptions options) => s => s.Split(separator, count, options);
        public static Func<string, string[]> Split(string[] separator, StringSplitOptions options) => s => s.Split(separator, options);
        public static Func<string, string[]> Split(string[] separator, int count, StringSplitOptions options) => s => s.Split(separator, count, options);

        public static Func<string, string> Substring(int startIndex) => s => s.Substring(startIndex);
        public static Func<string, string> Substring(int startIndex, int length) => s => s.Substring(startIndex, length);

        public static Func<string, string> Trim() => s => s.Trim();
        public static Func<string, string> Trim(params char[] trimChars) => s => s.Trim(trimChars);
        public static Func<string, string> TrimStart(params char[] trimChars) => s => s.TrimStart(trimChars);
        public static Func<string, string> TrimEnd(params char[] trimChars) => s => s.TrimEnd(trimChars);

        public static Func<string, int> CompareTo(string strB) => s => s.CompareTo(strB);
        public static Func<string, bool> Contains(string value) => s => s.Contains(value);

        public static Func<string, int> IndexOf(char value) => s => s.IndexOf(value);
        public static Func<string, int> IndexOf(char value, int startIndex) => s => s.IndexOf(value, startIndex);
        public static Func<string, int> IndexOf(char value, int startIndex, int count) => s => s.IndexOf(value, startIndex, count);
        public static Func<string, int> IndexOf(string value) => s => s.IndexOf(value);
        public static Func<string, int> IndexOf(string value, int startIndex) => s => s.IndexOf(value, startIndex);
        public static Func<string, int> IndexOf(string value, int startIndex, int count) => s => s.IndexOf(value, startIndex, count);
        public static Func<string, int> IndexOf(string value, StringComparison comparisonType) => s => s.IndexOf(value, comparisonType);
        public static Func<string, int> IndexOf(string value, int startIndex, StringComparison comparisonType) => s => s.IndexOf(value, startIndex, comparisonType);
        public static Func<string, int> IndexOf(string value, int startIndex, int count, StringComparison comparisonType) => s => s.IndexOf(value, startIndex, count, comparisonType);
        public static Func<string, int> IndexOfAny(char[] anyOf) => s => s.IndexOfAny(anyOf);
        public static Func<string, int> IndexOfAny(char[] anyOf, int startIndex) => s => s.IndexOfAny(anyOf, startIndex);
        public static Func<string, int> IndexOfAny(char[] anyOf, int startIndex, int count) => s => s.IndexOfAny(anyOf, startIndex, count);

        public static Func<string, int> LastIndexOf(char value) => s => s.LastIndexOf(value);
        public static Func<string, int> LastIndexOf(char value, int startIndex) => s => s.LastIndexOf(value, startIndex);
        public static Func<string, int> LastIndexOf(char value, int startIndex, int count) => s => s.LastIndexOf(value, startIndex, count);
        public static Func<string, int> LastIndexOf(string value) => s => s.LastIndexOf(value);
        public static Func<string, int> LastIndexOf(string value, int startIndex) => s => s.LastIndexOf(value, startIndex);
        public static Func<string, int> LastIndexOf(string value, int startIndex, int count) => s => s.LastIndexOf(value, startIndex, count);
        public static Func<string, int> LastIndexOf(string value, StringComparison comparisonType) => s => s.LastIndexOf(value, comparisonType);
        public static Func<string, int> LastIndexOf(string value, int startIndex, StringComparison comparisonType) => s => s.LastIndexOf(value, startIndex, comparisonType);
        public static Func<string, int> LastIndexOf(string value, int startIndex, int count, StringComparison comparisonType) => s => s.LastIndexOf(value, startIndex, count, comparisonType);
        public static Func<string, int> LastIndexOfAny(char[] anyOf) => s => s.LastIndexOfAny(anyOf);
        public static Func<string, int> LastIndexOfAny(char[] anyOf, int startIndex) => s => s.LastIndexOfAny(anyOf, startIndex);
        public static Func<string, int> LastIndexOfAny(char[] anyOf, int startIndex, int count) => s => s.LastIndexOfAny(anyOf, startIndex, count);

        public static Func<string, string> PadLeft(int totalWidth) => s => s.PadLeft(totalWidth);
        public static Func<string, string> PadLeft(int totalWidth, char paddingChar) => s => s.PadLeft(totalWidth, paddingChar);
        public static Func<string, string> PadRight(int totalWidth) => s => s.PadRight(totalWidth);
        public static Func<string, string> PadRight(int totalWidth, char paddingChar) => s => s.PadRight(totalWidth, paddingChar);

        public static Func<string, bool> StartsWith(string value) => s => s.StartsWith(value);
        public static Func<string, bool> StartsWith(string value, StringComparison comparisonType) => s => s.StartsWith(value, comparisonType);
        public static Func<string, bool> EndsWith(string value) => s => s.EndsWith(value);
        public static Func<string, bool> EndsWith(string value, StringComparison comparisonType) => s => s.EndsWith(value, comparisonType);

        public static Func<string, string> ToLower() => s => s.ToLower();
        public static Func<string, string> ToLowerInvariant() => s => s.ToLowerInvariant();
        public static Func<string, string> ToUpper() => s => s.ToUpper();
        public static Func<string, string> ToUpperInvariant() => s => s.ToUpperInvariant();

        public static Func<string, string> Insert(int startIndex, string value) => s => s.Insert(startIndex, value);
        public static Func<string, string> Replace(char oldChar, char newChar) => s => s.Replace(oldChar, newChar);
        public static Func<string, string> Replace(string oldValue, string newValue) => s => s.Replace(oldValue, newValue);
        public static Func<string, string> Remove(int startIndex, int count) => s => s.Remove(startIndex, count);
        public static Func<string, string> Remove(int startIndex) => s => s.Remove(startIndex);

        public static Func<string, char> CharAt(int index) => s => s[index];
    }

    #if !NETCORE

    partial class Str
    {
        public static Func<string, bool> IsNormalized() => s => s.IsNormalized();
        public static Func<string, bool> IsNormalized(NormalizationForm form) => s => s.IsNormalized(form);

        public static Func<string, string> Normalize() => s => s.Normalize();
        public static Func<string, string> Normalize(NormalizationForm form) => s => s.Normalize(form);

        public static Func<string, bool> StartsWith(string value, bool ignoreCase, CultureInfo culture) => s => s.StartsWith(value, ignoreCase, culture);
        public static Func<string, bool> EndsWith(string value, bool ignoreCase, CultureInfo culture) => s => s.EndsWith(value, ignoreCase, culture);

        public static Func<string, string> ToLower(CultureInfo culture) => s => s.ToLower(culture);
        public static Func<string, string> ToUpper(CultureInfo culture) => s => s.ToUpper(culture);
    }

    #endif
}
