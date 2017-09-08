---
-api-id: P:Windows.UI.Input.Preview.Injection.InjectedInputGamepadInfo.LeftThumbstickX
-api-type: winrt property
---

<!-- Property syntax.
public double LeftThumbstickX { get;  set; }
-->

# Windows.UI.Input.Preview.Injection.InjectedInputGamepadInfo.LeftThumbstickX

## -description
Gets or sets the position of the left stick on the X-axis. 

> [!NOTE]
> The APIs in this namespace require the inputInjectionBrokered [restricted capability](https://docs.microsoft.com/windows/uwp/packaging/app-capability-declarations#special-and-restricted-capabilities).

## -property-value
A value between -1.0 (pressed to the left) and 1.0 (pressed to the right).

## -remarks
Using input injection requires the following be added to the Package.appxmanifest:

- To `<Package>`
    - `xmlns:rescap="http://schemas.microsoft.com/appx/manifest/foundation/windows10/restrictedcapabilities"`
    - `IgnorableNamespaces="rescap"`
- To `<Capabilities>`
    - `<rescap:Capability Name="inputInjectionBrokered" />`


## -see-also

## -examples

