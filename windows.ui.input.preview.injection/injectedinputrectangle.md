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

## -see-also

### Conceptual

[Gaze interactions and eye tracking in UWP apps](https://docs.microsoft.com/windows/uwp/design/input/gaze-interactions)

### Samples

- [Simulate user input through input injection](https://review.docs.microsoft.com/windows/uwp/design/input/input-injection?branch=kbridge-inputinjection)
- [Input injection sample (mouse to touch)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-input-injection-mouse-to-touch.zip)
- [Touch injection sample](https://go.microsoft.com/fwlink/p/?LinkID=267906)
- [Input: XAML user input events sample](https://go.microsoft.com/fwlink/p/?linkid=226855)
