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

## -examples

## -see-also
[Windows.UI.Input.Preview.Injection enumerations](windows_ui_input_preview_injection_enumerations.md)