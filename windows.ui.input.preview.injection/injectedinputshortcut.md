---
-api-id: T:Windows.UI.Input.Preview.Injection.InjectedInputShortcut
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.UI.Input.Preview.Injection.InjectedInputShortcut : int
-->

# InjectedInputShortcut

## -description
Specifies the system shortcuts for [InjectShortcut](inputinjector_injectshortcut.md).

## -enum-fields
### -field Back:0
Indicates traversal through a back stack.

### -field Start:1
Indicates traversal to a start, or home, screen.

### -field Search:2
Indicates traversal to a search screen.


## -remarks
Using input injection requires the following be added to the Package.appxmanifest:

- To `<Package>`
    - `xmlns:rescap="http://schemas.microsoft.com/appx/manifest/foundation/windows10/restrictedcapabilities"`
    - `IgnorableNamespaces="rescap"`
- To `<Capabilities>`
    - `<rescap:Capability Name="inputInjectionBrokered" />`


## -examples

## -see-also
[Windows.UI.Input.Preview.Injection enumerations](windows_ui_input_preview_injection_enumerations.md)