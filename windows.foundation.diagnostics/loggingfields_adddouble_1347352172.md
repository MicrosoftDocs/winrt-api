---
-api-id: M:Windows.Foundation.Diagnostics.LoggingFields.AddDouble(System.String,System.Double,Windows.Foundation.Diagnostics.LoggingFieldFormat,System.Int32)
-api-type: winrt method
---

<!-- Method syntax
public void AddDouble(System.String name, System.Double value, Windows.Foundation.Diagnostics.LoggingFieldFormat format, System.Int32 tags)
-->

# Windows.Foundation.Diagnostics.LoggingFields.AddDouble

## -description
Adds a [Double](/dotnet/api/system.double?view=dotnet-uwp-10.0&preserve-view=true) field with the specified field name, format, and tags.

## -parameters
### -param name
Name of the event field.

### -param value
Value of the event field.

### -param format
The format of the event field. Specifies an optional formatting hint that may be used by Event Tracing for Windows (ETW) tools.

### -param tags
The user-defined tag for the event field. Specifies up to twenty-eight bits of user-defined field processing metadata for use by a custom ETW processing tool. The top four bits are reserved and must be set to zero (0).

## -remarks

## -examples

## -see-also
[AddDouble(String, Double)](loggingfields_adddouble_987115848.md), [AddDouble(String, Double, LoggingFieldFormat)](loggingfields_adddouble_1972292692.md)