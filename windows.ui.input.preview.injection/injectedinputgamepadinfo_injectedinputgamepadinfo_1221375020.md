---
-api-id: M:Windows.UI.Input.Preview.Injection.InjectedInputGamepadInfo.#ctor
-api-type: winrt method
---

<!-- Method syntax.
public InjectedInputGamepadInfo.InjectedInputGamepadInfo()
-->

# Windows.UI.Input.Preview.Injection.InjectedInputGamepadInfo.InjectedInputGamepadInfo

## -description
Creates a new [InjectedInputGamepadInfo](injectedinputgamepadinfo.md) object that is used to specify the gamepad input to inject.

## -remarks
Using input injection requires the following be added to the Package.appxmanifest:

- To `<Package>`
    - `xmlns:rescap="http://schemas.microsoft.com/appx/manifest/foundation/windows10/restrictedcapabilities"`
    - `IgnorableNamespaces="rescap"`
- To `<Capabilities>`
    - `<rescap:Capability Name="inputInjectionBrokered" />`


## -see-also
- [InjectedInputGamepadInfo(GamepadReading reading)](injectedinputgamepadinfo_injectedinputgamepadinfo_1221375020.md)

## -examples

