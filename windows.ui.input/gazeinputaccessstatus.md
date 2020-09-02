---
-api-id: T:Windows.UI.Input.GazeInputAccessStatus
-api-type: winrt enum
ms.custom: 19H1
---

<!-- Enumeration syntax.
public enum GazeInputAccessStatus : int 
-->

# Windows.UI.Input.GazeInputAccessStatus

## -description

Specifies the permission state for tracking the user's gaze.

## -enum-fields

### -field Unspecified:0

The user has not specified whether the app can track their gaze.

### -field DeniedByUser:2

The user has denied permission for the app to track their gaze.

### -field DeniedBySystem:3

The system has denied permission for the app to track the user's gaze.

### -field Allowed:1

The user has given permission for the app to to track their gaze.

## -remarks

Due to the potentially sensitive personal data collected by eye tracking devices, you are required to declare the 'gazeInput' capability in the app manifest of your UWP application. When declared, Windows automatically prompts users with a consent dialog (when the app is first run), where the user must grant permission for the app to communicate with the eye-tracking device and access this data.

In addition, if your app collects, stores, or transfers eye tracking data, you must describe this in your app's privacy statement and follow all other requirements for **Personal Information** in the [App Developer Agreement](/legal/windows/agreements/app-developer-agreement) and the [Microsoft Store Policies](/legal/windows/agreements/store-policies).

## -see-also

[Windows.Devices.Input.Preview](../windows.devices.input.preview/windows_devices_input_preview.md), [RequestAccessAsync](../windows.perception.people/eyespose_requestaccessasync_380675631.md)

## -examples

