---
-api-id: M:Windows.UI.Input.Preview.Injection.InputInjector.UninitializePenInjection
-api-type: winrt method
---

<!-- Method syntax
public void UninitializePenInjection()
-->

# Windows.UI.Input.Preview.Injection.InputInjector.UninitializePenInjection

## -description
Shuts down the virtual pen device created with [InitializePenInjection](inputinjector_initializepeninjection_260722924.md).

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
