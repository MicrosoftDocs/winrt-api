---
-api-id: M:Windows.Devices.Input.Preview.GazeMovedPreviewEventArgs.GetIntermediatePoints
-api-type: winrt method
---

<!-- Method syntax.
public IVector<GazePointPreview> GazeMovedPreviewEventArgs.GetIntermediatePoints()
-->

# Windows.Devices.Input.Preview.GazeMovedPreviewEventArgs.GetIntermediatePoints

## -description

Retrieves the [gaze point](gazepointpreview.md) data for each gaze location logged since the most recent [GazeMoved](gazeinputsourcepreview_gazemoved.md) event, up to and including the current event.

## -returns

A collection of [gaze point](gazepointpreview.md) objects.

## -remarks

The screen coordinates of the gaze points are in device-independent pixels (DIP) relative to, and constrained by, the application view (or gaze-enabled element).

The most recent [gaze point](gazepointpreview.md) object retrieved by this method is equivalent to that retrieved by the [CurrentPoint](gazemovedprevieweventargs_currentpoint.md) method.

## -see-also

[Gaze interactions and eye tracking in UWP apps](/windows/uwp/design/input/gaze-interactions), [Gaze input sample (basic)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-gazeinput-basic.zip), [Windows Community Toolkit Gaze library](/windows/uwpcommunitytoolkit/gaze/gazeinteractionlibrary)

## -examples
