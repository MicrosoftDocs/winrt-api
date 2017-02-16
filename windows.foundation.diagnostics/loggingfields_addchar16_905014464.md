---
-api-id: M:Windows.Foundation.Diagnostics.LoggingFields.AddChar16(System.String,System.Char,Windows.Foundation.Diagnostics.LoggingFieldFormat,System.Int32)
-api-type: winrt method
---

<!-- Method syntax
public void AddChar16(System.String name, System.Char value, Windows.Foundation.Diagnostics.LoggingFieldFormat format, System.Int32 tags)
-->

# Windows.Foundation.Diagnostics.LoggingFields.AddChar16

## -description
Adds a 16-bit character field with the specified field name, format, and tag.

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
[AddChar16(String, Char)](loggingfields_addchar16_1600760804.md), [AddChar16(String, Char, LoggingFieldFormat)](loggingfields_addchar16_271668992.md)