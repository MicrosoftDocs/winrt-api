---
-api-id: P:Windows.Storage.StorageFile.DateCreated
-api-type: winrt property
---

<!-- Property syntax
public System.DateTime DateCreated { get; }
-->

# Windows.Storage.StorageFile.DateCreated

## -description

Gets the date and time when the current file was created.

## -property-value

The date and time when the current file was created.

## -remarks

- **DateTime**: If the date property isn't set, this value defaults to 0 which can be translated into misleading dates in different programming languages. Microsoft .NET languages do not use this type directly. In .NET it is projected as a `System.DateTimeOffset`. Each language transparently handles the conversion to the granularity and date ranges for the respective language.

- **DateTimeOffset**: Because the .NET `DateTimeOffset` is a structure, a `DateTimeOffset` object that has been declared but not otherwise initialized contains the default values for each of its member fields. This means that its `DateTime` property is set to `DateTimeOffset.MinValue` and its `Offset` property is set to `TimeSpan.Zero`. In string format, the `DateTimeOffset` that a file was created might be "4/18/2020 3:13:50 PM".

You should always check that this property is a real value and is not set to the default value.

## -examples

## -see-also
