---
-api-id: T:Windows.Devices.Input.Preview.GazeDeviceConfigurationStatePreview
-api-type: winrt enum
---

<!-- Enumeration syntax.
public enum GazeDeviceConfigurationStatePreview : int 
-->

# Windows.Devices.Input.Preview.GazeDeviceConfigurationStatePreview

## -description

Specifies the possible configuration states of an eye-tracking device.

## -enum-fields

### -field Unknown:0

The eye-tracker device state is unknown. Calibration might resolve this state.

### -field Ready:1

The eye-tracker device is ready to start eye and head tracking.

### -field Configuring:2

The eye-tracker device is currently being configured.

### -field ScreenSetupNeeded:3

The display device is not configured correctly. Calibration might resolve this state.

### -field UserCalibrationNeeded:4

The eye-tracker device needs to be calibrated.

## -remarks

Use these values to confirm that the eye-tracking device is calibrated and ready to send gaze input events and data.

## -see-also

[ConfigurationState](gazedevicepreview_configurationstate.md), [Gaze interactions and eye tracking in UWP apps](/windows/uwp/design/input/gaze-interactions), [Gaze input sample (basic)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-gazeinput-basic.zip), [Windows Community Toolkit Gaze library](/windows/uwpcommunitytoolkit/gaze/gazeinteractionlibrary)

## -examples
