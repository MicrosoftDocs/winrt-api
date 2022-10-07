---
-api-id: T:Windows.UI.Input.RadialControllerScreenContactContinuedEventArgs
-api-type: winrt class
---

<!-- Class syntax.
public class RadialControllerScreenContactContinuedEventArgs : Windows.UI.Input.IRadialControllerScreenContactContinuedEventArgs, Windows.UI.Input.IRadialControllerScreenContactContinuedEventArgs2
-->

# Windows.UI.Input.RadialControllerScreenContactContinuedEventArgs

## -description
Contains event data for the [ScreenContactContinued](radialcontroller_screencontactcontinued.md) event (fired only while a custom [RadialController](radialcontroller.md) tool is active).


Your app does not receive this event when:

+ The [RadialController](radialcontroller.md) menu is active
+ A built-in tool is active


## -remarks

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1703 | 15063 | IsButtonPressed |
| 1703 | 15063 | SimpleHapticsController |

## -examples

## -see-also
[Windows.UI.Input Classes](windows_ui_input_classes.md), [Surface Dial interactions](/windows/uwp/input-and-devices/windows-wheel-interactions), [Universal Windows Platform samples (C# and C++)](https://go.microsoft.com/fwlink/?linkid=832713), [Windows desktop sample](https://aka.ms/radialcontrollerclassicsample)
