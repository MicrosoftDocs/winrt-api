---
-api-id: M:Windows.UI.Input.Preview.Injection.InjectedInputKeyboardInfo.#ctor
-api-type: winrt method
---

<!-- Method syntax.
public InjectedInputKeyboardInfo.InjectedInputKeyboardInfo()
-->

# Windows.UI.Input.Preview.Injection.InjectedInputKeyboardInfo.InjectedInputKeyboardInfo

## -description
Creates a new [InjectedInputKeyboardInfo](injectedinputkeyboardinfo.md) object that is used to specify the keyboard input to inject.

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

