---
-api-id: M:Windows.Foundation.Diagnostics.LoggingFields.AddBooleanArray(System.String,System.Boolean[],Windows.Foundation.Diagnostics.LoggingFieldFormat,System.Int32)
-api-type: winrt method
---

<!-- Method syntax
public void AddBooleanArray(System.String name, System.Boolean[] value, Windows.Foundation.Diagnostics.LoggingFieldFormat format, System.Int32 tags)
-->

# Windows.Foundation.Diagnostics.LoggingFields.AddBooleanArray

## -description
Adds a boolean array field with the specified field name, format, and tag.

## -parameters
### -param name
The name of the event field.

### -param value
The array of values for the event field.

### -param format
The format of the event field. Specifies an optional formatting hint that may be used by Event Tracing for Windows (ETW) tools.

### -param tags
The user-defined tag for the event field. Specifies up to twenty-eight bits of user-defined field processing metadata for use by a custom ETW processing tool. The top four bits are reserved and must be set to zero (0).

## -remarks

## -examples

## -see-also
[AddBooleanArray(String, Boolean\[\])](/uwp/api/windows.foundation.diagnostics.loggingfields.addbooleanarray#windows-foundation-diagnostics-loggingfields-addbooleanarray(system-string-system-boolean())), [AddBooleanArray(String, Boolean\[\], LoggingFieldFormat)](/uwp/api/windows.foundation.diagnostics.loggingfields.addbooleanarray#windows-foundation-diagnostics-loggingfields-addbooleanarray(system-string-system-boolean()-windows-foundation-diagnostics-loggingfieldformat))