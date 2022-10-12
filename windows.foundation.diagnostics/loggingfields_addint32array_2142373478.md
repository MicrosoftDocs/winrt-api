---
-api-id: M:Windows.Foundation.Diagnostics.LoggingFields.AddInt32Array(System.String,System.Int32[],Windows.Foundation.Diagnostics.LoggingFieldFormat,System.Int32)
-api-type: winrt method
---

<!-- Method syntax
public void AddInt32Array(System.String name, System.Int32[] value, Windows.Foundation.Diagnostics.LoggingFieldFormat format, System.Int32 tags)
-->

# Windows.Foundation.Diagnostics.LoggingFields.AddInt32Array

## -description
Adds a 32-bit integer array field with the specified field name, format, and tags.

## -parameters
### -param name
Name of the event field.

### -param value
The array values for the event field.

### -param format
The format of the event field. Specifies an optional formatting hint that may be used by Event Tracing for Windows (ETW) tools.

### -param tags
The user-defined tag for the event field. Specifies up to twenty-eight bits of user-defined field processing metadata for use by a custom ETW processing tool. The top four bits are reserved and must be set to zero (0).

## -remarks

## -examples

## -see-also
[AddInt32Array(String, Int32\[\])](/uwp/api/windows.foundation.diagnostics.loggingfields.addint32array#windows-foundation-diagnostics-loggingfields-addint32array(system-string-system-int32())), [AddInt32Array(String, Int32\[\], LoggingFieldFormat)](/uwp/api/windows.foundation.diagnostics.loggingfields.addint32array#windows-foundation-diagnostics-loggingfields-addint32array(system-string-system-int32()-windows-foundation-diagnostics-loggingfieldformat))