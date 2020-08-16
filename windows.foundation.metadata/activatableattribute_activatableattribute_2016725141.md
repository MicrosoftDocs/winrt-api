---
-api-id: M:Windows.Foundation.Metadata.ActivatableAttribute.#ctor(System.UInt32,System.String)
-api-type: winrt method
---

<!-- Method syntax
public ActivatableAttribute(System.UInt32 version, System.String type)
-->

# Windows.Foundation.Metadata.ActivatableAttribute.ActivatableAttribute

## -description
Indicates that the runtime class can be activated with no parameters, starting in a particular version of a particular API contract.

## -parameters
### -param version
The version of the API contract that can activate the runtime class with no parameters. The major version is in the high-order 16-bits and the minor version is in the low-order 16 bits.

### -param type
The name of the API contract that can activate the runtime class with no parameters.
(This parameter should have been named `contractName`.)

## -remarks
Activation with no parameters is performed by [the RoActivateInstance function](https://docs.microsoft.com/en-us/windows/desktop/api/roapi/nf-roapi-roactivateinstance).

## -examples

## -see-also
[ActivatableAttribute(Type, UInt32)](activatableattribute_activatableattribute_810136521.md),
[ActivatableAttribute(Type, UInt32, String)](activatableattribute_activatableattribute_1447974729.md),
[ActivatableAttribute(UInt32)](activatableattribute_activatableattribute_885572907.md),
[ActivatableAttribute(UInt32, String)](activatableattribute_activatableattribute_2016725141.md)
