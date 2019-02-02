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

## -remarks

> [!Important]
> The APIs in this namespace require the inputInjectionBrokered [restricted capability](https://docs.microsoft.com/windows/uwp/packaging/app-capability-declarations#special-and-restricted-capabilities).

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

### Reference

[UninitializeGamepadInjection](inputinjector_uninitializegamepadinjection_370962456.md)

### Conceptual

[Gaze interactions and eye tracking in UWP apps](https://docs.microsoft.com/windows/uwp/design/input/gaze-interactions)

### Samples

- [Simulate user input through input injection](https://review.docs.microsoft.com/windows/uwp/design/input/input-injection?branch=kbridge-inputinjection)
- [Input injection sample (mouse to touch)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-input-injection-mouse-to-touch.zip)
- [Touch injection sample](https://go.microsoft.com/fwlink/p/?LinkID=267906)
- [Input: XAML user input events sample](https://go.microsoft.com/fwlink/p/?linkid=226855)
