---
-api-id: P:Windows.UI.Input.Preview.Injection.InjectedInputTouchInfo.Pressure
-api-type: winrt property
---

<!-- Property syntax
public double Pressure { get;  set; }
-->

# Windows.UI.Input.Preview.Injection.InjectedInputTouchInfo.Pressure

## -description
Gets or sets the force exerted by the pointer device on the surface of the digitizer.

> [!NOTE]
> The APIs in this namespace require the inputInjectionBrokered [restricted capability](https://docs.microsoft.com/windows/uwp/packaging/app-capability-declarations#special-and-restricted-capabilities).

## -property-value
The touch contact force exerted on the digitizer surface, normalized to a range between 0 and 1024. The default is 0.

## -remarks
Using input injection requires the following be added to the Package.appxmanifest:

- To `<Package>`
    - `xmlns:rescap="http://schemas.microsoft.com/appx/manifest/foundation/windows10/restrictedcapabilities"`
    - `IgnorableNamespaces="rescap"`
- To `<Capabilities>`
    - `<rescap:Capability Name="inputInjectionBrokered" />`


## -examples

## -see-also
