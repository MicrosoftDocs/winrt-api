---
-api-id: T:Windows.UI.Input.Preview.Injection.InjectedInputRectangle
-api-type: winrt struct
---

<!-- Structure syntax.
public struct InjectedInputRectangle 
-->

# InjectedInputRectangle

## -description
The screen coordinates of the bounding box that represents the touch contact area.

> [!NOTE]
> The APIs in this namespace require the inputInjectionBrokered [restricted capability](https://docs.microsoft.com/windows/uwp/packaging/app-capability-declarations#special-and-restricted-capabilities).

## -struct-fields

### -field Left
The x-coordinate location of the left side of the rectangle, in device-independent pixel (DIP).
    

### -field Top
The y-coordinate location of the top side of the rectangle, in device-independent pixel (DIP).
    

### -field Bottom
The y-coordinate location of the bottom side of the rectangle, in device-independent pixel (DIP).
    

### -field Right
The y-coordinate location of the left side of the rectangle, in device-independent pixel (DIP).
    

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