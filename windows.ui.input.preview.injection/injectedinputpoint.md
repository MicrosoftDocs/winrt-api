---
-api-id: T:Windows.UI.Input.Preview.Injection.InjectedInputPoint
-api-type: winrt struct
---

<!-- Structure syntax.
public struct InjectedInputPoint 
-->

# InjectedInputPoint

## -description
Contains the screen coordinates of the pointer in device-independent pixel (DIP).

> [!NOTE]
> The APIs in this namespace require the inputInjectionBrokered [restricted capability](https://docs.microsoft.com/windows/uwp/packaging/app-capability-declarations#special-and-restricted-capabilities).

## -struct-fields

### -field PositionX
The x-coordinate of the pointer in device-independent pixel (DIP).
    

### -field PositionY
The y-coordinate of the pointer in device-independent pixel (DIP).
    

## -remarks
Using input injection requires the following be added to the Package.appxmanifest:

- To `<Package>`
    - `xmlns:rescap="http://schemas.microsoft.com/appx/manifest/foundation/windows10/restrictedcapabilities"`
    - `IgnorableNamespaces="rescap"`
- To `<Capabilities>`
    - `<rescap:Capability Name="inputInjectionBrokered" />`


## -examples

## -see-also
[Windows.UI.Input.Preview.Injection structures](windows_ui_input_preview_injection_structures.md)