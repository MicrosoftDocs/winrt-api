---
-api-id: M:Windows.Foundation.Diagnostics.LoggingFields.AddSize(System.String,Windows.Foundation.Size,Windows.Foundation.Diagnostics.LoggingFieldFormat,System.Int32)
-api-type: winrt method
---

<!-- Method syntax
public void AddSize(System.String name, Windows.Foundation.Size value, Windows.Foundation.Diagnostics.LoggingFieldFormat format, System.Int32 tags)
-->

# Windows.Foundation.Diagnostics.LoggingFields.AddSize

## -description
Adds a [Size](../windows.foundation/size.md) field with the specified field name, format, and tags.

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
[AddSize(String, Size)](loggingfields_addsize_1503205063.md), [AddSize(String, Size, LoggingFieldFormat)](loggingfields_addsize_381807581.md)