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
The class does not implement [IMarshal](/windows/desktop/api/objidl/nn-objidl-imarshal) or forwards to [CoGetStandardMarshal](/windows/desktop/api/combaseapi/nf-combaseapi-cogetstandardmarshal) on all interfaces.

### -field InvalidMarshaling:0
The class can't be marshaled.


## -remarks

## -examples

## -see-also
[MarshalingBehaviorAttribute.MarshalingBehaviorAttribute](marshalingbehaviorattribute_marshalingbehaviorattribute_1487269172.md)