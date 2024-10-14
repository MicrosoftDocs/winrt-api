---
-api-id: P:Windows.UI.Input.Preview.Injection.InjectedInputMouseInfo.DeltaY
-api-type: winrt property
---

<!-- Property syntax
public int DeltaY { get;  set; }
-->

# Windows.UI.Input.Preview.Injection.InjectedInputMouseInfo.DeltaY

## -description

Gets or sets the change in the y-coordinate value of the mouse cursor.

## -property-value

The change in the y-coordinate value of the mouse cursor. The default value is 0.

## -remarks

> [!Important]
> The APIs in this namespace require the inputInjectionBrokered [restricted capability](/windows/uwp/packaging/app-capability-declarations#restricted-capabilities) to be declared in the application manifest. For more information on app capability requirements, see [App capability declarations](/windows/uwp/packaging/app-capability-declarations).

To use the input injection APIs, open the Package.appxmanifest file and add the following (the `rescap` namespace hosts the restricted capabilities, whuch lets you declare the `inputInjectionBrokered` capability in the `Capabilities` section).

- To `<Package>`
  - `xmlns:rescap="http://schemas.microsoft.com/appx/manifest/foundation/windows10/restrictedcapabilities" IgnorableNamespaces="rescap"`
- In `<Capabilities>`
  - `<rescap:Capability Name="inputInjectionBrokered" />`

## -examples

Here are some downloadable samples demonstrating basic input and input injection:

- [Input injection sample (mouse to touch)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-input-injection-mouse-to-touch.zip)
- [Touch injection sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/411c271e537727d737a53fa2cbe99eaecac00cc0/Official%20Windows%20Platform%20Sample/Input%20Touch%20injection%20sample)
- [Input: XAML user input events sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/411c271e537727d737a53fa2cbe99eaecac00cc0/Official%20Windows%20Platform%20Sample/Input%20XAML%20user%20input%20events%20sample)

## -see-also

[MouseData](injectedinputmouseinfo_mousedata.md), [MouseOptions](injectedinputmouseinfo_mouseoptions.md), [Simulate user input through input injection](/windows/uwp/design/input/input-injection)
