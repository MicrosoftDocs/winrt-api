---
-api-id: M:Windows.Foundation.Diagnostics.LoggingFields.AddBoolean(System.String,System.Boolean,Windows.Foundation.Diagnostics.LoggingFieldFormat,System.Int32)
-api-type: winrt method
---

<!-- Method syntax
public void AddBoolean(System.String name, System.Boolean value, Windows.Foundation.Diagnostics.LoggingFieldFormat format, System.Int32 tags)
-->

# Windows.Foundation.Diagnostics.LoggingFields.AddBoolean

## -description
Adds a boolean field with the specified field name, format, and tags.

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
[AddBoolean(String, Boolean)](loggingfields_addboolean_974707982.md), [AddBoolean(String, Boolean, LoggingFieldFormat)](loggingfields_addboolean_1967136790.md)