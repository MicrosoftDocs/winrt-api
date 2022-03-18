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
Call [GetForCurrentView](pointervisualizationsettings_getforcurrentview_1363600702.md) to get a PointerVisualizationSettings object associated with the active app. This object is used to set the visual feedback preferences for the app.

This

## -examples
The following example demonstrates the use of [GetForCurrentView](pointervisualizationsettings_getforcurrentview_1363600702.md) to retrieve an instance of PointerVisualizationSettings through which the visual feedback preferences for the current app are set.

```javascript

var pointerVisualizationSettings = Windows.UI.Input.PointerVisualizationSettings.getForCurrentView();
pointerVisualizationSettings.isContactFeedbackEnabled = false;
pointerVisualizationSettings.isBarrelButtonFeedbackEnabled = false;
```



## -see-also
[Windows.UI.Input Classes](windows_ui_input_classes.md), [Windows.Devices.Input](../windows.devices.input/windows_devices_input.md), [Windows.UI.Core](../windows.ui.core/windows_ui_core.md), [Windows.UI.Input](windows_ui_input.md), [Windows.UI.Input.Inking](../windows.ui.input.inking/windows_ui_input_inking.md), [Windows.UI.Xaml.Input](../windows.ui.xaml.input/windows_ui_xaml_input.md), [TypedEventHandler](../windows.foundation/typedeventhandler_2.md), [Guidelines for visual feedback](/windows/uwp/input-and-devices/guidelines-for-visualfeedback), [Custom user interactions](/windows/uwp/design/layout/index), [UX guidelines for custom user interactions](/windows/uwp/design/layout/index), [Touch design guidelines](/windows/uwp/input-and-devices/guidelines-for-user-interaction), [User interaction mode sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/UserInteractionMode), [Focus visuals sample](https://go.microsoft.com/fwlink/p/?LinkID=619895), [Input: Device capabilities sample](/samples/browse/), [Input: Ink sample](/samples/browse/), [Input: Manipulations and gestures (JavaScript) sample](/samples/browse/), [Input: Simplified ink  sample](/samples/browse/), [Input: Windows 8 gestures sample](/samples/browse/), [Input: XAML user input events sample](/samples/browse/), [XAML scrolling, panning, and zooming sample](/samples/browse/), [DirectX touch input sample](/samples/browse/), [Input: Manipulations and gestures (C++) sample](/samples/browse/), [Input: Touch hit testing sample](/samples/browse/), [Input source identification sample](/samples/browse/), [Touch injection sample](/samples/browse/), [Win32 touch hit-testing sample](/samples/browse/)