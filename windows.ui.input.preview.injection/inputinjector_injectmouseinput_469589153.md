---
-api-id: M:Windows.UI.Input.Preview.Injection.InputInjector.InjectMouseInput(Windows.Foundation.Collections.IIterable{Windows.UI.Input.Preview.Injection.InjectedInputMouseInfo})
-api-type: winrt method
---

<!-- Method syntax
public void InjectMouseInput(Windows.Foundation.Collections.IIterable<Windows.UI.Input.Preview.Injection.InjectedInputMouseInfo> input)
-->

# Windows.UI.Input.Preview.Injection.InputInjector.InjectMouseInput

## -description
Sends programmatically generated mouse input to the system.

> [!NOTE]
> The APIs in this namespace require the inputInjectionBrokered [restricted capability](https://docs.microsoft.com/windows/uwp/packaging/app-capability-declarations#special-and-restricted-capabilities).

## -parameters
### -param input
The mouse input specified by [InjectedInputMouseInfo](injectedinputmouseinfo.md).

## -remarks
Using input injection requires the following be added to the Package.appxmanifest:

- To `<Package>`
    - `xmlns:rescap="http://schemas.microsoft.com/appx/manifest/foundation/windows10/restrictedcapabilities"`
    - `IgnorableNamespaces="rescap"`
- To `<Capabilities>`
    - `<rescap:Capability Name="inputInjectionBrokered" />`


## -examples

## -see-also
