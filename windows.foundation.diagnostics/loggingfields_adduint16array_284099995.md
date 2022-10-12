---
-api-id: M:Windows.Foundation.Diagnostics.LoggingFields.AddUInt16Array(System.String,System.UInt16[],Windows.Foundation.Diagnostics.LoggingFieldFormat,System.Int32)
-api-type: winrt method
---

<!-- Method syntax
public void AddUInt16Array(System.String name, System.UInt16[] value, Windows.Foundation.Diagnostics.LoggingFieldFormat format, System.Int32 tags)
-->

# Windows.Foundation.Diagnostics.LoggingFields.AddUInt16Array

## -description
Adds a 16-bit unsigned integer array field with the specified field name, format, and tags.

## -parameters
### -param name
Name of the event field.

### -param value
The value for the event field. The default format for the array is binary. See the remarks section for other formats that may be specified.

### -param format
The format of the event field. Specifies an optional formatting hint that may be used by Event Tracing for Windows (ETW) tools.

### -param tags
The user-defined tag for the event field. Specifies up to twenty-eight bits of user-defined field processing metadata for use by a custom ETW processing tool. The top four bits are reserved and must be set to zero (0).

## -remarks

## -examples

## -see-also
[AddUInt16Array(String, UInt16\[\])](/uwp/api/windows.foundation.diagnostics.loggingfields.adduint16array#windows-foundation-diagnostics-loggingfields-adduint16array(system-string-system-uint16())), [AddUInt16Array(String, UInt16\[\], LoggingFieldFormat)](/uwp/api/windows.foundation.diagnostics.loggingfields.adduint16array#windows-foundation-diagnostics-loggingfields-adduint16array(system-string-system-uint16()-windows-foundation-diagnostics-loggingfieldformat))