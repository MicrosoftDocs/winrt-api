---
-api-id: T:Windows.UI.Input.Preview.Injection.InjectedInputRectangle
-api-type: winrt struct
---

<!-- Structure syntax.
public struct InjectedInputRectangle 
-->

# InjectedInputRectangle

## -description
The offsets, from the injected pointer, for the bounding box that represents the touch contact area.

## -struct-fields

### -field Left
The location of the left side of the rectangle, in device-independent pixel (DIP).
    

### -field Top
The location of the top side of the rectangle, in device-independent pixel (DIP).
    

### -field Bottom
The location of the bottom side of the rectangle, in device-independent pixel (DIP).
    

### -field Right
The location of the left side of the rectangle, in device-independent pixel (DIP).
    

## -remarks

> [!Important]
> The APIs in this namespace require the inputInjectionBrokered [restricted capability](https://docs.microsoft.com/windows/uwp/packaging/app-capability-declarations#special-and-restricted-capabilities).

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

[Simulate user input through input injection](https://docs.microsoft.com/windows/uwp/design/input/input-injection)
