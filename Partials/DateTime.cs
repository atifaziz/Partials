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

    static partial class DateAdd
    {
        public static Func<TimeSpan, DateTime> To(DateTime dt)          => dt.Add;
        public static Func<int, DateTime>      WholeDaysTo(DateTime dt) => d => dt.AddDays(d);
        public static Func<double, DateTime>   DaysTo(DateTime dt)      => dt.AddDays;
        public static Func<int, DateTime>      MonthsTo(DateTime dt)    => dt.AddMonths;
        public static Func<int, DateTime>      Years(DateTime dt)       => dt.AddYears;
    }

    static partial class DateTimeKindSpec
    {
        public static Func<DateTime, DateTime> Unspecified = To(DateTimeKind.Unspecified);
        public static Func<DateTime, DateTime> Local       = To(DateTimeKind.Local);
        public static Func<DateTime, DateTime> Utc         = To(DateTimeKind.Utc);

        public static Func<DateTime, DateTime> To(DateTimeKind kind) => d => DateTime.SpecifyKind(d, kind);
    }

    static partial class DateTimeDayOfWeek
    {
        public static readonly Func<DateTime, bool> IsMonday    = Is(DayOfWeek.Monday   );
        public static readonly Func<DateTime, bool> IsTuesday   = Is(DayOfWeek.Tuesday  );
        public static readonly Func<DateTime, bool> IsWednesday = Is(DayOfWeek.Wednesday);
        public static readonly Func<DateTime, bool> IsThursday  = Is(DayOfWeek.Thursday );
        public static readonly Func<DateTime, bool> IsFriday    = Is(DayOfWeek.Friday   );
        public static readonly Func<DateTime, bool> IsSaturday  = Is(DayOfWeek.Saturday );
        public static readonly Func<DateTime, bool> IsSunday    = Is(DayOfWeek.Sunday   );

        public static Func<DateTime, bool> Is(DayOfWeek dow) => dt => dt.DayOfWeek == dow;
    }

    static partial class DateTimeField
    {
        public static readonly Func<DateTime, int> Year        = dt => dt.Year;
        public static readonly Func<DateTime, int> Month       = dt => dt.Month;
        public static readonly Func<DateTime, int> Day         = dt => dt.Day;
        public static readonly Func<DateTime, int> DayOfYear   = dt => dt.DayOfYear;
        public static readonly Func<DateTime, int> Hour        = dt => dt.Hour;
        public static readonly Func<DateTime, int> Minute      = dt => dt.Minute;
        public static readonly Func<DateTime, int> Second      = dt => dt.Second;
        public static readonly Func<DateTime, int> Millisecond = dt => dt.Millisecond;

        public static readonly Func<DateTime, DateTime> Date       = dt => dt.Date;
        public static readonly Func<DateTime, TimeSpan> TimeOfDay  = dt => dt.TimeOfDay;
        public static readonly Func<DateTime, DateTimeKind> Kind   = dt => dt.Kind;
        public static readonly Func<DateTime, DayOfWeek> DayOfWeek = dt => dt.DayOfWeek;
    }
}
