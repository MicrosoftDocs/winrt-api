---
-api-id: M:Windows.Foundation.Metadata.ActivatableAttribute.#ctor(System.UInt32)
-api-type: winrt method
---

<!-- Method syntax
public ActivatableAttribute(System.UInt32 version)
-->

# Windows.Foundation.Metadata.ActivatableAttribute.ActivatableAttribute

## -description
Indicates that the runtime class can be activated with no parameters, starting in a particular version.

## -parameters
### -param version
The minimum version that can activate the runtime class with no parameters.

## -remarks
Developers can choose any versioning system they wish, provided the version number always increases. For more details, see [Versioning](https://github.com/microsoft/xlang/blob/master/docs/xplatwinrt/XSPEC01%20-%20Type%20System%20Specification.md#versioning) in the Microsoft cross-language type system specification.

Activation with no parameters is performed by [the RoActivateInstance function](/windows/desktop/api/roapi/nf-roapi-roactivateinstance).

## -examples

## -see-also

[ActivatableAttribute(Type, UInt32, Platform)](activatableattribute_activatableattribute_708913573.md),
[ActivatableAttribute(Type, UInt32)](activatableattribute_activatableattribute_810136521.md),
[ActivatableAttribute(Type, UInt32, Type](activatableattribute_activatableattribute_847127659.md),
[ActivatableAttribute(UInt32, Type](activatableattribute_activatableattribute_903024379.md),
[ActivatableAttribute(UInt32, Platform)](activatableattribute_activatableattribute_1177778147.md),
[ActivatableAttribute(Type, UInt32, String)](activatableattribute_activatableattribute_1447974729.md),
[ActivatableAttribute(UInt32, String)](activatableattribute_activatableattribute_2016725141.md)
