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
> The [Timestamp](/uwp/api/windows.gaming.input.gamepadreading?branch=rs3.Timestamp) value is replaced with the current time of input injection.

## -remarks

> [!Important]
> The APIs in this namespace require the inputInjectionBrokered [restricted capability](/windows/uwp/packaging/app-capability-declarations#restricted-capabilities).

Using input injection requires the following be added to the Package.appxmanifest:

- To `<Package>`
    - `xmlns:rescap="http://schemas.microsoft.com/appx/manifest/foundation/windows10/restrictedcapabilities"`
    - `IgnorableNamespaces="rescap"`
- To `<Capabilities>`
    - `<rescap:Capability Name="inputInjectionBrokered" />`

## -examples

Here are some downloadable samples demonstrating basic input and input injection:

- [Input injection sample (mouse to touch)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-input-injection-mouse-to-touch.zip)
- [Touch injection sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/411c271e537727d737a53fa2cbe99eaecac00cc0/Official%20Windows%20Platform%20Sample/Input%20Touch%20injection%20sample)
- [Input: XAML user input events sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/411c271e537727d737a53fa2cbe99eaecac00cc0/Official%20Windows%20Platform%20Sample/Input%20XAML%20user%20input%20events%20sample)

## -see-also

[InjectedInputGamepadInfo(GamepadReading)](/uwp/api/windows.ui.input.preview.injection.injectedinputgamepadinfo.-ctor), [Simulate user input through input injection](/windows/uwp/design/input/input-injection)
