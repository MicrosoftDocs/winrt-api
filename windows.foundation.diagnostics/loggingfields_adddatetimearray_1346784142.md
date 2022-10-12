---
-api-id: M:Windows.Foundation.Diagnostics.LoggingFields.AddDateTimeArray(System.String,Windows.Foundation.DateTime[],Windows.Foundation.Diagnostics.LoggingFieldFormat,System.Int32)
-api-type: winrt method
---

<!-- Method syntax
public void AddDateTimeArray(System.String name, Windows.Foundation.DateTime[] value, Windows.Foundation.Diagnostics.LoggingFieldFormat format, System.Int32 tags)
-->

# Windows.Foundation.Diagnostics.LoggingFields.AddDateTimeArray

## -description
Adds a [DateTime](../windows.foundation/datetime.md) array field with the specified field name, format, and tags.

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
[AddDateTimeArray(String, DateTime\[\])](/uwp/api/windows.foundation.diagnostics.loggingfields.adddatetimearray#windows-foundation-diagnostics-loggingfields-adddatetimearray(system-string-windows-foundation-datetime())), [AddDateTimeArray(String, DateTime\[\], LoggingFieldFormat)](/uwp/api/windows.foundation.diagnostics.loggingfields.adddatetimearray#windows-foundation-diagnostics-loggingfields-adddatetimearray(system-string-windows-foundation-datetime()-windows-foundation-diagnostics-loggingfieldformat))