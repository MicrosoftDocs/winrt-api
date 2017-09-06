---
-api-id: P:Windows.UI.Input.Preview.Injection.InjectedInputPenInfo.TiltX
-api-type: winrt property
---

<!-- Property syntax
public int TiltX { get;  set; }
-->

# Windows.UI.Input.Preview.Injection.InjectedInputPenInfo.TiltX

## -description
Gets or sets the angle of tilt of the pointer along the x-axis.

## -property-value
The angle of tilt of the pointer along the x-axis in a range of -90 to +90, with a positive value indicating a tilt to the right. The default is 0.

## -remarks
Using input injection requires the following be added to the Package.appxmanifest:

- To `<Package>`
    - `xmlns:rescap="http://schemas.microsoft.com/appx/manifest/foundation/windows10/restrictedcapabilities"`
    - `IgnorableNamespaces="rescap"`
- To `<Capabilities>`
    - `<rescap:Capability Name="inputInjectionBrokered" />`


## -examples

## -see-also
