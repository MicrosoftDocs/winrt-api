---
-api-id: M:Windows.UI.Input.Preview.Injection.InjectedInputPenInfo.#ctor
-api-type: winrt method
---

<!-- Method syntax.
public InjectedInputPenInfo.InjectedInputPenInfo()
-->

# Windows.UI.Input.Preview.Injection.InjectedInputPenInfo.InjectedInputPenInfo

## -description
Creates a new [InjectedInputPenInfo](injectedinputpeninfo.md) object that is used to specify the pen input to inject.

> [!NOTE]
> The APIs in this namespace require the inputInjectionBrokered [restricted capability](https://docs.microsoft.com/windows/uwp/packaging/app-capability-declarations#special-and-restricted-capabilities).

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

