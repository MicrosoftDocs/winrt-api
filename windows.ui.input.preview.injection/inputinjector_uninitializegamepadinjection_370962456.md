---
-api-id: M:Windows.UI.Input.Preview.Injection.InputInjector.UninitializeGamepadInjection
-api-type: winrt method
---

<!-- Method syntax.
public void InputInjector.UninitializeGamepadInjection()
-->

# Windows.UI.Input.Preview.Injection.InputInjector.UninitializeGamepadInjection

## -description
Shuts down the virtual gamepad device created with [InitializeGamepadInjection](inputinjector_initializegamepadinjection_1113833135.md).

> [!NOTE]
> The APIs in this namespace require the inputInjectionBrokered [restricted capability](https://docs.microsoft.com/windows/uwp/packaging/app-capability-declarations#special-and-restricted-capabilities).

## -remarks
Using input injection requires the following be added to the Package.appxmanifest:

- To `<Package>`
    - `xmlns:rescap="http://schemas.microsoft.com/appx/manifest/foundation/windows10/restrictedcapabilities"`
    - `IgnorableNamespaces="rescap"`
- To `<Capabilities>`
    - `<rescap:Capability Name="inputInjectionBrokered" />`

Calling this method is analogous to disconnecting a physical gamepad, which also triggers a [GamepadRemoved](https://docs.microsoft.com/uwp/api/windows.gaming.input.gamepad.GamepadRemoved) event.

A physical gamepad is assigned a persistent unique ID (see [NonRoamableId](..\windows.gaming.input\rawgamecontroller_nonroamableid.md)) that does not change when the device is connected and disconnected. Similarly, a virtual gamepad created with [InitializeGamepadInjection](inputinjector_initializegamepadinjection_1113833135.md) is also assigned a unique ID that persists across calls to [UninitializeGamepadInjection](inputinjector_initializegamepadinjection_1113833135.md) and [InitializeGamepadInjection](inputinjector_initializegamepadinjection_1113833135.md) for the same [InputInjector](inputinjector.md) instance.

## -examples

## -see-also
- [InitializeGamepadInjection](inputinjector_initializegamepadinjection_1113833135.md)

