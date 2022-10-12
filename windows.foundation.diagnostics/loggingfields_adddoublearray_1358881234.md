---
-api-id: M:Windows.Foundation.Diagnostics.LoggingFields.AddDoubleArray(System.String,System.Double[],Windows.Foundation.Diagnostics.LoggingFieldFormat,System.Int32)
-api-type: winrt method
---

<!-- Method syntax
public void AddDoubleArray(System.String name, System.Double[] value, Windows.Foundation.Diagnostics.LoggingFieldFormat format, System.Int32 tags)
-->

# Windows.Foundation.Diagnostics.LoggingFields.AddDoubleArray

## -description
Adds a [Double](/dotnet/api/system.double?view=dotnet-uwp-10.0&preserve-view=true) array field with the specified field name, format, and tags.

## -parameters
### -param name
Name of the event field.

### -param value
The array of values for the event field.

### -param format
The format of the event field. Specifies an optional formatting hint that may be used by Event Tracing for Windows (ETW) tools.

### -param tags
The user-defined tag for the event field. Specifies up to twenty-eight bits of user-defined field processing metadata for use by a custom ETW processing tool. The top four bits are reserved and must be set to zero (0).

## -remarks

## -examples

## -see-also
[AddDoubleArray(String, Double\[\])](/uwp/api/windows.foundation.diagnostics.loggingfields.adddoublearray#windows-foundation-diagnostics-loggingfields-adddoublearray(system-string-system-double())), [AddDoubleArray(String, Double\[\], LoggingFieldFormat)](/uwp/api/windows.foundation.diagnostics.loggingfields.adddoublearray#windows-foundation-diagnostics-loggingfields-adddoublearray(system-string-system-double()-windows-foundation-diagnostics-loggingfieldformat))