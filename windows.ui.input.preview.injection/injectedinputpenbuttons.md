---
-api-id: T:Windows.UI.Input.Preview.Injection.InjectedInputPenButtons
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.UI.Input.Preview.Injection.InjectedInputPenButtons : uint
-->

# InjectedInputPenButtons

## -description
Specifies the pen options used to simulate pen input through [InjectedInputPenInfo](injectedinputpeninfo.md).

> [!NOTE]
> The APIs in this namespace require the inputInjectionBrokered [restricted capability](https://docs.microsoft.com/windows/uwp/packaging/app-capability-declarations#special-and-restricted-capabilities).

## -enum-fields
### -field None:0
No pen buttons are pressed. Default.

### -field Barrel:1
The barrel button is pressed.

### -field Inverted:2
The pen is inverted.

### -field Eraser:4
The eraser button is pressed.


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