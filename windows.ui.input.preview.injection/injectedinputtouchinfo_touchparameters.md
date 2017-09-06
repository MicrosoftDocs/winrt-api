---
-api-id: P:Windows.UI.Input.Preview.Injection.InjectedInputTouchInfo.TouchParameters
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Input.Preview.Injection.InjectedInputTouchParameters TouchParameters { get;  set; }
-->

# Windows.UI.Input.Preview.Injection.InjectedInputTouchInfo.TouchParameters

## -description
Gets or sets the touch states used to simulate touch input.

## -property-value
The touch states used to simulate touch input.

## -remarks
Using input injection requires the following be added to the Package.appxmanifest:

- To `<Package>`
    - `xmlns:rescap="http://schemas.microsoft.com/appx/manifest/foundation/windows10/restrictedcapabilities"`
    - `IgnorableNamespaces="rescap"`
- To `<Capabilities>`
    - `<rescap:Capability Name="inputInjectionBrokered" />`


## -examples

## -see-also
