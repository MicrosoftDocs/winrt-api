---
-api-id: E:Windows.UI.Input.RadialController.ButtonClicked
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler ButtonClicked<Windows.UI.Input.RadialController,  Windows.UI.Input.RadialControllerButtonClickedEventArgs>
-->

# Windows.UI.Input.RadialController.ButtonClicked

## -description
Occurs when the wheel device is pressed and then released while a custom [RadialController](radialcontroller.md) tool is active.


Your app does not receive this event when:

+ The [RadialController](radialcontroller.md) menu is active
+ A built-in tool is active


> [!NOTE]
> When a time threshold is crossed, click becomes a press and hold action. In this case, the integrated menu of contextual app commands associated with the [RadialController](radialcontroller.md) object is displayed, and subsequent rotate and click events are processed by the menu.

## -remarks

## -examples

## -see-also
[Surface Dial interactions](/windows/uwp/input-and-devices/windows-wheel-interactions), [Universal Windows Platform samples (C# and C++)](https://go.microsoft.com/fwlink/?linkid=832713), [Windows desktop sample](https://aka.ms/radialcontrollerclassicsample)