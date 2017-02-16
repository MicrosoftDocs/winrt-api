---
-api-id: M:Windows.Foundation.Diagnostics.LoggingFields.AddInt64(System.String,System.Int64,Windows.Foundation.Diagnostics.LoggingFieldFormat,System.Int32)
-api-type: winrt method
---

<!-- Method syntax
public void AddInt64(System.String name, System.Int64 value, Windows.Foundation.Diagnostics.LoggingFieldFormat format, System.Int32 tags)
-->

# Windows.Foundation.Diagnostics.LoggingFields.AddInt64

## -description
Adds a 64-bit integer field with the specified field name, format, and tags.

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
[AddInt64(String, Int64)](loggingfields_addint64_79905645.md), [AddInt64(String, Int64, LoggingFieldFormat)](loggingfields_addint64_1268498039.md)