---
-api-id: P:Windows.Devices.Input.Preview.GazePointPreview.HidInputReport
-api-type: winrt property
---

<!-- Property syntax.
public HidInputReport HidInputReport { get; }
-->

# Windows.Devices.Input.Preview.GazePointPreview.HidInputReport

## -description

Gets a [Human Interface Device (HID)](https://www.usb.org/hid) input report for the eye-tracking device.

## -property-value

A [HidInputReport](../windows.devices.humaninterfacedevice/hidinputreport.md) object.

## -remarks

Devices issue input reports to describe state changes, user-input, and other device-specific data. For example, A HID eye-tracking sensor would use an input report to signal a gaze event.

## -see-also

[Gaze interactions and eye tracking in UWP apps](/windows/uwp/design/input/gaze-interactions), [Gaze input sample (basic)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-gazeinput-basic.zip), [Windows Community Toolkit Gaze library](/windows/uwpcommunitytoolkit/gaze/gazeinteractionlibrary)

## -examples
