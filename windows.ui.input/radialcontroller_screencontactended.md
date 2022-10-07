---
-api-id: E:Windows.UI.Input.RadialController.ScreenContactEnded
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler ScreenContactEnded<Windows.UI.Input.RadialController,  object>
-->

# Windows.UI.Input.RadialController.ScreenContactEnded

## -description
Occurs when a wheel device that is in contact with the digitizer surface is removed (or is no longer detected), and a custom [RadialController](radialcontroller.md) tool is active.


Your app does not receive this event when:

+ The [RadialController](radialcontroller.md) menu is active
+ A built-in tool is active


> [!TIP]
> In addition to the default press and hold menu experience, the Surface Dial can also be placed directly on the screen of the Surface Studio. This enables a special "on-screen" menu.

By detecting both the contact location and bounds of the Surface Dial, the system can handle occlusion by the device and display a larger version of the menu that wraps around the outside of the Dial. This same info can also be used by your app to adapt the UI for both the presence of the device and its anticipated usage, such as the placement of the user's hand and arm.

This event occurs after [ScreenContactStarted](radialcontroller_screencontactstarted.md).

## -remarks

## -examples

## -see-also
[ScreenContactStarted](radialcontroller_screencontactstarted.md), [ScreenContactContinued](radialcontroller_screencontactcontinued.md), [Surface Dial interactions](/windows/uwp/input-and-devices/windows-wheel-interactions), [Universal Windows Platform samples (C# and C++)](https://go.microsoft.com/fwlink/?linkid=832713), [Windows desktop sample](https://aka.ms/radialcontrollerclassicsample)