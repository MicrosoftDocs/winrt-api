---
-api-id: T:Windows.Graphics.Display.DisplayInformation
-api-type: winrt class
---

<!-- Class syntax.
public class DisplayInformation : Windows.Graphics.Display.IDisplayInformation, Windows.Graphics.Display.IDisplayInformation2, Windows.Graphics.Display.IDisplayInformation3, Windows.Graphics.Display.IDisplayInformation4
-->

# Windows.Graphics.Display.DisplayInformation

## -description

Monitors and controls display-related information for an application view. The class provides events to allow clients to monitor for changes in the application view affecting which display(s) the view resides on, as well as changes in displays that can affect the application view.

## -remarks

A DisplayInformation instance does not map to a specific display, but instead tracks display-related information for wherever the application view is placed. Calling [GetForCurrentView](displayinformation_getforcurrentview_1363600702.md) will always return the single instance for the current thread's [CoreApplicationView](../windows.applicationmodel.core/coreapplicationview.md). An instance of DisplayInformation can only be used from the thread on which it was created.

To handle DisplayInformation events, use an event handler for the specific event. For example, for [DisplayInformation.DpiChanged](displayinformation_dpichanged.md), use "TypedEventHandler&lt;DisplayInformation, Object&gt; DpiChanged."

Any property change event of DisplayInformation might trigger if your app is moved from one monitor to another monitor. [ColorProfileChanged](displayinformation_colorprofilechanged.md) is triggered when the display’s color profile changes. [DpiChanged](displayinformation_dpichanged.md) is triggered when the [LogicalDpi](displayinformation_logicaldpi.md), [ResolutionScale](displayinformation_resolutionscale.md), and [RawPixelsPerViewPixel](displayinformation_rawpixelsperviewpixel.md) properties change because a user selected a different zoom level or changed the screen resolution. [OrientationChanged](displayinformation_orientationchanged.md) is triggered if a user changes the screen orientation.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1511 | 10586 | DiagonalSizeInInches |
| 1607 | 14393 | ScreenHeightInRawPixels |
| 1607 | 14393 | ScreenWidthInRawPixels |
| 1803 | 17134 | AdvancedColorInfoChanged |
| 1803 | 17134 | GetAdvancedColorInfo |

## -examples

## -see-also

[Display orientation sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/DisplayOrientation), [Scaling according to DPI sample (Windows 10)](https://go.microsoft.com/fwlink/p/?LinkId=620537), [Camera preview frame sample (Windows 10)](https://go.microsoft.com/fwlink/p/?LinkId=620516), [Basic camera app sample (Windows 10)](https://go.microsoft.com/fwlink/p/?LinkId=619479), [Video stabilization sample (Windows 10)](https://go.microsoft.com/fwlink/p/?LinkId=620519), [Camera face detection sample (Windows 10)](https://go.microsoft.com/fwlink/p/?LinkId=619486), [Manual camera controls sample (Windows 10)](https://go.microsoft.com/fwlink/p/?LinkId=627611), [High dynamic range sample (Windows 10)](https://go.microsoft.com/fwlink/p/?LinkId=620517), [Camera Advanced Capture sample](https://github.com/Microsoft/Windows-universal-samples/tree/dev/Samples/CameraAdvancedCapture)
