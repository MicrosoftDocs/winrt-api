---
-api-id: T:Windows.Foundation.Metadata.MarshalingType
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Foundation.Metadata.MarshalingType : int
-->

# MarshalingType

## -description
Specifies the marshaling type for the class.

## -enum-fields
### -field None:1
The class prevents marshaling on all interfaces.

### -field Agile:2
The class marshals and unmarshals to the same pointer value on all interfaces.

### -field Standard:3
The class does not implement [IMarshal](http://msdn.microsoft.com/library/e6f08949-f27d-4aba-adff-eaf9c356a928) or forwards to [CoGetStandardMarshal](http://msdn.microsoft.com/library/0cb74adc-e192-4ae5-9267-02c79e301681) on all interfaces.

### -field InvalidMarshaling:0
The class can't be marshaled.


## -remarks

## -examples

## -see-also
[MarshalingBehaviorAttribute.MarshalingBehaviorAttribute](marshalingbehaviorattribute_marshalingbehaviorattribute.md)