---
-api-id: P:Windows.UI.Input.Preview.Injection.InjectedInputPenInfo.Rotation
-api-type: winrt property
---

<!-- Property syntax
public double Rotation { get;  set; }
-->

# Windows.UI.Input.Preview.Injection.InjectedInputPenInfo.Rotation

## -description
Gets or sets the clockwise rotation, or twist, of the pointer.

## -property-value
The clockwise rotation, or twist, of the pointer normalized to a range between 0 and 359. The default is 0.

## -remarks
Using input injection requires the following be added to the Package.appxmanifest:

- To `<Package>`
    - `xmlns:rescap="http://schemas.microsoft.com/appx/manifest/foundation/windows10/restrictedcapabilities"`
    - `IgnorableNamespaces="rescap"`
- To `<Capabilities>`
    - `<rescap:Capability Name="inputInjectionBrokered" />`


## -examples

## -see-also
