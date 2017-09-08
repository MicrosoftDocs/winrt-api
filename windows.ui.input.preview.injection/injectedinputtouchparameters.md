---
-api-id: T:Windows.UI.Input.Preview.Injection.InjectedInputTouchParameters
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.UI.Input.Preview.Injection.InjectedInputTouchParameters : uint
-->

# InjectedInputTouchParameters

## -description
Specifies the touch states used to simulate touch input through [InjectedInputTouchInfo](injectedinputtouchinfo.md).

> [!NOTE]
> The APIs in this namespace require the inputInjectionBrokered [restricted capability](https://docs.microsoft.com/windows/uwp/packaging/app-capability-declarations#special-and-restricted-capabilities).

## -enum-fields
### -field None:0
No touch state reported. Default.

### -field Contact:1
The screen coordinates of the bounding box that represents the touch contact area.

### -field Orientation:2
The counter-clockwise angle of rotation around the major axis of the pointer device (the z-axis, perpendicular to the surface of the digitizer).

### -field Pressure:4
The force exerted by the pointer device on the surface of the digitizer.


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