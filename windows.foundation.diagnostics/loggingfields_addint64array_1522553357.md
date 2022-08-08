---
-api-id: M:Windows.Foundation.Diagnostics.LoggingFields.AddInt64Array(System.String,System.Int64[],Windows.Foundation.Diagnostics.LoggingFieldFormat,System.Int32)
-api-type: winrt method
---

<!-- Method syntax
public void AddInt64Array(System.String name, System.Int64[] value, Windows.Foundation.Diagnostics.LoggingFieldFormat format, System.Int32 tags)
-->

# Windows.Foundation.Diagnostics.LoggingFields.AddInt64Array

## -description
Adds a 64-bit integer array field with the specified field name, format, and tags.

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
[AddInt64Array(String, Int64\[\])](/uwp/api/windows.foundation.diagnostics.loggingfields.addint64array#windows-foundation-diagnostics-loggingfields-addint64array(system-string-system-int64())), [AddInt64Array(String, Int64\[\], LoggingFieldFormat)](/uwp/api/windows.foundation.diagnostics.loggingfields.addint64array#windows-foundation-diagnostics-loggingfields-addint64array(system-string-system-int64()-windows-foundation-diagnostics-loggingfieldformat))