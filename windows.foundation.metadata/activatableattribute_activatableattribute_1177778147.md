---
-api-id: M:Windows.Foundation.Metadata.ActivatableAttribute.#ctor(System.UInt32,Windows.Foundation.Metadata.Platform)
-api-type: winrt method
---

<!-- Method syntax
public ActivatableAttribute(System.UInt32 version, Windows.Foundation.Metadata.Platform platform)
-->

# Windows.Foundation.Metadata.ActivatableAttribute.ActivatableAttribute

## -description
Indicates that the runtime class can be activated with no parameters, starting in a particular version of a particular platform.

## -parameters
### -param version
The minimum version of the platform that can activate the runtime class with no parameters.

### -param platform
The platform that can activate the runtime class with no parameters.

## -remarks
This version of the `ActivatableAttribute` constructor is obsolete.

Activation with no parameters is performed by [the RoActivateInstance function](/windows/desktop/api/roapi/nf-roapi-roactivateinstance).

## -examples

## -see-also

[ActivatableAttribute(Type, UInt32, Platform)](activatableattribute_activatableattribute_708913573.md),
[ActivatableAttribute(Type, UInt32)](activatableattribute_activatableattribute_810136521.md),
[ActivatableAttribute(Type, UInt32, Type](activatableattribute_activatableattribute_847127659.md),
[ActivatableAttribute(UInt32)](activatableattribute_activatableattribute_885572907.md),
[ActivatableAttribute(UInt32, Type](activatableattribute_activatableattribute_903024379.md),
[ActivatableAttribute(Type, UInt32, String)](activatableattribute_activatableattribute_1447974729.md),
[ActivatableAttribute(UInt32, String)](activatableattribute_activatableattribute_2016725141.md)
