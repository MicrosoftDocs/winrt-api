---
-api-id: T:Windows.UI.Input.Preview.Injection.InjectedInputMouseInfo
-api-type: winrt class
---

<!-- Class syntax.
public class InjectedInputMouseInfo : Windows.UI.Input.Preview.Injection.IInjectedInputMouseInfo
-->

# Windows.UI.Input.Preview.Injection.InjectedInputMouseInfo

## -description
Represents programmatically generated mouse input.

> [!NOTE]
> The APIs in this namespace require the inputInjectionBrokered [restricted capability](https://docs.microsoft.com/windows/uwp/packaging/app-capability-declarations#special-and-restricted-capabilities).

## -remarks
Using input injection requires the following be added to the Package.appxmanifest:

- To `<Package>`
    - `xmlns:rescap="http://schemas.microsoft.com/appx/manifest/foundation/windows10/restrictedcapabilities"`
    - `IgnorableNamespaces="rescap"`
- To `<Capabilities>`
    - `<rescap:Capability Name="inputInjectionBrokered" />`


## -examples

## -see-also
[Windows.UI.Input.Preview.Injection classes](windows_ui_input_preview_injection_classes.md)