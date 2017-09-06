---
-api-id: T:Windows.UI.Input.Preview.Injection.InputInjector
-api-type: winrt class
---

<!-- Class syntax.
public class InputInjector : Windows.UI.Input.Preview.Injection.IInputInjector
-->

# Windows.UI.Input.Preview.Injection.InputInjector

## -description
Represents the virtual input device for sending the input data.

## -remarks
Using input injection requires the following be added to the Package.appxmanifest:

- To `<Package>`
    - `xmlns:rescap="http://schemas.microsoft.com/appx/manifest/foundation/windows10/restrictedcapabilities"`
    - `IgnorableNamespaces="rescap"`
- To `<Capabilities>`
    - `<rescap:Capability Name="inputInjectionBrokered" />`


## -examples

## -see-also
[Windows.UI.Input.Preview.Injection classes](windows_ui_input_preview_injection_classes.md)