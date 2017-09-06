---
-api-id: M:Windows.UI.Input.Preview.Injection.InputInjector.InjectPenInput(Windows.UI.Input.Preview.Injection.InjectedInputPenInfo)
-api-type: winrt method
---

<!-- Method syntax
public void InjectPenInput(Windows.UI.Input.Preview.Injection.InjectedInputPenInfo input)
-->

# Windows.UI.Input.Preview.Injection.InputInjector.InjectPenInput

## -description
Sends programmatically generated pen input to the system.

## -parameters
### -param input
The pen input specified by [InjectedInputPenInfo](injectedinputpeninfo.md).

## -remarks
Using input injection requires the following be added to the Package.appxmanifest:

- To `<Package>`
    - `xmlns:rescap="http://schemas.microsoft.com/appx/manifest/foundation/windows10/restrictedcapabilities"`
    - `IgnorableNamespaces="rescap"`
- To `<Capabilities>`
    - `<rescap:Capability Name="inputInjectionBrokered" />`


## -examples

## -see-also
