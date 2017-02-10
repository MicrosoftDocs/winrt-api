---
-api-id: E:Windows.Graphics.Display.DisplayInformation.OrientationChanged
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler OrientationChanged<Windows.Graphics.Display.DisplayInformation,  object>
-->

# Windows.Graphics.Display.DisplayInformation.OrientationChanged

## -description
Occurs when either the [CurrentOrientation](displayinformation_currentorientation.md) or [NativeOrientation](displayinformation_nativeorientation.md) property changes because of a mode change or a monitor change.

## -remarks
The [OrientationChanged](displayinformation_orientationchanged.md) event occurs only when orientation of the display or monitor changes and not necessarily when the orientation of your app changes. To determine the orientation of your app for layout purposes, use the [ApplicationView.Value](../windows.ui.viewmanagement/applicationview_value.md) property.

## -examples

## -see-also
