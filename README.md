# Partials

[![Build Status][build-badge]][builds]
[![NuGet][nuget-badge]][nuget-pkg]

Partials is a library partially applied .NET utility and primitive functions
that helps reduce the need for writing out simple lambdas. It is especially
useful when authoring [LINQ to Objects][linq2objs] queries.

## Motivation

Suppose the following example that rounds up 5 double-precision numbers up to
second their fractional digit:

```c#
var nums = new[]
{
    0.32313,
    0.55369,
    0.95692,
    0.11786,
    0.54233,
};

var result = string.Join(", ", nums.Select(x => Math.Round(x, 2)));
Console.WriteLine(result); // 0.32, 0.55, 0.96, 0.12, 0.54
```

Using Partials, the `Select` can be written without a lambda:

```c#
var result = string.Join(", ", nums.Select(Float64.Round(2)));
```

Below is another example where the double-precision floats are parsed from
strings and then rounded up:

```c#
var nums = new[]
{
    "0.32313",
    "0.55369",
    "0.95692",
    "0.11786",
    "0.54233",
};

var result = string.Join(", ", nums.Select(s => Math.Round(double.Parse(s, CultureInfo.InvariantCulture), 2)));
Console.WriteLine(result); // 0.32, 0.55, 0.96, 0.12, 0.54
```

Using Partials, the same can be expressed more simply:


```c#
var result = string.Join(", ", nums.Select(Float64.Parse())
                                   .Select(Float64.Round(2)));
```

Partials also gives you `Then` for composing functions together, which can
also be used to turn the chained projections, like the two `Select` operations)
in the example above, into one:

```c#
var result = string.Join(", ", nums.Select(Float64.Parse()
                                                  .Then(Float64.Round(2))));
```

The next example shows more composition in action, where each string is parsed
into a number, multiplied by 5, square-rooted and capped to 1.5 before being
rounded up:

```c#
var result = string.Join(",", nums.Select(Float64.Parse()
                                                 .Then(x => x * 5)
                                                 .Then(Float64.Sqrt)
                                                 .Then(Float64.Min(1.5))
                                                 .Then(Float64.Round(2))));
```

You can also negate any predicate function by [statically importing][using]
(`using static`) the `FuncModule` and using `Not`:

```c#
var strs = new[] { "foo", "bar", "baz", "quux" };

var r1 = string.Join(", ", strs.Where(Str.Contains("a")));
Console.WriteLine(r1);  // bar, baz

var r2 = string.Join(", ", strs.Where(Not(Str.Contains("a"))));
Console.WriteLine(r2);  // foo, quux
```


[build-badge]: https://img.shields.io/appveyor/ci/raboof/partials.svg
[nuget-badge]: https://img.shields.io/nuget/v/Partials.svg
[nuget-pkg]: https://www.nuget.org/packages/Partials
[builds]: https://ci.appveyor.com/project/raboof/partials
[linq2objs]: https://msdn.microsoft.com/en-us/library/bb397919.aspx
[using]: https://msdn.microsoft.com/en-us/library/sf0df423.aspx