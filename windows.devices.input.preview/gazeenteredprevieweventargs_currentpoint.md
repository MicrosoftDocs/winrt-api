---
-api-id: P:Windows.Devices.Input.Preview.GazeEnteredPreviewEventArgs.CurrentPoint
-api-type: winrt property
---

<!-- Property syntax.
public GazePointPreview CurrentPoint { get; }
-->

# Windows.Devices.Input.Preview.GazeEnteredPreviewEventArgs.CurrentPoint

## -description

Gets the [gaze pointer](gazepointpreview.md) data from the most recent [GazeEntered](gazeinputsourcepreview_gazeentered.md) event.

## -property-value

The [gaze pointer](gazepointpreview.md) data from the most recent [GazeEntered](gazeinputsourcepreview_gazeentered.md) event.

## -remarks

The screen coordinates of the gaze point are in device-independent pixels (DIP) relative to, and constrained by, the application view (or gaze-enabled element).

## -see-also

[Gaze interactions and eye tracking in UWP apps](/windows/uwp/design/input/gaze-interactions), [Gaze input sample (basic)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-gazeinput-basic.zip), [Windows Community Toolkit Gaze library](/windows/uwpcommunitytoolkit/gaze/gazeinteractionlibrary)

## -examples
