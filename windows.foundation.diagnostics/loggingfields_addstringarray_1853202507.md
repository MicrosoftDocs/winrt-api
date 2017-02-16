---
-api-id: M:Windows.Foundation.Diagnostics.LoggingFields.AddStringArray(System.String,System.String[],Windows.Foundation.Diagnostics.LoggingFieldFormat,System.Int32)
-api-type: winrt method
---

<!-- Method syntax
public void AddStringArray(System.String name, System.String[] value, Windows.Foundation.Diagnostics.LoggingFieldFormat format, System.Int32 tags)
-->

# Windows.Foundation.Diagnostics.LoggingFields.AddStringArray

## -description
Adds a [String](https://msdn.microsoft.com/library/system.string.aspx) array field with the specified field name, format, and tags.

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
[AddStringArray(String, String[])](loggingfields_addstringarray_82667375.md), [AddStringArray(String, String[], LoggingFieldFormat)](loggingfields_addstringarray_1270192757.md)