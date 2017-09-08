---
-api-id: M:Windows.UI.Input.Preview.Injection.InputInjector.InjectKeyboardInput(Windows.Foundation.Collections.IIterable{Windows.UI.Input.Preview.Injection.InjectedInputKeyboardInfo})
-api-type: winrt method
---

<!-- Method syntax
public void InjectKeyboardInput(Windows.Foundation.Collections.IIterable<Windows.UI.Input.Preview.Injection.InjectedInputKeyboardInfo> input)
-->

# Windows.UI.Input.Preview.Injection.InputInjector.InjectKeyboardInput

## -description
Sends programmatically generated keyboard input to the system.

> [!NOTE]
> The APIs in this namespace require the inputInjectionBrokered [restricted capability](https://docs.microsoft.com/windows/uwp/packaging/app-capability-declarations#special-and-restricted-capabilities).

## -parameters
### -param input
The keyboard input specified by [InjectedInputKeyboardInfo](injectedinputkeyboardinfo.md).

## -remarks
Using input injection requires the following be added to the Package.appxmanifest:

- To `<Package>`
    - `xmlns:rescap="http://schemas.microsoft.com/appx/manifest/foundation/windows10/restrictedcapabilities"`
    - `IgnorableNamespaces="rescap"`
- To `<Capabilities>`
    - `<rescap:Capability Name="inputInjectionBrokered" />`


## -examples

## -see-also
