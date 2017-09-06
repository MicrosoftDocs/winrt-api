---
-api-id: P:Windows.UI.Input.Preview.Injection.InjectedInputPenInfo.PenButtons
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Input.Preview.Injection.InjectedInputPenButtons PenButtons { get;  set; }
-->

# Windows.UI.Input.Preview.Injection.InjectedInputPenInfo.PenButtons

## -description
Gets or sets the pen button options.

## -property-value
The pen button states.

## -remarks
Using input injection requires the following be added to the Package.appxmanifest:

- To `<Package>`
    - `xmlns:rescap="http://schemas.microsoft.com/appx/manifest/foundation/windows10/restrictedcapabilities"`
    - `IgnorableNamespaces="rescap"`
- To `<Capabilities>`
    - `<rescap:Capability Name="inputInjectionBrokered" />`


## -examples

## -see-also
