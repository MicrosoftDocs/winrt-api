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
- [Touch injection sample](http://go.microsoft.com/fwlink/p/?LinkID=267906)
- [Input: XAML user input events sample](http://go.microsoft.com/fwlink/p/?linkid=226855)
