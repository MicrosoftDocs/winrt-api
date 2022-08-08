---
-api-id: M:Windows.Foundation.Diagnostics.LoggingFields.AddRectArray(System.String,Windows.Foundation.Rect[],Windows.Foundation.Diagnostics.LoggingFieldFormat,System.Int32)
-api-type: winrt method
---

<!-- Method syntax
public void AddRectArray(System.String name, Windows.Foundation.Rect[] value, Windows.Foundation.Diagnostics.LoggingFieldFormat format, System.Int32 tags)
-->

# Windows.Foundation.Diagnostics.LoggingFields.AddRectArray

## -description
Adds a [Rect](../windows.foundation/rect.md) array field with the specified field name, format, and tags.

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
[AddRectArray(String, Rect\[\])](/uwp/api/windows.foundation.diagnostics.loggingfields.addrectarray#windows-foundation-diagnostics-loggingfields-addrectarray(system-string-windows-foundation-rect())), [AddRectArray(String, Rect\[\], LoggingFieldFormat)](/uwp/api/windows.foundation.diagnostics.loggingfields.addrectarray#windows-foundation-diagnostics-loggingfields-addrectarray(system-string-windows-foundation-rect()-windows-foundation-diagnostics-loggingfieldformat))