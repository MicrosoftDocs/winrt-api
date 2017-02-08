---
-api-id: M:Windows.Foundation.Diagnostics.LoggingFields.AddUInt64(System.String,System.UInt64,Windows.Foundation.Diagnostics.LoggingFieldFormat,System.Int32)
-api-type: winrt method
---

<!-- Method syntax
public void AddUInt64(System.String name, System.UInt64 value, Windows.Foundation.Diagnostics.LoggingFieldFormat format, System.Int32 tags)
-->

# Windows.Foundation.Diagnostics.LoggingFields.AddUInt64

## -description
Adds a 64-bit unsigned integer field with the specified field name, format, and tags.

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
[AddUInt64(String, UInt64)](loggingfields_adduint64_1955490145.md), [AddUInt64(String, UInt64, LoggingFieldFormat)](loggingfields_adduint64_1003918459.md)