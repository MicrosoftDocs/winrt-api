---
-api-id: M:Windows.UI.Input.Preview.Injection.InputInjector.UninitializeTouchInjection
-api-type: winrt method
---

<!-- Method syntax
public void UninitializeTouchInjection()
-->

# Windows.UI.Input.Preview.Injection.InputInjector.UninitializeTouchInjection

## -description
Shuts down the virtual touch device created with [InitializeTouchInjection](inputinjector_initializetouchinjection_1509714255.md).

## -remarks
Using input injection requires the following be added to the Package.appxmanifest:

- To `<Package>`
    - `xmlns:rescap="http://schemas.microsoft.com/appx/manifest/foundation/windows10/restrictedcapabilities"`
    - `IgnorableNamespaces="rescap"`
- To `<Capabilities>`
    - `<rescap:Capability Name="inputInjectionBrokered" />`


## -examples

## -see-also
