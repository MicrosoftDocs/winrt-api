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
> The APIs in this namespace require the inputInjectionBrokered [restricted capability](/windows/uwp/packaging/app-capability-declarations#restricted-capabilities).

Using input injection requires the following be added to the Package.appxmanifest:

- To `<Package>`
    - `xmlns:rescap="http://schemas.microsoft.com/appx/manifest/foundation/windows10/restrictedcapabilities"`
    - `IgnorableNamespaces="rescap"`
- To `<Capabilities>`
    - `<rescap:Capability Name="inputInjectionBrokered" />`

Calling this method is analogous to connecting a physical gamepad, which also triggers a [GamepadAdded](/uwp/api/windows.gaming.input.gamepad.GamepadAdded) event.

A physical gamepad is assigned a persistent unique ID (see [NonRoamableId](../windows.gaming.input/rawgamecontroller_nonroamableid.md)) that does not change when the device is connected and disconnected. Similarly, a virtual gamepad created with InitializeGamepadInjection is also assigned a unique ID that persists across calls to UninitializeGamepadInjection and InitializeGamepadInjection for the same [InputInjector](inputinjector.md) instance.

## -examples

Here are some downloadable samples demonstrating basic input and input injection:

- [Input injection sample (mouse to touch)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-input-injection-mouse-to-touch.zip)
- [Touch injection sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/411c271e537727d737a53fa2cbe99eaecac00cc0/Official%20Windows%20Platform%20Sample/Input%20Touch%20injection%20sample)
- [Input: XAML user input events sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/411c271e537727d737a53fa2cbe99eaecac00cc0/Official%20Windows%20Platform%20Sample/Input%20XAML%20user%20input%20events%20sample)

## -see-also

[UninitializeGamepadInjection](inputinjector_uninitializegamepadinjection_370962456.md), [Simulate user input through input injection](/windows/uwp/design/input/input-injection)
