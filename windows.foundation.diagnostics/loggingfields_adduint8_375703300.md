---
-api-id: M:Windows.Foundation.Diagnostics.LoggingFields.AddUInt8(System.String,System.Byte,Windows.Foundation.Diagnostics.LoggingFieldFormat,System.Int32)
-api-type: winrt method
---

<!-- Method syntax
public void AddUInt8(System.String name, System.Byte value, Windows.Foundation.Diagnostics.LoggingFieldFormat format, System.Int32 tags)
-->

# Windows.Foundation.Diagnostics.LoggingFields.AddUInt8

## -description
Adds an 8-bit unsigned integer field with the specified field name, format, and tags.

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
[AddUInt8(String, Byte)](loggingfields_adduint8_2096889896.md), [AddUInt8(String, Byte, LoggingFieldFormat)](loggingfields_adduint8_866450748.md)