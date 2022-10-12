---
-api-id: M:Windows.Foundation.Diagnostics.LoggingFields.AddPointArray(System.String,Windows.Foundation.Point[],Windows.Foundation.Diagnostics.LoggingFieldFormat,System.Int32)
-api-type: winrt method
---

<!-- Method syntax
public void AddPointArray(System.String name, Windows.Foundation.Point[] value, Windows.Foundation.Diagnostics.LoggingFieldFormat format, System.Int32 tags)
-->

# Windows.Foundation.Diagnostics.LoggingFields.AddPointArray

## -description
Adds a [Point](../windows.foundation/point.md) array field with the specified field name, format, and tags.

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
[AddPointArray(String, Point\[\])](/uwp/api/windows.foundation.diagnostics.loggingfields.addpointarray#windows-foundation-diagnostics-loggingfields-addpointarray(system-string-windows-foundation-point())), [AddPointArray(String, Point\[\], LoggingFieldFormat)](/uwp/api/windows.foundation.diagnostics.loggingfields.addpointarray#windows-foundation-diagnostics-loggingfields-addpointarray(system-string-windows-foundation-point()-windows-foundation-diagnostics-loggingfieldformat))