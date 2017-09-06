---
-api-id: P:Windows.UI.Input.Preview.Injection.InjectedInputGamepadInfo.LeftThumbstickY
-api-type: winrt property
---

<!-- Property syntax.
public double LeftThumbstickY { get;  set; }
-->

# Windows.UI.Input.Preview.Injection.InjectedInputGamepadInfo.LeftThumbstickY

## -description
Gets or sets the position of the left stick on the Y-axis. 

## -property-value
A value between -1.0 (pressed towards the user) and 1.0 (pressed away from the user).

## -remarks
Using input injection requires the following be added to the Package.appxmanifest:

- To `<Package>`
    - `xmlns:rescap="http://schemas.microsoft.com/appx/manifest/foundation/windows10/restrictedcapabilities"`
    - `IgnorableNamespaces="rescap"`
- To `<Capabilities>`
    - `<rescap:Capability Name="inputInjectionBrokered" />`


## -see-also

## -examples

