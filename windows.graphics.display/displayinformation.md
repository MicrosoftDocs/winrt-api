---
-api-id: T:Windows.Graphics.Display.DisplayInformation
-api-type: winrt class
---

<!-- Class syntax.
public class DisplayInformation : Windows.Graphics.Display.IDisplayInformation, Windows.Graphics.Display.IDisplayInformation2, Windows.Graphics.Display.IDisplayInformation3, Windows.Graphics.Display.IDisplayInformation4
-->

# Windows.Graphics.Display.DisplayInformation

## -description
Monitors and controls physical display information. The class provides events to allow clients to monitor for changes in the display.

## -remarks
To handle [DisplayInformation](displayinformation.md) events, use an event handler for the specific event. For example, for [DisplayInformation.DpiChanged](displayinformation_dpichanged.md), use "TypedEventHandler&lt;DisplayInformation, Object&gt; DpiChanged."

Any property change event of [DisplayInformation](displayinformation.md) might trigger if your app is moved from one monitor to another monitor. [ColorProfileChanged](displayinformation_colorprofilechanged.md) is triggered when the display’s color profile changes. [DpiChanged](displayinformation_dpichanged.md) is triggered when either the [LogicalDpi](displayinformation_logicaldpi.md) or [ResolutionScale](displayinformation_resolutionscale.md) property changes because a user selected a different zoom level or changed the screen resolution. [OrientationChanged](displayinformation_orientationchanged.md) is triggered if a user changes the screen orientation.

## -examples

## -see-also
[Display orientation sample (Windows 10)](http://go.microsoft.com/fwlink/p/?LinkId=624042), [Scaling according to DPI sample (Windows 10)](http://go.microsoft.com/fwlink/p/?LinkId=620537), [Camera preview frame sample (Windows 10)](http://go.microsoft.com/fwlink/p/?LinkId=620516), [Basic camera app sample (Windows 10)](http://go.microsoft.com/fwlink/p/?LinkId=619479), [Video stabilization sample (Windows 10)](http://go.microsoft.com/fwlink/p/?LinkId=620519), [Camera face detection sample (Windows 10)](http://go.microsoft.com/fwlink/p/?LinkId=619486), [Manual camera controls sample (Windows 10)](http://go.microsoft.com/fwlink/p/?LinkId=627611), [High dynamic range sample (Windows 10)](http://go.microsoft.com/fwlink/p/?LinkId=620517)