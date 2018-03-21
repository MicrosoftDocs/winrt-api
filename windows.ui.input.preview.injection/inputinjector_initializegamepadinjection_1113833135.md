---
-api-id: M:Windows.UI.Input.Preview.Injection.InputInjector.InitializeGamepadInjection
-api-type: winrt method
---

<!-- Method syntax.
public void InputInjector.InitializeGamepadInjection()
-->

# Windows.UI.Input.Preview.Injection.InputInjector.InitializeGamepadInjection

## -description
Initializes a virtual gamepad device that can synthesize input events and provide corresponding input data to the system. 

> [!NOTE]
> The APIs in this namespace require the inputInjectionBrokered [restricted capability](https://docs.microsoft.com/windows/uwp/packaging/app-capability-declarations#special-and-restricted-capabilities).

## -remarks
Using input injection requires the following be added to the Package.appxmanifest:

- To `<Package>`
    - `xmlns:rescap="http://schemas.microsoft.com/appx/manifest/foundation/windows10/restrictedcapabilities"`
    - `IgnorableNamespaces="rescap"`
- To `<Capabilities>`
    - `<rescap:Capability Name="inputInjectionBrokered" />`

Calling this method is analogous to connecting a physical gamepad, which also triggers a [GamepadAdded](https://docs.microsoft.com/uwp/api/windows.gaming.input.gamepad.GamepadAdded) event.

A physical gamepad is assigned a persistent unique ID (see [NonRoamableId](..\windows.gaming.input\rawgamecontroller_nonroamableid.md)) that does not change when the device is connected and disconnected. Similarly, a virtual gamepad created with [InitializeGamepadInjection](inputinjector_initializegamepadinjection_1113833135.md) is also assigned a unique ID that persists across calls to [UninitializeGamepadInjection](inputinjector_initializegamepadinjection_1113833135.md) and [InitializeGamepadInjection](inputinjector_initializegamepadinjection_1113833135.md) for the same [InputInjector](inputinjector.md) instance.

## -examples

## -see-also
- [UninitializeGamepadInjection](inputinjector_uninitializegamepadinjection_370962456.md)


