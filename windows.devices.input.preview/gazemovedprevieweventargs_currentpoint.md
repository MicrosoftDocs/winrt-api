---
-api-id: P:Windows.Devices.Input.Preview.GazeMovedPreviewEventArgs.CurrentPoint
-api-type: winrt property
---

<!-- Property syntax.
public GazePointPreview CurrentPoint { get; }
-->

# Windows.Devices.Input.Preview.GazeMovedPreviewEventArgs.CurrentPoint

## -description

Gets the [gaze pointer](gazepointpreview.md) data from the most recent [GazeMoved](gazeinputsourcepreview_gazemoved.md) event.

## -property-value

A [gaze pointer](gazepointpreview.md) object.

## -remarks

The screen coordinates of the gaze point are relative to, and constrained by, the application view (or window).

## -see-also

### Conceptual

[Gaze interactions and eye tracking in UWP apps](https://docs.microsoft.com/windows/uwp/design/input/gaze-interactions)

### Samples

[Gaze input sample (basic)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-gazeinput-basic.zip)

### Resources

[Windows Community Toolkit Gaze library](https://docs.microsoft.com/windows/uwpcommunitytoolkit/gaze/gazeinteractionlibrary)

## -examples
