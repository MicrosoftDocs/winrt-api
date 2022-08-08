---
-api-id: M:Windows.Foundation.Diagnostics.LoggingFields.AddChar16Array(System.String,System.Char[],Windows.Foundation.Diagnostics.LoggingFieldFormat,System.Int32)
-api-type: winrt method
---

<!-- Method syntax
public void AddChar16Array(System.String name, System.Char[] value, Windows.Foundation.Diagnostics.LoggingFieldFormat format, System.Int32 tags)
-->

# Windows.Foundation.Diagnostics.LoggingFields.AddChar16Array

## -description
Adds a 16-bit character array field with the specified field name and format, and tags.

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
[AddChar16Array(String, Char\[\])](/uwp/api/windows.foundation.diagnostics.loggingfields.addchar16array#windows-foundation-diagnostics-loggingfields-addchar16array(system-string-system-char())), [AddChar16Array(String, Char\[\], LoggingFieldFormat)](/uwp/api/windows.foundation.diagnostics.loggingfields.addchar16array#windows-foundation-diagnostics-loggingfields-addchar16array(system-string-system-char()-windows-foundation-diagnostics-loggingfieldformat))