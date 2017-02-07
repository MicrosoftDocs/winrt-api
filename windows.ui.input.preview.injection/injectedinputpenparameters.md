---
-api-id: T:Windows.UI.Input.Preview.Injection.InjectedInputPenParameters
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.UI.Input.Preview.Injection.InjectedInputPenParameters : uint
-->

# InjectedInputPenParameters

## -description
Specifies the pen states used to simulate pen input through [InjectedInputPenInfo](injectedinputpeninfo.md).

## -enum-fields
### -field None:0
No pen state reported. Default.

### -field Pressure:1
The pen contact pressure on the digitizer surface, normalized to a range between 0 and 1024. The default is 0 if the device does not report pressure.

### -field Rotation:2
The clockwise rotation, or twist, of the pointer normalized in a range of 0 to 359. The default is 0.

### -field TiltX:4
The angle of tilt of the pointer along the x-axis in a range of -90 to +90, with a positive value indicating a tilt to the right. The default is 0.

### -field TiltY:8
The angle of tilt of the pointer along the y-axis in a range of -90 to +90, with a positive value indicating a tilt toward the user. The default is 0.


## -remarks

## -examples

## -see-also
[Windows.UI.Input.Preview.Injection enumerations](windows_ui_input_preview_injection_enumerations.md)