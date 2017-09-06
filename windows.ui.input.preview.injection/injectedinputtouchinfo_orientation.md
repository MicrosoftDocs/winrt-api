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
Using input injection requires the following be added to the Package.appxmanifest:

- To `<Package>`
    - `xmlns:rescap="http://schemas.microsoft.com/appx/manifest/foundation/windows10/restrictedcapabilities"`
    - `IgnorableNamespaces="rescap"`
- To `<Capabilities>`
    - `<rescap:Capability Name="inputInjectionBrokered" />`


## -examples

## -see-also
