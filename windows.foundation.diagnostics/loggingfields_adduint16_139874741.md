---
-api-id: M:Windows.Foundation.Diagnostics.LoggingFields.AddUInt16(System.String,System.UInt16,Windows.Foundation.Diagnostics.LoggingFieldFormat,System.Int32)
-api-type: winrt method
---

<!-- Method syntax
public void AddUInt16(System.String name, System.UInt16 value, Windows.Foundation.Diagnostics.LoggingFieldFormat format, System.Int32 tags)
-->

# Windows.Foundation.Diagnostics.LoggingFields.AddUInt16

## -description
Adds a 16-bit unsigned integer field with the specified field name, format, and tags.



## -parameters
### -param name
Name of the event field.

### -param value
The value for the event field.

### -param format
The format of the event field. Specifies an optional formatting hint that may be used by Event Tracing for Windows (ETW) tools.

### -param tags
The user-defined tag for the event field. Specifies up to twenty-eight bits of user-defined field processing metadata for use by a custom ETW processing tool. The top four bits are reserved and must be set to zero (0).

## -remarks

## -examples

## -see-also
[AddUInt16(String, UInt16)](loggingfields_adduint16_1657706129.md), [AddUInt16(String, UInt16, LoggingFieldFormat)](loggingfields_adduint16_764832651.md)