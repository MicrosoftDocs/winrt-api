---
-api-id: M:Windows.UI.Input.Preview.Injection.InjectedInputGamepadInfo.#ctor(Windows.Gaming.Input.GamepadReading)
-api-type: winrt method
---

<!-- Method syntax.
public InjectedInputGamepadInfo.InjectedInputGamepadInfo(GamepadReading reading)
-->

# Windows.UI.Input.Preview.Injection.InjectedInputGamepadInfo.InjectedInputGamepadInfo

## -description
Creates a new [InjectedInputGamepadInfo](injectedinputgamepadinfo.md) object that is used to specify the gamepad input to inject based on the current state of the gamepad.

## -parameters
### -param reading
The current state of the gamepad.

> [!NOTE]
> The [Timestamp](https://docs.microsoft.com/uwp/api/windows.gaming.input.gamepadreading?branch=rs3#Windows_Gaming_Input_GamepadReading_Timestamp) value is replaced with the current time of input injection.

## -remarks
Using input injection requires the following be added to the Package.appxmanifest:

- To `<Package>`
    - `xmlns:rescap="http://schemas.microsoft.com/appx/manifest/foundation/windows10/restrictedcapabilities"`
    - `IgnorableNamespaces="rescap"`
- To `<Capabilities>`
    - `<rescap:Capability Name="inputInjectionBrokered" />`


## -see-also
- [InjectedInputGamepadInfo()](injectedinputgamepadinfo_injectedinputgamepadinfo_1221375020.md)

## -examples

