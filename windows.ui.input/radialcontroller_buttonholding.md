---
-api-id: E:Windows.UI.Input.RadialController.ButtonHolding
-api-type: winrt event
---

<!-- Event syntax.
public event TypedEventHandler ButtonHolding<RadialController, RadialControllerButtonHoldingEventArgs>
-->

# Windows.UI.Input.RadialController.ButtonHolding

## -description
Occurs when the user presses and holds down the wheel device.

## -remarks
Your app does not receive this event when:

+ The [IsMenuSuppressed](radialcontrollerconfiguration_ismenusuppressed.md) is **false**.
+ The [ActiveControllerWhenMenuIsSuppressed](radialcontrollerconfiguration_activecontrollerwhenmenuissuppressed.md) is not set to the appropriate [RadialController](radialcontroller.md).

## -see-also

[RadialControllerButtonHoldingEventArgs](radialcontrollerbuttonholdingeventargs.md), [Surface Dial interactions](/windows/uwp/input-and-devices/windows-wheel-interactions), [Universal Windows Platform samples (C# and C++)](https://go.microsoft.com/fwlink/?linkid=832713), [Windows desktop sample](https://aka.ms/radialcontrollerclassicsample)

## -examples

