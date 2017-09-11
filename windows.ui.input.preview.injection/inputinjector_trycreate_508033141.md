---
-api-id: M:Windows.UI.Input.Preview.Injection.InputInjector.TryCreate
-api-type: winrt method
---

<!-- Method syntax.
public InputInjector InputInjector.TryCreate()
-->

# Windows.UI.Input.Preview.Injection.InputInjector.TryCreate

## -description
Attempts to create a new instance of the [InputInjector](inputinjector.md) class.

> [!NOTE]
> The APIs in this namespace require the inputInjectionBrokered [restricted capability](https://docs.microsoft.com/windows/uwp/packaging/app-capability-declarations#special-and-restricted-capabilities).

## -parameters

## -returns
If successful, returns a new instance of the [InputInjector](inputinjector.md) class. Otherwise, returns null.

## -remarks
Using input injection requires the following be added to the Package.appxmanifest:

- To `<Package>`
    - `xmlns:rescap="http://schemas.microsoft.com/appx/manifest/foundation/windows10/restrictedcapabilities"`
    - `IgnorableNamespaces="rescap"`
- To `<Capabilities>`
    - `<rescap:Capability Name="inputInjectionBrokered" />`


## -see-also

## -examples

