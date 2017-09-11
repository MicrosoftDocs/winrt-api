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

> [!NOTE]
> The APIs in this namespace require the inputInjectionBrokered [restricted capability](https://docs.microsoft.com/windows/uwp/packaging/app-capability-declarations#special-and-restricted-capabilities).

## -property-value
The angle of tilt of the pointer along the y-axis in a range of -90 to +90, with a positive value indicating a tilt toward the user. The default is 0.

## -remarks
Using input injection requires the following be added to the Package.appxmanifest:

- To `<Package>`
    - `xmlns:rescap="http://schemas.microsoft.com/appx/manifest/foundation/windows10/restrictedcapabilities"`
    - `IgnorableNamespaces="rescap"`
- To `<Capabilities>`
    - `<rescap:Capability Name="inputInjectionBrokered" />`


## -examples

## -see-also
