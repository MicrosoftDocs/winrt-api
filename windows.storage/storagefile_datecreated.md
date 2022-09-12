---
-api-id: P:Windows.Storage.StorageFile.DateCreated
-api-type: winrt property
---

<!-- Property syntax
public System.DateTimeOffset DateCreated { get; }
-->

# Windows.Storage.StorageFile.DateCreated

## -description

Gets the date and time when the current file was created.

## -property-value

The date and time when the current file was created.

For example, in string format the [DateTimeOffset](/dotnet/api/system.datetimeoffset) that a file was created might be "4/18/2020 3:13:50 PM".

## -remarks

Because `DateTimeOffset` is a structure, a `DateTimeOffset` object that has been declared but not otherwise initialized contains the default values for each of its member fields. This means that its `DateTime` property is set to `DateTimeOffset.MinValue` and its `Offset` property is set to `TimeSpan.Zero`. You should always check that this property is a real value and is not set to the default value.

## -examples

## -see-also
