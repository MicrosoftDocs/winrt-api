---
-api-id: M:Windows.Foundation.Diagnostics.LoggingFields.AddSingle(System.String,System.Single,Windows.Foundation.Diagnostics.LoggingFieldFormat,System.Int32)
-api-type: winrt method
---

<!-- Method syntax
public void AddSingle(System.String name, System.Single value, Windows.Foundation.Diagnostics.LoggingFieldFormat format, System.Int32 tags)
-->

# Windows.Foundation.Diagnostics.LoggingFields.AddSingle

## -description
Adds a [Single](/dotnet/api/system.single?view=dotnet-uwp-10.0&preserve-view=true) field with the specified field name, format, and tags.

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
[AddSingle(String, Single)](loggingfields_addsingle_425245129.md), [AddSingle(String, Single, LoggingFieldFormat)](loggingfields_addsingle_1442858195.md)