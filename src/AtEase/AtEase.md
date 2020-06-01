<a name='assembly'></a>
# AtEase

## Contents

- [ArrayExtensions](#T-AtEase-Extensions-ArrayExtensions 'AtEase.Extensions.ArrayExtensions')
  - [IsNullOrEmpty(items)](#M-AtEase-Extensions-ArrayExtensions-IsNullOrEmpty-System-Array- 'AtEase.Extensions.ArrayExtensions.IsNullOrEmpty(System.Array)')
- [DisplayNameResource](#T-AtEase-Resources-DisplayNameResource 'AtEase.Resources.DisplayNameResource')
  - [Amount](#P-AtEase-Resources-DisplayNameResource-Amount 'AtEase.Resources.DisplayNameResource.Amount')
  - [Available](#P-AtEase-Resources-DisplayNameResource-Available 'AtEase.Resources.DisplayNameResource.Available')
  - [Chosen](#P-AtEase-Resources-DisplayNameResource-Chosen 'AtEase.Resources.DisplayNameResource.Chosen')
  - [Culture](#P-AtEase-Resources-DisplayNameResource-Culture 'AtEase.Resources.DisplayNameResource.Culture')
  - [Debug](#P-AtEase-Resources-DisplayNameResource-Debug 'AtEase.Resources.DisplayNameResource.Debug')
  - [EnumValue](#P-AtEase-Resources-DisplayNameResource-EnumValue 'AtEase.Resources.DisplayNameResource.EnumValue')
  - [Error](#P-AtEase-Resources-DisplayNameResource-Error 'AtEase.Resources.DisplayNameResource.Error')
  - [Fatal](#P-AtEase-Resources-DisplayNameResource-Fatal 'AtEase.Resources.DisplayNameResource.Fatal')
  - [Height](#P-AtEase-Resources-DisplayNameResource-Height 'AtEase.Resources.DisplayNameResource.Height')
  - [Image](#P-AtEase-Resources-DisplayNameResource-Image 'AtEase.Resources.DisplayNameResource.Image')
  - [Information](#P-AtEase-Resources-DisplayNameResource-Information 'AtEase.Resources.DisplayNameResource.Information')
  - [None](#P-AtEase-Resources-DisplayNameResource-None 'AtEase.Resources.DisplayNameResource.None')
  - [PersianMonthAban](#P-AtEase-Resources-DisplayNameResource-PersianMonthAban 'AtEase.Resources.DisplayNameResource.PersianMonthAban')
  - [PersianMonthAzar](#P-AtEase-Resources-DisplayNameResource-PersianMonthAzar 'AtEase.Resources.DisplayNameResource.PersianMonthAzar')
  - [PersianMonthBahman](#P-AtEase-Resources-DisplayNameResource-PersianMonthBahman 'AtEase.Resources.DisplayNameResource.PersianMonthBahman')
  - [PersianMonthDey](#P-AtEase-Resources-DisplayNameResource-PersianMonthDey 'AtEase.Resources.DisplayNameResource.PersianMonthDey')
  - [PersianMonthEsfand](#P-AtEase-Resources-DisplayNameResource-PersianMonthEsfand 'AtEase.Resources.DisplayNameResource.PersianMonthEsfand')
  - [PersianMonthFarvardin](#P-AtEase-Resources-DisplayNameResource-PersianMonthFarvardin 'AtEase.Resources.DisplayNameResource.PersianMonthFarvardin')
  - [PersianMonthKhordad](#P-AtEase-Resources-DisplayNameResource-PersianMonthKhordad 'AtEase.Resources.DisplayNameResource.PersianMonthKhordad')
  - [PersianMonthMehr](#P-AtEase-Resources-DisplayNameResource-PersianMonthMehr 'AtEase.Resources.DisplayNameResource.PersianMonthMehr')
  - [PersianMonthMordad](#P-AtEase-Resources-DisplayNameResource-PersianMonthMordad 'AtEase.Resources.DisplayNameResource.PersianMonthMordad')
  - [PersianMonthOrdibehesht](#P-AtEase-Resources-DisplayNameResource-PersianMonthOrdibehesht 'AtEase.Resources.DisplayNameResource.PersianMonthOrdibehesht')
  - [PersianMonthShahrivar](#P-AtEase-Resources-DisplayNameResource-PersianMonthShahrivar 'AtEase.Resources.DisplayNameResource.PersianMonthShahrivar')
  - [PersianMonthTir](#P-AtEase-Resources-DisplayNameResource-PersianMonthTir 'AtEase.Resources.DisplayNameResource.PersianMonthTir')
  - [PhoneNumber](#P-AtEase-Resources-DisplayNameResource-PhoneNumber 'AtEase.Resources.DisplayNameResource.PhoneNumber')
  - [ResourceManager](#P-AtEase-Resources-DisplayNameResource-ResourceManager 'AtEase.Resources.DisplayNameResource.ResourceManager')
  - [ShamsiYear](#P-AtEase-Resources-DisplayNameResource-ShamsiYear 'AtEase.Resources.DisplayNameResource.ShamsiYear')
  - [Title](#P-AtEase-Resources-DisplayNameResource-Title 'AtEase.Resources.DisplayNameResource.Title')
  - [TransactionId](#P-AtEase-Resources-DisplayNameResource-TransactionId 'AtEase.Resources.DisplayNameResource.TransactionId')
  - [Warning](#P-AtEase-Resources-DisplayNameResource-Warning 'AtEase.Resources.DisplayNameResource.Warning')
  - [WeekFriday](#P-AtEase-Resources-DisplayNameResource-WeekFriday 'AtEase.Resources.DisplayNameResource.WeekFriday')
  - [WeekMonday](#P-AtEase-Resources-DisplayNameResource-WeekMonday 'AtEase.Resources.DisplayNameResource.WeekMonday')
  - [WeekSaturday](#P-AtEase-Resources-DisplayNameResource-WeekSaturday 'AtEase.Resources.DisplayNameResource.WeekSaturday')
  - [WeekSunday](#P-AtEase-Resources-DisplayNameResource-WeekSunday 'AtEase.Resources.DisplayNameResource.WeekSunday')
  - [WeekThursday](#P-AtEase-Resources-DisplayNameResource-WeekThursday 'AtEase.Resources.DisplayNameResource.WeekThursday')
  - [WeekTuesday](#P-AtEase-Resources-DisplayNameResource-WeekTuesday 'AtEase.Resources.DisplayNameResource.WeekTuesday')
  - [WeekWednesday](#P-AtEase-Resources-DisplayNameResource-WeekWednesday 'AtEase.Resources.DisplayNameResource.WeekWednesday')
- [EnumExtensions](#T-AtEase-Extensions-EnumExtensions 'AtEase.Extensions.EnumExtensions')
  - [ToByte(value)](#M-AtEase-Extensions-EnumExtensions-ToByte-System-Enum- 'AtEase.Extensions.EnumExtensions.ToByte(System.Enum)')
  - [ToInt(value)](#M-AtEase-Extensions-EnumExtensions-ToInt-System-Enum- 'AtEase.Extensions.EnumExtensions.ToInt(System.Enum)')
  - [ToInt16(value)](#M-AtEase-Extensions-EnumExtensions-ToInt16-System-Enum- 'AtEase.Extensions.EnumExtensions.ToInt16(System.Enum)')
- [EnumerableExtensions](#T-AtEase-Extensions-Collections-EnumerableExtensions 'AtEase.Extensions.Collections.EnumerableExtensions')
  - [IsNullOrEmpty\`\`1(items)](#M-AtEase-Extensions-Collections-EnumerableExtensions-IsNullOrEmpty``1-System-Collections-Generic-IEnumerable{``0}- 'AtEase.Extensions.Collections.EnumerableExtensions.IsNullOrEmpty``1(System.Collections.Generic.IEnumerable{``0})')
- [ErrorMessageResource](#T-AtEase-Resources-ErrorMessageResource 'AtEase.Resources.ErrorMessageResource')
  - [ArgumentError](#P-AtEase-Resources-ErrorMessageResource-ArgumentError 'AtEase.Resources.ErrorMessageResource.ArgumentError')
  - [ArgumentNullError](#P-AtEase-Resources-ErrorMessageResource-ArgumentNullError 'AtEase.Resources.ErrorMessageResource.ArgumentNullError')
  - [ArgumentOutOfRangeError](#P-AtEase-Resources-ErrorMessageResource-ArgumentOutOfRangeError 'AtEase.Resources.ErrorMessageResource.ArgumentOutOfRangeError')
  - [Culture](#P-AtEase-Resources-ErrorMessageResource-Culture 'AtEase.Resources.ErrorMessageResource.Culture')
  - [GreaterThanZero](#P-AtEase-Resources-ErrorMessageResource-GreaterThanZero 'AtEase.Resources.ErrorMessageResource.GreaterThanZero')
  - [InvalidSeatsError](#P-AtEase-Resources-ErrorMessageResource-InvalidSeatsError 'AtEase.Resources.ErrorMessageResource.InvalidSeatsError')
  - [MinLength](#P-AtEase-Resources-ErrorMessageResource-MinLength 'AtEase.Resources.ErrorMessageResource.MinLength')
  - [ObjectNotFoundError](#P-AtEase-Resources-ErrorMessageResource-ObjectNotFoundError 'AtEase.Resources.ErrorMessageResource.ObjectNotFoundError')
  - [ObjectNotInsertedToDatabase](#P-AtEase-Resources-ErrorMessageResource-ObjectNotInsertedToDatabase 'AtEase.Resources.ErrorMessageResource.ObjectNotInsertedToDatabase')
  - [PostalCodeLengthError](#P-AtEase-Resources-ErrorMessageResource-PostalCodeLengthError 'AtEase.Resources.ErrorMessageResource.PostalCodeLengthError')
  - [Required](#P-AtEase-Resources-ErrorMessageResource-Required 'AtEase.Resources.ErrorMessageResource.Required')
  - [ResourceManager](#P-AtEase-Resources-ErrorMessageResource-ResourceManager 'AtEase.Resources.ErrorMessageResource.ResourceManager')
  - [ShamsiYearIsNotValid](#P-AtEase-Resources-ErrorMessageResource-ShamsiYearIsNotValid 'AtEase.Resources.ErrorMessageResource.ShamsiYearIsNotValid')
- [IntExtensions](#T-AtEase-Extensions-Numbers-IntExtensions 'AtEase.Extensions.Numbers.IntExtensions')
  - [IsEven(value)](#M-AtEase-Extensions-Numbers-IntExtensions-IsEven-System-Int32- 'AtEase.Extensions.Numbers.IntExtensions.IsEven(System.Int32)')
  - [IsOdd(value)](#M-AtEase-Extensions-Numbers-IntExtensions-IsOdd-System-Int32- 'AtEase.Extensions.Numbers.IntExtensions.IsOdd(System.Int32)')
  - [IsZeroOrMin(value)](#M-AtEase-Extensions-Numbers-IntExtensions-IsZeroOrMin-System-Int32- 'AtEase.Extensions.Numbers.IntExtensions.IsZeroOrMin(System.Int32)')
- [ListExtensions](#T-AtEase-Extensions-Collections-ListExtensions 'AtEase.Extensions.Collections.ListExtensions')
  - [IsNullOrEmpty\`\`1(items)](#M-AtEase-Extensions-Collections-ListExtensions-IsNullOrEmpty``1-System-Collections-Generic-IList{``0}- 'AtEase.Extensions.Collections.ListExtensions.IsNullOrEmpty``1(System.Collections.Generic.IList{``0})')
- [LongExtensions](#T-AtEase-Extensions-Numbers-LongExtensions 'AtEase.Extensions.Numbers.LongExtensions')
  - [IsEven(value)](#M-AtEase-Extensions-Numbers-LongExtensions-IsEven-System-Int64- 'AtEase.Extensions.Numbers.LongExtensions.IsEven(System.Int64)')
  - [IsOdd(value)](#M-AtEase-Extensions-Numbers-LongExtensions-IsOdd-System-Int64- 'AtEase.Extensions.Numbers.LongExtensions.IsOdd(System.Int64)')
  - [IsZeroOrMin(value)](#M-AtEase-Extensions-Numbers-LongExtensions-IsZeroOrMin-System-Int64- 'AtEase.Extensions.Numbers.LongExtensions.IsZeroOrMin(System.Int64)')
- [NumbersToTimeSpanExtensions](#T-AtEase-Extensions-NumbersToTimeSpanExtensions 'AtEase.Extensions.NumbersToTimeSpanExtensions')
  - [Days()](#M-AtEase-Extensions-NumbersToTimeSpanExtensions-Days-System-Double- 'AtEase.Extensions.NumbersToTimeSpanExtensions.Days(System.Double)')
  - [Days()](#M-AtEase-Extensions-NumbersToTimeSpanExtensions-Days-System-Int32- 'AtEase.Extensions.NumbersToTimeSpanExtensions.Days(System.Int32)')
  - [Days()](#M-AtEase-Extensions-NumbersToTimeSpanExtensions-Days-System-Int64- 'AtEase.Extensions.NumbersToTimeSpanExtensions.Days(System.Int64)')
  - [Days()](#M-AtEase-Extensions-NumbersToTimeSpanExtensions-Days-System-Int16- 'AtEase.Extensions.NumbersToTimeSpanExtensions.Days(System.Int16)')
  - [Hours()](#M-AtEase-Extensions-NumbersToTimeSpanExtensions-Hours-System-Double- 'AtEase.Extensions.NumbersToTimeSpanExtensions.Hours(System.Double)')
  - [Hours()](#M-AtEase-Extensions-NumbersToTimeSpanExtensions-Hours-System-Int32- 'AtEase.Extensions.NumbersToTimeSpanExtensions.Hours(System.Int32)')
  - [Hours()](#M-AtEase-Extensions-NumbersToTimeSpanExtensions-Hours-System-Int64- 'AtEase.Extensions.NumbersToTimeSpanExtensions.Hours(System.Int64)')
  - [Hours()](#M-AtEase-Extensions-NumbersToTimeSpanExtensions-Hours-System-Int16- 'AtEase.Extensions.NumbersToTimeSpanExtensions.Hours(System.Int16)')
  - [Milliseconds()](#M-AtEase-Extensions-NumbersToTimeSpanExtensions-Milliseconds-System-Double- 'AtEase.Extensions.NumbersToTimeSpanExtensions.Milliseconds(System.Double)')
  - [Milliseconds()](#M-AtEase-Extensions-NumbersToTimeSpanExtensions-Milliseconds-System-Int32- 'AtEase.Extensions.NumbersToTimeSpanExtensions.Milliseconds(System.Int32)')
  - [Milliseconds()](#M-AtEase-Extensions-NumbersToTimeSpanExtensions-Milliseconds-System-Int64- 'AtEase.Extensions.NumbersToTimeSpanExtensions.Milliseconds(System.Int64)')
  - [Milliseconds()](#M-AtEase-Extensions-NumbersToTimeSpanExtensions-Milliseconds-System-Int16- 'AtEase.Extensions.NumbersToTimeSpanExtensions.Milliseconds(System.Int16)')
  - [Minutes()](#M-AtEase-Extensions-NumbersToTimeSpanExtensions-Minutes-System-Double- 'AtEase.Extensions.NumbersToTimeSpanExtensions.Minutes(System.Double)')
  - [Minutes()](#M-AtEase-Extensions-NumbersToTimeSpanExtensions-Minutes-System-Int32- 'AtEase.Extensions.NumbersToTimeSpanExtensions.Minutes(System.Int32)')
  - [Minutes()](#M-AtEase-Extensions-NumbersToTimeSpanExtensions-Minutes-System-Int64- 'AtEase.Extensions.NumbersToTimeSpanExtensions.Minutes(System.Int64)')
  - [Minutes()](#M-AtEase-Extensions-NumbersToTimeSpanExtensions-Minutes-System-Int16- 'AtEase.Extensions.NumbersToTimeSpanExtensions.Minutes(System.Int16)')
  - [Seconds()](#M-AtEase-Extensions-NumbersToTimeSpanExtensions-Seconds-System-Double- 'AtEase.Extensions.NumbersToTimeSpanExtensions.Seconds(System.Double)')
  - [Seconds()](#M-AtEase-Extensions-NumbersToTimeSpanExtensions-Seconds-System-Int32- 'AtEase.Extensions.NumbersToTimeSpanExtensions.Seconds(System.Int32)')
  - [Seconds()](#M-AtEase-Extensions-NumbersToTimeSpanExtensions-Seconds-System-Int64- 'AtEase.Extensions.NumbersToTimeSpanExtensions.Seconds(System.Int64)')
  - [Seconds()](#M-AtEase-Extensions-NumbersToTimeSpanExtensions-Seconds-System-Int16- 'AtEase.Extensions.NumbersToTimeSpanExtensions.Seconds(System.Int16)')
  - [Ticks()](#M-AtEase-Extensions-NumbersToTimeSpanExtensions-Ticks-System-Int32- 'AtEase.Extensions.NumbersToTimeSpanExtensions.Ticks(System.Int32)')
  - [Ticks()](#M-AtEase-Extensions-NumbersToTimeSpanExtensions-Ticks-System-Int64- 'AtEase.Extensions.NumbersToTimeSpanExtensions.Ticks(System.Int64)')
  - [Ticks()](#M-AtEase-Extensions-NumbersToTimeSpanExtensions-Ticks-System-Int16- 'AtEase.Extensions.NumbersToTimeSpanExtensions.Ticks(System.Int16)')
  - [ToTimeSpan(value)](#M-AtEase-Extensions-NumbersToTimeSpanExtensions-ToTimeSpan-System-ValueTuple{System-Int32,System-Int32,System-Int32}- 'AtEase.Extensions.NumbersToTimeSpanExtensions.ToTimeSpan(System.ValueTuple{System.Int32,System.Int32,System.Int32})')
  - [ToTimeSpan(value)](#M-AtEase-Extensions-NumbersToTimeSpanExtensions-ToTimeSpan-System-ValueTuple{System-Int32,System-Int32,System-Int32,System-Int32}- 'AtEase.Extensions.NumbersToTimeSpanExtensions.ToTimeSpan(System.ValueTuple{System.Int32,System.Int32,System.Int32,System.Int32})')
  - [ToTimeSpan(value)](#M-AtEase-Extensions-NumbersToTimeSpanExtensions-ToTimeSpan-System-ValueTuple{System-Int32,System-Int32,System-Int32,System-Int32,System-Int32}- 'AtEase.Extensions.NumbersToTimeSpanExtensions.ToTimeSpan(System.ValueTuple{System.Int32,System.Int32,System.Int32,System.Int32,System.Int32})')
  - [Weeks()](#M-AtEase-Extensions-NumbersToTimeSpanExtensions-Weeks-System-Double- 'AtEase.Extensions.NumbersToTimeSpanExtensions.Weeks(System.Double)')
  - [Weeks()](#M-AtEase-Extensions-NumbersToTimeSpanExtensions-Weeks-System-Int32- 'AtEase.Extensions.NumbersToTimeSpanExtensions.Weeks(System.Int32)')
  - [Weeks()](#M-AtEase-Extensions-NumbersToTimeSpanExtensions-Weeks-System-Int64- 'AtEase.Extensions.NumbersToTimeSpanExtensions.Weeks(System.Int64)')
  - [Weeks()](#M-AtEase-Extensions-NumbersToTimeSpanExtensions-Weeks-System-Int16- 'AtEase.Extensions.NumbersToTimeSpanExtensions.Weeks(System.Int16)')
- [OperationResult](#T-AtEase-OperationResult 'AtEase.OperationResult')
  - [#ctor(errors)](#M-AtEase-OperationResult-#ctor-System-String[]- 'AtEase.OperationResult.#ctor(System.String[])')
  - [#ctor(errors)](#M-AtEase-OperationResult-#ctor-System-Collections-Generic-IEnumerable{System-String}- 'AtEase.OperationResult.#ctor(System.Collections.Generic.IEnumerable{System.String})')
  - [#ctor(success)](#M-AtEase-OperationResult-#ctor-System-Boolean- 'AtEase.OperationResult.#ctor(System.Boolean)')
  - [Errors](#P-AtEase-OperationResult-Errors 'AtEase.OperationResult.Errors')
  - [Succeeded](#P-AtEase-OperationResult-Succeeded 'AtEase.OperationResult.Succeeded')
  - [Failed(errors)](#M-AtEase-OperationResult-Failed-System-String[]- 'AtEase.OperationResult.Failed(System.String[])')
  - [Succeed()](#M-AtEase-OperationResult-Succeed 'AtEase.OperationResult.Succeed')
- [OperationResult\`1](#T-AtEase-OperationResult`1 'AtEase.OperationResult`1')
  - [#ctor(errors)](#M-AtEase-OperationResult`1-#ctor-System-String[]- 'AtEase.OperationResult`1.#ctor(System.String[])')
  - [#ctor(errors)](#M-AtEase-OperationResult`1-#ctor-System-Collections-Generic-IEnumerable{System-String}- 'AtEase.OperationResult`1.#ctor(System.Collections.Generic.IEnumerable{System.String})')
  - [Failed(errors)](#M-AtEase-OperationResult`1-Failed-System-String[]- 'AtEase.OperationResult`1.Failed(System.String[])')
  - [WithData()](#M-AtEase-OperationResult`1-WithData-`0- 'AtEase.OperationResult`1.WithData(`0)')

<a name='T-AtEase-Extensions-ArrayExtensions'></a>
## ArrayExtensions `type`

##### Namespace

AtEase.Extensions

<a name='M-AtEase-Extensions-ArrayExtensions-IsNullOrEmpty-System-Array-'></a>
### IsNullOrEmpty(items) `method`

##### Summary

Determines whether a collection is null or has no elements without having to enumerate the entire collection to get
    a count.  Uses LINQ.

##### Returns

`true` if this list is null or empty; otherwise, `false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| items | [System.Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') | The items. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The item type. |

<a name='T-AtEase-Resources-DisplayNameResource'></a>
## DisplayNameResource `type`

##### Namespace

AtEase.Resources

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-AtEase-Resources-DisplayNameResource-Amount'></a>
### Amount `property`

##### Summary

Looks up a localized string similar to مبلغ.

<a name='P-AtEase-Resources-DisplayNameResource-Available'></a>
### Available `property`

##### Summary

Looks up a localized string similar to موجود.

<a name='P-AtEase-Resources-DisplayNameResource-Chosen'></a>
### Chosen `property`

##### Summary

Looks up a localized string similar to انتخاب شده.

<a name='P-AtEase-Resources-DisplayNameResource-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-AtEase-Resources-DisplayNameResource-Debug'></a>
### Debug `property`

##### Summary

Looks up a localized string similar to Debug.

<a name='P-AtEase-Resources-DisplayNameResource-EnumValue'></a>
### EnumValue `property`

##### Summary

Looks up a localized string similar to EnumValue.

<a name='P-AtEase-Resources-DisplayNameResource-Error'></a>
### Error `property`

##### Summary

Looks up a localized string similar to Error.

<a name='P-AtEase-Resources-DisplayNameResource-Fatal'></a>
### Fatal `property`

##### Summary

Looks up a localized string similar to Fatal.

<a name='P-AtEase-Resources-DisplayNameResource-Height'></a>
### Height `property`

##### Summary

Looks up a localized string similar to طول.

<a name='P-AtEase-Resources-DisplayNameResource-Image'></a>
### Image `property`

##### Summary

Looks up a localized string similar to تصویر.

<a name='P-AtEase-Resources-DisplayNameResource-Information'></a>
### Information `property`

##### Summary

Looks up a localized string similar to Information.

<a name='P-AtEase-Resources-DisplayNameResource-None'></a>
### None `property`

##### Summary

Looks up a localized string similar to .

<a name='P-AtEase-Resources-DisplayNameResource-PersianMonthAban'></a>
### PersianMonthAban `property`

##### Summary

Looks up a localized string similar to آبان.

<a name='P-AtEase-Resources-DisplayNameResource-PersianMonthAzar'></a>
### PersianMonthAzar `property`

##### Summary

Looks up a localized string similar to آذر.

<a name='P-AtEase-Resources-DisplayNameResource-PersianMonthBahman'></a>
### PersianMonthBahman `property`

##### Summary

Looks up a localized string similar to بهمن.

<a name='P-AtEase-Resources-DisplayNameResource-PersianMonthDey'></a>
### PersianMonthDey `property`

##### Summary

Looks up a localized string similar to دی .

<a name='P-AtEase-Resources-DisplayNameResource-PersianMonthEsfand'></a>
### PersianMonthEsfand `property`

##### Summary

Looks up a localized string similar to اسفند.

<a name='P-AtEase-Resources-DisplayNameResource-PersianMonthFarvardin'></a>
### PersianMonthFarvardin `property`

##### Summary

Looks up a localized string similar to فروردین.

<a name='P-AtEase-Resources-DisplayNameResource-PersianMonthKhordad'></a>
### PersianMonthKhordad `property`

##### Summary

Looks up a localized string similar to خرداد.

<a name='P-AtEase-Resources-DisplayNameResource-PersianMonthMehr'></a>
### PersianMonthMehr `property`

##### Summary

Looks up a localized string similar to مهر.

<a name='P-AtEase-Resources-DisplayNameResource-PersianMonthMordad'></a>
### PersianMonthMordad `property`

##### Summary

Looks up a localized string similar to مرداد.

<a name='P-AtEase-Resources-DisplayNameResource-PersianMonthOrdibehesht'></a>
### PersianMonthOrdibehesht `property`

##### Summary

Looks up a localized string similar to اردیبهشت.

<a name='P-AtEase-Resources-DisplayNameResource-PersianMonthShahrivar'></a>
### PersianMonthShahrivar `property`

##### Summary

Looks up a localized string similar to شهریور.

<a name='P-AtEase-Resources-DisplayNameResource-PersianMonthTir'></a>
### PersianMonthTir `property`

##### Summary

Looks up a localized string similar to تیر.

<a name='P-AtEase-Resources-DisplayNameResource-PhoneNumber'></a>
### PhoneNumber `property`

##### Summary

Looks up a localized string similar to تلفن همراه.

<a name='P-AtEase-Resources-DisplayNameResource-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.

<a name='P-AtEase-Resources-DisplayNameResource-ShamsiYear'></a>
### ShamsiYear `property`

##### Summary

Looks up a localized string similar to سال شمسی.

<a name='P-AtEase-Resources-DisplayNameResource-Title'></a>
### Title `property`

##### Summary

Looks up a localized string similar to عنوان.

<a name='P-AtEase-Resources-DisplayNameResource-TransactionId'></a>
### TransactionId `property`

##### Summary

Looks up a localized string similar to شناسه تراکنش.

<a name='P-AtEase-Resources-DisplayNameResource-Warning'></a>
### Warning `property`

##### Summary

Looks up a localized string similar to Warning.

<a name='P-AtEase-Resources-DisplayNameResource-WeekFriday'></a>
### WeekFriday `property`

##### Summary

Looks up a localized string similar to جمعه.

<a name='P-AtEase-Resources-DisplayNameResource-WeekMonday'></a>
### WeekMonday `property`

##### Summary

Looks up a localized string similar to دوشنبه.

<a name='P-AtEase-Resources-DisplayNameResource-WeekSaturday'></a>
### WeekSaturday `property`

##### Summary

Looks up a localized string similar to شنبه.

<a name='P-AtEase-Resources-DisplayNameResource-WeekSunday'></a>
### WeekSunday `property`

##### Summary

Looks up a localized string similar to یکشنبه.

<a name='P-AtEase-Resources-DisplayNameResource-WeekThursday'></a>
### WeekThursday `property`

##### Summary

Looks up a localized string similar to پنجشنبه.

<a name='P-AtEase-Resources-DisplayNameResource-WeekTuesday'></a>
### WeekTuesday `property`

##### Summary

Looks up a localized string similar to سه شنبه.

<a name='P-AtEase-Resources-DisplayNameResource-WeekWednesday'></a>
### WeekWednesday `property`

##### Summary

Looks up a localized string similar to چهارشنبه.

<a name='T-AtEase-Extensions-EnumExtensions'></a>
## EnumExtensions `type`

##### Namespace

AtEase.Extensions

<a name='M-AtEase-Extensions-EnumExtensions-ToByte-System-Enum-'></a>
### ToByte(value) `method`

##### Summary

Converts the value of the specified Enum to an 8-bit unsigned integer.

##### Returns

Byte

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Enum](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Enum 'System.Enum') | Enum |

<a name='M-AtEase-Extensions-EnumExtensions-ToInt-System-Enum-'></a>
### ToInt(value) `method`

##### Summary

Converts the value of the specified Enum to a 32-bit signed integer.

##### Returns

Int32

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Enum](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Enum 'System.Enum') | Enum |

<a name='M-AtEase-Extensions-EnumExtensions-ToInt16-System-Enum-'></a>
### ToInt16(value) `method`

##### Summary

Converts the value of the specified Enum to a 16-bit signed integer.

##### Returns

Int16

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Enum](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Enum 'System.Enum') | Enum |

<a name='T-AtEase-Extensions-Collections-EnumerableExtensions'></a>
## EnumerableExtensions `type`

##### Namespace

AtEase.Extensions.Collections

<a name='M-AtEase-Extensions-Collections-EnumerableExtensions-IsNullOrEmpty``1-System-Collections-Generic-IEnumerable{``0}-'></a>
### IsNullOrEmpty\`\`1(items) `method`

##### Summary

Determines whether a collection is null or has no elements without having to enumerate the entire collection to get
    a count.  Uses LINQ.

##### Returns

`true` if this list is null or empty; otherwise, `false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| items | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | The items. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The item type. |

<a name='T-AtEase-Resources-ErrorMessageResource'></a>
## ErrorMessageResource `type`

##### Namespace

AtEase.Resources

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-AtEase-Resources-ErrorMessageResource-ArgumentError'></a>
### ArgumentError `property`

##### Summary

Looks up a localized string similar to مقدار وارد شده معتبر نمی باشد..

<a name='P-AtEase-Resources-ErrorMessageResource-ArgumentNullError'></a>
### ArgumentNullError `property`

##### Summary

Looks up a localized string similar to مقدار  وارد نشده است..

<a name='P-AtEase-Resources-ErrorMessageResource-ArgumentOutOfRangeError'></a>
### ArgumentOutOfRangeError `property`

##### Summary

Looks up a localized string similar to مقدار وارد شده در محدوده مجاز نیست..

<a name='P-AtEase-Resources-ErrorMessageResource-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-AtEase-Resources-ErrorMessageResource-GreaterThanZero'></a>
### GreaterThanZero `property`

##### Summary

Looks up a localized string similar to مقدار وارد شده باید بزرگتر از صفر باشد..

<a name='P-AtEase-Resources-ErrorMessageResource-InvalidSeatsError'></a>
### InvalidSeatsError `property`

##### Summary

Looks up a localized string similar to خطا در مقادیر صندلی ها.

<a name='P-AtEase-Resources-ErrorMessageResource-MinLength'></a>
### MinLength `property`

##### Summary

Looks up a localized string similar to حداقل {1} آیتم باید وارد شود..

<a name='P-AtEase-Resources-ErrorMessageResource-ObjectNotFoundError'></a>
### ObjectNotFoundError `property`

##### Summary

Looks up a localized string similar to مقدا {0} برای شناسه {0} یافت نشد..

<a name='P-AtEase-Resources-ErrorMessageResource-ObjectNotInsertedToDatabase'></a>
### ObjectNotInsertedToDatabase `property`

##### Summary

Looks up a localized string similar to مقادیر وارد شده در پایگاه داده وارد نشد..

<a name='P-AtEase-Resources-ErrorMessageResource-PostalCodeLengthError'></a>
### PostalCodeLengthError `property`

##### Summary

Looks up a localized string similar to کد پستی باید 10 کاراکتر عددی باشد..

<a name='P-AtEase-Resources-ErrorMessageResource-Required'></a>
### Required `property`

##### Summary

Looks up a localized string similar to لطفا {0} را وارد نمایید..

<a name='P-AtEase-Resources-ErrorMessageResource-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.

<a name='P-AtEase-Resources-ErrorMessageResource-ShamsiYearIsNotValid'></a>
### ShamsiYearIsNotValid `property`

##### Summary

Looks up a localized string similar to سال شمسی معتبر نمیباشد..

<a name='T-AtEase-Extensions-Numbers-IntExtensions'></a>
## IntExtensions `type`

##### Namespace

AtEase.Extensions.Numbers

<a name='M-AtEase-Extensions-Numbers-IntExtensions-IsEven-System-Int32-'></a>
### IsEven(value) `method`

##### Summary

Indicates the value is even.

##### Returns

Returns true if value is even.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Int value |

<a name='M-AtEase-Extensions-Numbers-IntExtensions-IsOdd-System-Int32-'></a>
### IsOdd(value) `method`

##### Summary

Indicates the value is odd.

##### Returns

Returns true if value is odd.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Int value |

<a name='M-AtEase-Extensions-Numbers-IntExtensions-IsZeroOrMin-System-Int32-'></a>
### IsZeroOrMin(value) `method`

##### Summary

Indicates the value as int  is 0 or int.MinValue value.

##### Returns

Returns true if value is 0 or min value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Int value |

<a name='T-AtEase-Extensions-Collections-ListExtensions'></a>
## ListExtensions `type`

##### Namespace

AtEase.Extensions.Collections

<a name='M-AtEase-Extensions-Collections-ListExtensions-IsNullOrEmpty``1-System-Collections-Generic-IList{``0}-'></a>
### IsNullOrEmpty\`\`1(items) `method`

##### Summary

Determines whether a collection is null or has no elements without having to enumerate the entire collection to get
    a count.  Uses LINQ.

##### Returns

`true` if this list is null or empty; otherwise, `false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| items | [System.Collections.Generic.IList{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IList 'System.Collections.Generic.IList{``0}') | The items. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The item type. |

<a name='T-AtEase-Extensions-Numbers-LongExtensions'></a>
## LongExtensions `type`

##### Namespace

AtEase.Extensions.Numbers

<a name='M-AtEase-Extensions-Numbers-LongExtensions-IsEven-System-Int64-'></a>
### IsEven(value) `method`

##### Summary

Indicates the value is even.

##### Returns

Returns true if value is even.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') | Long value |

<a name='M-AtEase-Extensions-Numbers-LongExtensions-IsOdd-System-Int64-'></a>
### IsOdd(value) `method`

##### Summary

Indicates the value is odd.

##### Returns

Returns true if value is odd.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') | Long value |

<a name='M-AtEase-Extensions-Numbers-LongExtensions-IsZeroOrMin-System-Int64-'></a>
### IsZeroOrMin(value) `method`

##### Summary

Indicates the value as long  is 0 or long.MinValue value.

##### Returns

Returns true if value is 0 or min value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') | Long value |

<a name='T-AtEase-Extensions-NumbersToTimeSpanExtensions'></a>
## NumbersToTimeSpanExtensions `type`

##### Namespace

AtEase.Extensions

<a name='M-AtEase-Extensions-NumbersToTimeSpanExtensions-Days-System-Double-'></a>
### Days() `method`

##### Summary

Returns a new [TimeSpan](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.TimeSpan 'System.TimeSpan') object represented by `number` as `Days`.

##### Parameters

This method has no parameters.

<a name='M-AtEase-Extensions-NumbersToTimeSpanExtensions-Days-System-Int32-'></a>
### Days() `method`

##### Summary

Returns a new [TimeSpan](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.TimeSpan 'System.TimeSpan') object represented by `number` as `Days`.

##### Parameters

This method has no parameters.

<a name='M-AtEase-Extensions-NumbersToTimeSpanExtensions-Days-System-Int64-'></a>
### Days() `method`

##### Summary

Returns a new [TimeSpan](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.TimeSpan 'System.TimeSpan') object represented by `number` as `Days`.

##### Parameters

This method has no parameters.

<a name='M-AtEase-Extensions-NumbersToTimeSpanExtensions-Days-System-Int16-'></a>
### Days() `method`

##### Summary

Returns a new [TimeSpan](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.TimeSpan 'System.TimeSpan') object represented by `number` as `Days`.

##### Parameters

This method has no parameters.

<a name='M-AtEase-Extensions-NumbersToTimeSpanExtensions-Hours-System-Double-'></a>
### Hours() `method`

##### Summary

Returns a new [TimeSpan](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.TimeSpan 'System.TimeSpan') object represented by `number` as `Hours`.

##### Parameters

This method has no parameters.

<a name='M-AtEase-Extensions-NumbersToTimeSpanExtensions-Hours-System-Int32-'></a>
### Hours() `method`

##### Summary

Returns a new [TimeSpan](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.TimeSpan 'System.TimeSpan') object represented by `number` as `Hours`.

##### Parameters

This method has no parameters.

<a name='M-AtEase-Extensions-NumbersToTimeSpanExtensions-Hours-System-Int64-'></a>
### Hours() `method`

##### Summary

Returns a new [TimeSpan](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.TimeSpan 'System.TimeSpan') object represented by `number` as `Hours`.

##### Parameters

This method has no parameters.

<a name='M-AtEase-Extensions-NumbersToTimeSpanExtensions-Hours-System-Int16-'></a>
### Hours() `method`

##### Summary

Returns a new [TimeSpan](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.TimeSpan 'System.TimeSpan') object represented by `number` as `Hours`.

##### Parameters

This method has no parameters.

<a name='M-AtEase-Extensions-NumbersToTimeSpanExtensions-Milliseconds-System-Double-'></a>
### Milliseconds() `method`

##### Summary

Returns a new [TimeSpan](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.TimeSpan 'System.TimeSpan') object represented by `number` as `Milliseconds`.

##### Parameters

This method has no parameters.

<a name='M-AtEase-Extensions-NumbersToTimeSpanExtensions-Milliseconds-System-Int32-'></a>
### Milliseconds() `method`

##### Summary

Returns a new [TimeSpan](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.TimeSpan 'System.TimeSpan') object represented by `number` as `Milliseconds`.

##### Parameters

This method has no parameters.

<a name='M-AtEase-Extensions-NumbersToTimeSpanExtensions-Milliseconds-System-Int64-'></a>
### Milliseconds() `method`

##### Summary

Returns a new [TimeSpan](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.TimeSpan 'System.TimeSpan') object represented by `number` as `Milliseconds`.

##### Parameters

This method has no parameters.

<a name='M-AtEase-Extensions-NumbersToTimeSpanExtensions-Milliseconds-System-Int16-'></a>
### Milliseconds() `method`

##### Summary

Returns a new [TimeSpan](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.TimeSpan 'System.TimeSpan') object represented by `number` as `Milliseconds`.

##### Parameters

This method has no parameters.

<a name='M-AtEase-Extensions-NumbersToTimeSpanExtensions-Minutes-System-Double-'></a>
### Minutes() `method`

##### Summary

Returns a new [TimeSpan](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.TimeSpan 'System.TimeSpan') object represented by `number` as `Minutes`.

##### Parameters

This method has no parameters.

<a name='M-AtEase-Extensions-NumbersToTimeSpanExtensions-Minutes-System-Int32-'></a>
### Minutes() `method`

##### Summary

Returns a new [TimeSpan](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.TimeSpan 'System.TimeSpan') object represented by `number` as `Minutes`.

##### Parameters

This method has no parameters.

<a name='M-AtEase-Extensions-NumbersToTimeSpanExtensions-Minutes-System-Int64-'></a>
### Minutes() `method`

##### Summary

Returns a new [TimeSpan](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.TimeSpan 'System.TimeSpan') object represented by `number` as `Minutes`.

##### Parameters

This method has no parameters.

<a name='M-AtEase-Extensions-NumbersToTimeSpanExtensions-Minutes-System-Int16-'></a>
### Minutes() `method`

##### Summary

Returns a new [TimeSpan](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.TimeSpan 'System.TimeSpan') object represented by `number` as `Minutes`.

##### Parameters

This method has no parameters.

<a name='M-AtEase-Extensions-NumbersToTimeSpanExtensions-Seconds-System-Double-'></a>
### Seconds() `method`

##### Summary

Returns a new [TimeSpan](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.TimeSpan 'System.TimeSpan') object represented by `number` as `Seconds`.

##### Parameters

This method has no parameters.

<a name='M-AtEase-Extensions-NumbersToTimeSpanExtensions-Seconds-System-Int32-'></a>
### Seconds() `method`

##### Summary

Returns a new [TimeSpan](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.TimeSpan 'System.TimeSpan') object represented by `number` as `Seconds`.

##### Parameters

This method has no parameters.

<a name='M-AtEase-Extensions-NumbersToTimeSpanExtensions-Seconds-System-Int64-'></a>
### Seconds() `method`

##### Summary

Returns a new [TimeSpan](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.TimeSpan 'System.TimeSpan') object represented by `number` as `Seconds`.

##### Parameters

This method has no parameters.

<a name='M-AtEase-Extensions-NumbersToTimeSpanExtensions-Seconds-System-Int16-'></a>
### Seconds() `method`

##### Summary

Returns a new [TimeSpan](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.TimeSpan 'System.TimeSpan') object represented by `number` as `Seconds`.

##### Parameters

This method has no parameters.

<a name='M-AtEase-Extensions-NumbersToTimeSpanExtensions-Ticks-System-Int32-'></a>
### Ticks() `method`

##### Summary

Returns a new [TimeSpan](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.TimeSpan 'System.TimeSpan') object represented by `number` as `Ticks`.

##### Parameters

This method has no parameters.

<a name='M-AtEase-Extensions-NumbersToTimeSpanExtensions-Ticks-System-Int64-'></a>
### Ticks() `method`

##### Summary

Returns a new [TimeSpan](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.TimeSpan 'System.TimeSpan') object represented by `number` as `Ticks`
    .

##### Parameters

This method has no parameters.

<a name='M-AtEase-Extensions-NumbersToTimeSpanExtensions-Ticks-System-Int16-'></a>
### Ticks() `method`

##### Summary

Returns a new [TimeSpan](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.TimeSpan 'System.TimeSpan') object represented by `number` as `Ticks`.

##### Parameters

This method has no parameters.

<a name='M-AtEase-Extensions-NumbersToTimeSpanExtensions-ToTimeSpan-System-ValueTuple{System-Int32,System-Int32,System-Int32}-'></a>
### ToTimeSpan(value) `method`

##### Summary

Initializes a new instance of the [TimeSpan](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.TimeSpan 'System.TimeSpan') structure to a specified number of hours, minutes and
    seconds.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.ValueTuple{System.Int32,System.Int32,System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ValueTuple 'System.ValueTuple{System.Int32,System.Int32,System.Int32}') | Tuple(hours, minutes, seconds) |

<a name='M-AtEase-Extensions-NumbersToTimeSpanExtensions-ToTimeSpan-System-ValueTuple{System-Int32,System-Int32,System-Int32,System-Int32}-'></a>
### ToTimeSpan(value) `method`

##### Summary

Initializes a new instance of the [TimeSpan](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.TimeSpan 'System.TimeSpan') structure to a specified number of days, hours,
    minutes, and seconds.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.ValueTuple{System.Int32,System.Int32,System.Int32,System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ValueTuple 'System.ValueTuple{System.Int32,System.Int32,System.Int32,System.Int32}') | Tuple(days, hours, minutes, seconds) |

<a name='M-AtEase-Extensions-NumbersToTimeSpanExtensions-ToTimeSpan-System-ValueTuple{System-Int32,System-Int32,System-Int32,System-Int32,System-Int32}-'></a>
### ToTimeSpan(value) `method`

##### Summary

Initializes a new instance of the [TimeSpan](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.TimeSpan 'System.TimeSpan') structure to a specified number of days, hours,
    minutes, seconds, and milliseconds.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.ValueTuple{System.Int32,System.Int32,System.Int32,System.Int32,System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ValueTuple 'System.ValueTuple{System.Int32,System.Int32,System.Int32,System.Int32,System.Int32}') | Tuple(days, hours, minutes, seconds, milliseconds) |

<a name='M-AtEase-Extensions-NumbersToTimeSpanExtensions-Weeks-System-Double-'></a>
### Weeks() `method`

##### Summary

Returns a new [TimeSpan](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.TimeSpan 'System.TimeSpan') object represented by `number` as `Weeks`.

##### Parameters

This method has no parameters.

<a name='M-AtEase-Extensions-NumbersToTimeSpanExtensions-Weeks-System-Int32-'></a>
### Weeks() `method`

##### Summary

Returns a new [TimeSpan](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.TimeSpan 'System.TimeSpan') object represented by `number` as `Weeks`.

##### Parameters

This method has no parameters.

<a name='M-AtEase-Extensions-NumbersToTimeSpanExtensions-Weeks-System-Int64-'></a>
### Weeks() `method`

##### Summary

Returns a new [TimeSpan](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.TimeSpan 'System.TimeSpan') object represented by `number` as `Weeks`.

##### Parameters

This method has no parameters.

<a name='M-AtEase-Extensions-NumbersToTimeSpanExtensions-Weeks-System-Int16-'></a>
### Weeks() `method`

##### Summary

Returns a new [TimeSpan](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.TimeSpan 'System.TimeSpan') object represented by `number` as `Weeks`.

##### Parameters

This method has no parameters.

<a name='T-AtEase-OperationResult'></a>
## OperationResult `type`

##### Namespace

AtEase

<a name='M-AtEase-OperationResult-#ctor-System-String[]-'></a>
### #ctor(errors) `constructor`

##### Summary

Failure constructor that takes error messages

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| errors | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') |  |

<a name='M-AtEase-OperationResult-#ctor-System-Collections-Generic-IEnumerable{System-String}-'></a>
### #ctor(errors) `constructor`

##### Summary

Failure constructor that takes error messages

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| errors | [System.Collections.Generic.IEnumerable{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{System.String}') |  |

<a name='M-AtEase-OperationResult-#ctor-System-Boolean-'></a>
### #ctor(success) `constructor`

##### Summary

Constructor that takes whether the result is successful

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| success | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') |  |

<a name='P-AtEase-OperationResult-Errors'></a>
### Errors `property`

##### Summary

List of errors

<a name='P-AtEase-OperationResult-Succeeded'></a>
### Succeeded `property`

##### Summary

True if the operation was successful

<a name='M-AtEase-OperationResult-Failed-System-String[]-'></a>
### Failed(errors) `method`

##### Summary

Failed helper method

##### Returns

OperationResult with error

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| errors | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') |  |

<a name='M-AtEase-OperationResult-Succeed'></a>
### Succeed() `method`

##### Summary

Static success result

##### Returns

Succeed OperationResult

##### Parameters

This method has no parameters.

<a name='T-AtEase-OperationResult`1'></a>
## OperationResult\`1 `type`

##### Namespace

AtEase

<a name='M-AtEase-OperationResult`1-#ctor-System-String[]-'></a>
### #ctor(errors) `constructor`

##### Summary

Failure constructor that takes error messages

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| errors | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') |  |

<a name='M-AtEase-OperationResult`1-#ctor-System-Collections-Generic-IEnumerable{System-String}-'></a>
### #ctor(errors) `constructor`

##### Summary

Failure constructor that takes error messages

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| errors | [System.Collections.Generic.IEnumerable{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{System.String}') |  |

<a name='M-AtEase-OperationResult`1-Failed-System-String[]-'></a>
### Failed(errors) `method`

##### Summary

Failed helper method

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| errors | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') |  |

<a name='M-AtEase-OperationResult`1-WithData-`0-'></a>
### WithData() `method`

##### Summary

Add data to result.

##### Parameters

This method has no parameters.
