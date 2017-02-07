---
-api-id: T:Windows.UI.Input.Preview.Injection.InjectedInputPointerInfo
-api-type: winrt struct
---

<!-- Structure syntax.
public struct InjectedInputPointerInfo 
-->

# InjectedInputPointerInfo

## -description
Contains basic pointer information common to all pointer types.

## -struct-fields

### -field PointerId
A unique identifier for the lifetime of the pointer. A pointer is created when it enters detection range and destroyed when it leaves detection range. If a pointer goes out of detection range and then returns, it is treated as a new pointer and might be assigned a new identifier.
    

### -field PointerOptions
The various options, or modifiers, used to simulate pointer input through [InjectedInputMouseInfo](injectedinputmouseinfo.md), [InjectedInputPenInfo](injectedinputpeninfo.md), and [InjectedInputTouchInfo](injectedinputtouchinfo.md).
    

### -field PixelLocation
The screen coordinates of the pointer in device-independent pixel (DIP).
    

### -field TimeOffsetInMilliseconds
The baseline, or reference value, in milliseconds, for timed input events such as a double click/tap.
    

### -field PerformanceCount
A high resolution (less than one microsecond) time stamp used for time-interval measurements.
    

## -remarks

## -examples

## -see-also
[Windows.UI.Input.Preview.Injection structures](windows_ui_input_preview_injection_structures.md), [InjectedInputPenInfo.PointerInfo](injectedinputpeninfo_pointerinfo.md), [InjectedInputTouchInfo.PointerInfo](injectedinputtouchinfo_pointerinfo.md)