---
-api-id: M:Windows.Foundation.Diagnostics.LoggingFields.AddInt16(System.String,System.Int16,Windows.Foundation.Diagnostics.LoggingFieldFormat,System.Int32)
-api-type: winrt method
---

<!-- Method syntax
public void AddInt16(System.String name, System.Int16 value, Windows.Foundation.Diagnostics.LoggingFieldFormat format, System.Int32 tags)
-->

# Windows.Foundation.Diagnostics.LoggingFields.AddInt16

## -description
Adds a 16-bit integer field with the specified field name, format, and tags.

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
[AddInt16(String, Int16)](loggingfields_addint16_512538978.md), [AddInt16(String, Int16, LoggingFieldFormat)](loggingfields_addint16_1372865658.md)