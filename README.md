[projectUri]: https://github.com/ateaseproject/atease
[projectGit]: https://github.com/ateaseproject/atease.git
[changeLog]: ./CHANGELOG.md

# @Ease
[![NuGet](https://img.shields.io/nuget/v/AtEase.svg)](https://www.nuget.org/packages/AtEase)
	@Ease is a set of extensions and helpers.

**Quick links**

[Change logs][changeLog] | [Project Repository][projectUri]


## Installation
Available for [.NET Standard 2.0+](https://docs.microsoft.com/en-gb/dotnet/standard/net-standard)

### NuGet
```
PM> Install-Package AtEase
```
## Features
 - Extensions for Collections, Enum, String and other types
 - Persian DateTime extension
 - OperationResult for returning an object that shows succeed or faild operation with data and errors.

### Collections

Determines whether a collection is null or has no elements.
```C#
collection.IsNullOrEmpty()
collection.IsNotNullOrEmpty()
```
Determines whether not any element of a sequence satisfies a condition.
```C#
collection.NotAny()
```
### Numbers
```C#
Convert nullable double to nullable decimal.
nullableDouble.ToNullableDecimal()
```
Indicates the value as int  is 0 or int.MinValue value.
```C#
collection.IsZeroOrMin()
```
Indicates the value is even.
```C#
collection.IsEven()
```
 Indicates the value is odd.
```C#
collection.IsOdd()
```
Create random long number.
```C#
collection.NextRandom()
```
### Numbers to Span
Return new TimeSpan object.
```C#
number.Milliseconds()
number.Seconds()
number.Minutes()
number.Hours()
number.Days()
number.Weeks()
```

