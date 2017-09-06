---
-api-id: T:Windows.UI.Input.Preview.Injection.InjectedInputVisualizationMode
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.UI.Input.Preview.Injection.InjectedInputVisualizationMode : int
-->

# InjectedInputVisualizationMode

## -description
Specifies the visual feedback modes for input injection.

## -enum-fields
### -field None:0
Indicates no visual feedback for input. Default.

### -field Default:1
Indicates default system visual feedback for input.

### -field Indirect:2
Indicates indirect visual feedback for input.


## -remarks
Using input injection requires the following be added to the Package.appxmanifest:

- To `<Package>`
    - `xmlns:rescap="http://schemas.microsoft.com/appx/manifest/foundation/windows10/restrictedcapabilities"`
    - `IgnorableNamespaces="rescap"`
- To `<Capabilities>`
    - `<rescap:Capability Name="inputInjectionBrokered" />`


## -examples

## -see-also
[Windows.UI.Input.Preview.Injection enumerations](windows_ui_input_preview_injection_enumerations.md), [InitializePenInjection](inputinjector_initializepeninjection.md), [InitializeTouchInjection](inputinjector_initializetouchinjection.md)