---
-api-id: M:Windows.UI.Input.Preview.Injection.InputInjector.InitializeTouchInjection(Windows.UI.Input.Preview.Injection.InjectedInputVisualizationMode)
-api-type: winrt method
---

<!-- Method syntax
public void InitializeTouchInjection(Windows.UI.Input.Preview.Injection.InjectedInputVisualizationMode visualMode)
-->

# Windows.UI.Input.Preview.Injection.InputInjector.InitializeTouchInjection

## -description
Initializes a virtual touch device that can synthesize input events and provide corresponding input data to the system. 

> [!NOTE]
> The APIs in this namespace require the inputInjectionBrokered [restricted capability](https://docs.microsoft.com/windows/uwp/packaging/app-capability-declarations#special-and-restricted-capabilities).

## -parameters
### -param visualMode
The visual feedback mode for touch input injection.

## -remarks
Using input injection requires the following be added to the Package.appxmanifest:

- To `<Package>`
    - `xmlns:rescap="http://schemas.microsoft.com/appx/manifest/foundation/windows10/restrictedcapabilities"`
    - `IgnorableNamespaces="rescap"`
- To `<Capabilities>`
    - `<rescap:Capability Name="inputInjectionBrokered" />`


## -examples

## -see-also
- [UninitializeTouchInjection](inputinjector_uninitializetouchinjection_1885359186.md)
