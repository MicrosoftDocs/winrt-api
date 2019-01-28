---
-api-id: M:Windows.Devices.Input.Preview.GazeInputSourcePreview.GetForCurrentView
-api-type: winrt method
---

<!-- Method syntax.
public GazeInputSourcePreview GazeInputSourcePreview.GetForCurrentView()
-->

# Windows.Devices.Input.Preview.GazeInputSourcePreview.GetForCurrentView

## -description

Retrieves a reference to the user identified by an eye-tracking device, bound to the active application.

## -returns

A [GazeInputSourcePreview](gazeinputsourcepreview_getforcurrentview_1363600702.md) object bound to the active application.

## -remarks

This method must be called on the UI thread, see [Keep the UI thread responsive](https://docs.microsoft.com/windows/uwp/debug-test-perf/keep-the-ui-thread-responsive).

Calling this method results in a privacy prompt in which the user is asked to grant permission for your app to access their eye-tracking device. The user is prompted only once, when the app is run for the first time.

Windows automatically prompts users with a consent dialog (when the app is first run), with which the user must grant permission for the app to communicate with the eye-tracking device and access gaze data.

## -see-also

### Conceptual

[Gaze interactions and eye tracking in UWP apps](https://docs.microsoft.com/windows/uwp/design/input/gaze-interactions)

### Samples

[Gaze input sample (basic)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-gazeinput-basic.zip)

### Resources

[Windows Community Toolkit Gaze library](https://docs.microsoft.com/windows/uwpcommunitytoolkit/gaze/gazeinteractionlibrary)

## -examples
