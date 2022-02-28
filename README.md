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
 - Provide DSL for C# methods

### Convert class to Http query string 
```C#
testClass.ToQueryString();
```
### DateTime 
```C#
dateTime.ToPersianDateTime(format);  // تبدیل به تاریخ شمسی
```
### Sequential GUID
```C#
Guid.NewGuid().AsSequentialGuid();
GuidGeneratorExtensions.NewSequentialGuid();
```
### RegularExpression
```C#
string.IsValidShamsiYear(); // تاریخ شمسی است
string.IsValidTime();
string.IsValidEmail();
```
### String
```C#
string.IsWord();
string.ToSpacingSentence();
string.ToSentence();
string.ToSnakeCase();
string.FixPersianKeyboardLayou(); // فیکس حروفی عربی و فارسی
string.ToPersianNumber();  // تبدیل اعداد به اعداد فارسی
string.IsNull();
string.IsNullOrEmptyOrWhiteSpace();
```
### Enum
```C#
@enum.ToInt();  // enum to int
value.AsEnum<TestEnum>(); // int to enum
@enum.GetDisplayName();
@enum.GetDescription();
EnumToList<Enum>; // get list of values
```
### Collections
```C#
collection.IsNullOrEmpty()
collection.IsNotNullOrEmpty()
collection.NotAny()
```
### Numbers
```C#
nullableDouble.ToNullableDecimal()
collection.IsZeroOrMin()
collection.IsEven()
collection.IsOdd()
collection.NextRandom()
```
### Numbers to Span
```C#
number.Milliseconds()
number.Seconds()
number.Minutes()
number.Hours()
number.Days()
number.Weeks()
```
### Operation System
```C#
IsWindows()
IsMacOs()
IsLinux()

string.RunAsCmd(workingDirectory)
string.RunAsWindowsCmd(workingDirectory)
string.RunAsBashCmd(workingDirectory)
```
### Types
```C#
object.GetPropertyValue(propertyName)
object.GetFieldValue(fieldName)
object.HasAttribute<CustomAttribute>()
object.SingleAttributeValue<TAttribute>(propertyName,attributeName)
```
