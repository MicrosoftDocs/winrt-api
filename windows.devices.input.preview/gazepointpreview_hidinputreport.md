---
-api-id: P:Windows.Devices.Input.Preview.GazePointPreview.HidInputReport
-api-type: winrt property
---

<!-- Property syntax.
public HidInputReport HidInputReport { get; }
-->

# Windows.Devices.Input.Preview.GazePointPreview.HidInputReport

## -description

Gets a [Human Interface Device (HID)](http://www.usb.org/developers/hidpage/) input report for the eye-tracking device.

## -property-value

A [HidInputReport](..\windows.devices.input.preview\gazepointpreview_hidinputreport.md) object.

## -remarks

Devices issue input reports to describe state changes, user-input, and other device-specific data. For example, A HID eye-tracking sensor would use an input report to signal a gaze event.

## -see-also

### Conceptual

[Gaze interactions and eye tracking in UWP apps](https://docs.microsoft.com/windows/uwp/design/input/gaze-interactions)

### Samples

[Gaze input sample (basic)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-gazeinput-basic.zip)

### Resources

[Windows Community Toolkit Gaze library](https://docs.microsoft.com/windows/uwpcommunitytoolkit/gaze/gazeinteractionlibrary)

## -examples
