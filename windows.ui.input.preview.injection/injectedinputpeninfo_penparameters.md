---
-api-id: P:Windows.UI.Input.Preview.Injection.InjectedInputPenInfo.PenParameters
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Input.Preview.Injection.InjectedInputPenParameters PenParameters { get;  set; }
-->

# Windows.UI.Input.Preview.Injection.InjectedInputPenInfo.PenParameters

## -description
Gets or sets the pen states used to simulate pen input.

## -property-value
The pen states used to simulate pen input.

## -remarks
Using input injection requires the following be added to the Package.appxmanifest:

- To `<Package>`
    - `xmlns:rescap="http://schemas.microsoft.com/appx/manifest/foundation/windows10/restrictedcapabilities"`
    - `IgnorableNamespaces="rescap"`
- To `<Capabilities>`
    - `<rescap:Capability Name="inputInjectionBrokered" />`


## -examples

## -see-also
