---
-api-id: T:Windows.UI.Input.PointerVisualizationSettings
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class PointerVisualizationSettings : Windows.UI.Input.IPointerVisualizationSettings
-->

# Windows.UI.Input.PointerVisualizationSettings

## -description
Provides access to the visual feedback settings for pointer input.

> [!IMPORTANT]
> Pointer visualizations are supported by the Desktop device family only.

## -remarks
Call [GetForCurrentView](pointervisualizationsettings_getforcurrentview.md) to get a [PointerVisualizationSettings](pointervisualizationsettings.md) object associated with the active app. This object is used to set the visual feedback preferences for the app.

This

## -examples
The following example demonstrates the use of [GetForCurrentView](pointervisualizationsettings_getforcurrentview.md) to retrieve an instance of [PointerVisualizationSettings](pointervisualizationsettings.md) through which the visual feedback preferences for the current app are set.

```javascript

var pointerVisualizationSettings = Windows.UI.Input.PointerVisualizationSettings.getForCurrentView();
pointerVisualizationSettings.isContactFeedbackEnabled = false;
pointerVisualizationSettings.isBarrelButtonFeedbackEnabled = false;
```



## -see-also
[Windows.UI.Input Classes](windows_ui_input_classes.md), [Windows.Devices.Input](../windows.devices.input/windows_devices_input.md), [Windows.UI.Core](../windows.ui.core/windows_ui_core.md), [Windows.UI.Input](windows_ui_input.md), [Windows.UI.Input.Inking](../windows.ui.input.inking/windows_ui_input_inking.md), [Windows.UI.Xaml.Input](../windows.ui.xaml.input/windows_ui_xaml_input.md), [TypedEventHandler](../windows.foundation/typedeventhandler_2.md), [Guidelines for visual feedback](http://msdn.microsoft.com/library/bf2f3672-95f0-4c8c-9a72-0934f2d3b767), [Custom user interactions](http://msdn.microsoft.com/library/9403c46c-60da-4c13-a381-6fbd069dd9ce), [UX guidelines for custom user interactions](http://msdn.microsoft.com/library/52f9607d-e2d0-44e4-9e1c-f856f7072a1e), [Touch design guidelines](http://msdn.microsoft.com/library/3250f729-4fdd-4ad4-b856-b8ba575c3375), [User interaction mode sample](http://go.microsoft.com/fwlink/p/?LinkID=619894), [Focus visuals sample](http://go.microsoft.com/fwlink/p/?LinkID=619895), [Input: Device capabilities sample](http://go.microsoft.com/fwlink/p/?linkid=231530), [Input: Ink sample](http://go.microsoft.com/fwlink/p/?linkid=231622), [Input: Manipulations and gestures (JavaScript) sample](http://go.microsoft.com/fwlink/p/?linkid=231638), [Input: Simplified ink  sample](http://go.microsoft.com/fwlink/p/?linkid=246570), [Input: Windows 8 gestures sample](http://go.microsoft.com/fwlink/p/?LinkId=264995), [Input: XAML user input events sample](http://go.microsoft.com/fwlink/p/?linkid=226855), [XAML scrolling, panning, and zooming sample](http://go.microsoft.com/fwlink/p/?linkid=251717), [DirectX touch input sample](http://go.microsoft.com/fwlink/p/?LinkID=231627), [Input: Manipulations and gestures (C++) sample](http://go.microsoft.com/fwlink/p/?linkid=231605), [Input: Touch hit testing sample](http://go.microsoft.com/fwlink/p/?linkid=231590), [Input source identification sample](http://go.microsoft.com/fwlink/p/?LinkID=267908), [Touch injection sample](http://go.microsoft.com/fwlink/p/?LinkID=267906), [Win32 touch hit-testing sample](http://go.microsoft.com/fwlink/p/?LinkID=267915)