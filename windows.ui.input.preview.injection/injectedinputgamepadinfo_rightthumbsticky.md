---
-api-id: P:Windows.UI.Input.Preview.Injection.InjectedInputGamepadInfo.RightThumbstickY
-api-type: winrt property
---

<!-- Property syntax.
public double RightThumbstickY { get;  set; }
-->

# Windows.UI.Input.Preview.Injection.InjectedInputGamepadInfo.RightThumbstickY

## -description
Gets or sets the position of the right stick on the Y-axis. 

## -property-value
A value between -1.0 (pressed towards the user) and 1.0 (pressed away from the user).

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
