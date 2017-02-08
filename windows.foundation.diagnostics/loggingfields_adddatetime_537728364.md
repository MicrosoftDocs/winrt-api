---
-api-id: M:Windows.Foundation.Diagnostics.LoggingFields.AddDateTime(System.String,Windows.Foundation.DateTime,Windows.Foundation.Diagnostics.LoggingFieldFormat,System.Int32)
-api-type: winrt method
---

<!-- Method syntax
public void AddDateTime(System.String name, Windows.Foundation.DateTime value, Windows.Foundation.Diagnostics.LoggingFieldFormat format, System.Int32 tags)
-->

# Windows.Foundation.Diagnostics.LoggingFields.AddDateTime

## -description
Adds a [DateTime](../windows.foundation/datetime.md) field with the specified field name, format, and tags.

## -parameters
### -param name
The name of the event field.

### -param value
The value of the event field.

### -param format
The format of the event field. Specifies an optional formatting hint that may be used by Event Tracing for Windows (ETW) tools.

### -param tags
The user-defined tag for the event field. Specifies up to twenty-eight bits of user-defined field processing metadata for use by a custom ETW processing tool. The top four bits are reserved and must be set to zero (0).

## -remarks

## -examples

## -see-also
[AddDateTime(String, DateTime)](loggingfields_adddatetime_1251332688.md), [AddDateTime(String, DateTime, LoggingFieldFormat)](loggingfields_adddatetime_97333076.md)