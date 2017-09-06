---
-api-id: M:Windows.UI.Input.Preview.Injection.InjectedInputTouchInfo.#ctor
-api-type: winrt method
---

<!-- Method syntax.
public InjectedInputTouchInfo.InjectedInputTouchInfo()
-->

# Windows.UI.Input.Preview.Injection.InjectedInputTouchInfo.InjectedInputTouchInfo

## -description
Creates a new [InjectedInputTouchInfo](injectedinputtouchinfo.md) object that is used to specify the touch input to inject.

## -parameters

## -remarks
Using input injection requires the following be added to the Package.appxmanifest:

- To `<Package>`
    - `xmlns:rescap="http://schemas.microsoft.com/appx/manifest/foundation/windows10/restrictedcapabilities"`
    - `IgnorableNamespaces="rescap"`
- To `<Capabilities>`
    - `<rescap:Capability Name="inputInjectionBrokered" />`


## -see-also

## -examples

