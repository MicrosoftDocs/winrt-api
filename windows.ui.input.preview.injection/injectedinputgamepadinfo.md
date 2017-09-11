---
-api-id: T:Windows.UI.Input.Preview.Injection.InjectedInputGamepadInfo
-api-type: winrt class
---

<!-- Class syntax.
public class InjectedInputGamepadInfo 
-->

# Windows.UI.Input.Preview.Injection.InjectedInputGamepadInfo

## -description
Represents programmatically generated gamepad input.

> [!NOTE]
> The APIs in this namespace require the inputInjectionBrokered [restricted capability](https://docs.microsoft.com/windows/uwp/packaging/app-capability-declarations#special-and-restricted-capabilities).

## -remarks
Using input injection requires the following be added to the Package.appxmanifest:

- To `<Package>`
    - `xmlns:rescap="http://schemas.microsoft.com/appx/manifest/foundation/windows10/restrictedcapabilities"`
    - `IgnorableNamespaces="rescap"`
- To `<Capabilities>`
    - `<rescap:Capability Name="inputInjectionBrokered" />`


## -see-also

## -examples

