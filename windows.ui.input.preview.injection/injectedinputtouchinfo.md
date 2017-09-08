---
-api-id: T:Windows.UI.Input.Preview.Injection.InjectedInputTouchInfo
-api-type: winrt class
---

<!-- Class syntax.
public class InjectedInputTouchInfo : Windows.UI.Input.Preview.Injection.IInjectedInputTouchInfo
-->

# Windows.UI.Input.Preview.Injection.InjectedInputTouchInfo

## -description
Represents programmatically generated touch input.

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