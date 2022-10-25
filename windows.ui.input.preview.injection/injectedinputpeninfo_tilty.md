---
-api-id: P:Windows.UI.Input.Preview.Injection.InjectedInputPenInfo.TiltY
-api-type: winrt property
---

<!-- Property syntax
public int TiltY { get;  set; }
-->

# Windows.UI.Input.Preview.Injection.InjectedInputPenInfo.TiltY

## -description
Gets or sets the angle of tilt of the pointer along the y-axis.

## -property-value
The angle of tilt of the pointer along the y-axis in a range of -90 to +90, with a positive value indicating a tilt toward the user. The default is 0.

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
