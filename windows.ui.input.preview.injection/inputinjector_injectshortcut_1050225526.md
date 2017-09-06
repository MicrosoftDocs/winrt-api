---
-api-id: M:Windows.UI.Input.Preview.Injection.InputInjector.InjectShortcut(Windows.UI.Input.Preview.Injection.InjectedInputShortcut)
-api-type: winrt method
---

<!-- Method syntax
public void InjectShortcut(Windows.UI.Input.Preview.Injection.InjectedInputShortcut shortcut)
-->

# Windows.UI.Input.Preview.Injection.InputInjector.InjectShortcut

## -description
Sends programmatically generated system shortcuts to the system.

## -parameters
### -param shortcut
The system shortcuts.

## -remarks
Using input injection requires the following be added to the Package.appxmanifest:

- To `<Package>`
    - `xmlns:rescap="http://schemas.microsoft.com/appx/manifest/foundation/windows10/restrictedcapabilities"`
    - `IgnorableNamespaces="rescap"`
- To `<Capabilities>`
    - `<rescap:Capability Name="inputInjectionBrokered" />`


## -examples

## -see-also
