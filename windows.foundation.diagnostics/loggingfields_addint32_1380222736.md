---
-api-id: M:Windows.Foundation.Diagnostics.LoggingFields.AddInt32(System.String,System.Int32,Windows.Foundation.Diagnostics.LoggingFieldFormat,System.Int32)
-api-type: winrt method
---

<!-- Method syntax
public void AddInt32(System.String name, System.Int32 value, Windows.Foundation.Diagnostics.LoggingFieldFormat format, System.Int32 tags)
-->

# Windows.Foundation.Diagnostics.LoggingFields.AddInt32

## -description
Adds a 32-bit integer array field with the specified field name, format, and tags.

## -parameters
### -param name
Name of the event field.

### -param value
The array values for the event field.

### -param format
The format of the event field. Specifies an optional formatting hint that may be used by Event Tracing for Windows (ETW) tools.

### -param tags
The user-defined tag for the event field. Specifies up to twenty-eight bits of user-defined field processing metadata for use by a custom ETW processing tool. The top four bits are reserved and must be set to zero (0).

## -remarks

## -examples

## -see-also
[AddInt32(String, Int32)](loggingfields_addint32_953958444.md), [AddInt32(String, Int32, LoggingFieldFormat)](loggingfields_addint32_2005187888.md)