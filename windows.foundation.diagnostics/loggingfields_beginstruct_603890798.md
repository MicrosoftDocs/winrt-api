---
-api-id: M:Windows.Foundation.Diagnostics.LoggingFields.BeginStruct(System.String,System.Int32)
-api-type: winrt method
---

<!-- Method syntax
public void BeginStruct(System.String name, System.Int32 tags)
-->

# Windows.Foundation.Diagnostics.LoggingFields.BeginStruct

## -description
Begins a new structured field with the specified field name and tags.

## -parameters
### -param name
Name of the structured field.

### -param tags
Specifies up to twenty-eight bits of user-defined field metadata. The top four bits are reserved and must be set to zero (0).The metadata may be used by a custom Event Tracing for Windows (ETW) processing tool. For example, you might define a tag that indicates that a field might contain personally-identifiable information.

## -remarks

## -examples

## -see-also
[BeginStruct(String)](loggingfields_beginstruct_359748894.md), [EndStruct](loggingfields_endstruct_494341079.md)