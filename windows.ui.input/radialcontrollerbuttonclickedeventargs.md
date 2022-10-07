---
-api-id: T:Windows.UI.Input.RadialControllerButtonClickedEventArgs
-api-type: winrt class
---

<!-- Class syntax.
public class RadialControllerButtonClickedEventArgs : Windows.UI.Input.IRadialControllerButtonClickedEventArgs, Windows.UI.Input.IRadialControllerButtonClickedEventArgs2
-->

# Windows.UI.Input.RadialControllerButtonClickedEventArgs

## -description
Contains event data for the [ButtonClicked](radialcontroller_buttonclicked.md) event (fired only while a custom [RadialController](radialcontroller.md) tool is active).


Your app does not receive this event when:

+ The [RadialController](radialcontroller.md) menu is active
+ A built-in tool is active


> [!NOTE]
> When a time threshold is crossed, click becomes a press and hold action. In this case, the integrated menu of contextual app commands associated with the wheel device is displayed, and subsequent rotate and click events are processed by the menu.

## -remarks

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1703 | 15063 | SimpleHapticsController |

## -examples

## -see-also

[Windows.UI.Input Classes](windows_ui_input_classes.md), [Surface Dial interactions](/windows/uwp/input-and-devices/windows-wheel-interactions), [Universal Windows Platform samples (C# and C++)](https://go.microsoft.com/fwlink/?linkid=832713), [Windows desktop sample](https://aka.ms/radialcontrollerclassicsample)
