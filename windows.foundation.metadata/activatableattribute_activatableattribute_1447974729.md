---
-api-id: M:Windows.Foundation.Metadata.ActivatableAttribute.#ctor(System.Type,System.UInt32,System.String)
-api-type: winrt method
---

<!-- Method syntax
public ActivatableAttribute(System.Type type, System.UInt32 version, System.String contractName)
-->

# Windows.Foundation.Metadata.ActivatableAttribute.ActivatableAttribute

## -description
Indicates that the runtime class can be activated with parameters, starting in a particular version of a particular API contract.

## -parameters
### -param type
The type of the interface that is used to activate objects.

### -param version
The minimum version of the API contract that can activate the runtime class with the specified interface. The major version is in the high-order 16-bits and the minor version is in the low-order 16 bits.

### -param contractName
The name of the API contract that can activate the runtime class with the specified interface.

## -remarks

## -examples

## -see-also
[ActivatableAttribute(Type, UInt32)](activatableattribute_activatableattribute_810136521.md),
[ActivatableAttribute(UInt32)](activatableattribute_activatableattribute_885572907.md),
[ActivatableAttribute(UInt32, String)](activatableattribute_activatableattribute_2016725141.md)
