---
-api-id: P:Windows.UI.Input.Preview.Injection.InjectedInputPenInfo.PointerInfo
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Input.Preview.Injection.InjectedInputPointerInfo PointerInfo { get;  set; }
-->

# Windows.UI.Input.Preview.Injection.InjectedInputPenInfo.PointerInfo

## -description
Gets or sets basic pointer info common to pen input.

## -property-value
The pointer info.

## -remarks
Using input injection requires the following be added to the Package.appxmanifest:

- To `<Package>`
    - `xmlns:rescap="http://schemas.microsoft.com/appx/manifest/foundation/windows10/restrictedcapabilities"`
    - `IgnorableNamespaces="rescap"`
- To `<Capabilities>`
    - `<rescap:Capability Name="inputInjectionBrokered" />`


## -examples

## -see-also
