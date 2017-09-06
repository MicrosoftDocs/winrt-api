---
-api-id: M:Windows.UI.Input.Preview.Injection.InputInjector.InjectTouchInput(Windows.Foundation.Collections.IIterable{Windows.UI.Input.Preview.Injection.InjectedInputTouchInfo})
-api-type: winrt method
---

<!-- Method syntax
public void InjectTouchInput(Windows.Foundation.Collections.IIterable<Windows.UI.Input.Preview.Injection.InjectedInputTouchInfo> input)
-->

# Windows.UI.Input.Preview.Injection.InputInjector.InjectTouchInput

## -description
Sends programmatically generated touch input to the system.

## -parameters
### -param input
The touch input specified by [InjectedInputTouchInfo](injectedinputtouchinfo.md).

## -remarks
Using input injection requires the following be added to the Package.appxmanifest:

- To `<Package>`
    - `xmlns:rescap="http://schemas.microsoft.com/appx/manifest/foundation/windows10/restrictedcapabilities"`
    - `IgnorableNamespaces="rescap"`
- To `<Capabilities>`
    - `<rescap:Capability Name="inputInjectionBrokered" />`


## -examples

## -see-also
