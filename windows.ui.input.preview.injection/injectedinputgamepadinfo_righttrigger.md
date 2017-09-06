---
-api-id: P:Windows.UI.Input.Preview.Injection.InjectedInputGamepadInfo.RightTrigger
-api-type: winrt property
---

<!-- Property syntax.
public double RightTrigger { get;  set; }
-->

# Windows.UI.Input.Preview.Injection.InjectedInputGamepadInfo.RightTrigger

## -description
Gets or sets the position of the right trigger. 

## -property-value
A value between 0.0 (not depressed) and 1.0 (fully depressed).

## -remarks
Using input injection requires the following be added to the Package.appxmanifest:

- To `<Package>`
    - `xmlns:rescap="http://schemas.microsoft.com/appx/manifest/foundation/windows10/restrictedcapabilities"`
    - `IgnorableNamespaces="rescap"`
- To `<Capabilities>`
    - `<rescap:Capability Name="inputInjectionBrokered" />`


## -see-also

## -examples

