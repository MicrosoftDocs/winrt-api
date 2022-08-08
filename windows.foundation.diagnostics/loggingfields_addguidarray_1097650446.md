---
-api-id: M:Windows.Foundation.Diagnostics.LoggingFields.AddGuidArray(System.String,System.Guid[],Windows.Foundation.Diagnostics.LoggingFieldFormat,System.Int32)
-api-type: winrt method
---

<!-- Method syntax
public void AddGuidArray(System.String name, System.Guid[] value, Windows.Foundation.Diagnostics.LoggingFieldFormat format, System.Int32 tags)
-->

# Windows.Foundation.Diagnostics.LoggingFields.AddGuidArray

## -description
Adds a [GUID](/windows/win32/api/guiddef/ns-guiddef-guid) array field with the specified field name, format, and tags.

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
[AddGuidArray(String, Guid\[\])](/uwp/api/windows.foundation.diagnostics.loggingfields.addguidarray#windows-foundation-diagnostics-loggingfields-addguidarray(system-string-system-guid())), [AddGuidArray(String, Guid\[\], LoggingFieldFormat)](/uwp/api/windows.foundation.diagnostics.loggingfields.addguidarray#windows-foundation-diagnostics-loggingfields-addguidarray(system-string-system-guid()-windows-foundation-diagnostics-loggingfieldformat))