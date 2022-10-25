---
-api-id: P:Windows.UI.Input.Preview.Injection.InjectedInputTouchInfo.Orientation
-api-type: winrt property
---

<!-- Property syntax
public int Orientation { get;  set; }
-->

# Windows.UI.Input.Preview.Injection.InjectedInputTouchInfo.Orientation

## -description
Gets or sets the counter-clockwise angle of rotation around the major axis of the pointer device (the z-axis, perpendicular to the surface of the digitizer).

## -property-value
The pointer orientation, with a value between 0 and 359, where 0 indicates a touch pointer aligned with the x-axis and pointing from left to right; increasing values indicate degrees of rotation in the counter-clockwise direction. The default is 0.

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

[Simulate user input through input injection](/windows/uwp/design/input/input-injection)
