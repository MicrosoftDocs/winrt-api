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

The most recent [gaze point](gazepointpreview.md) object retrieved by this method is equivalent to that retrieved by the [CurrentPoint](gazemovedprevieweventargs_currentpoint.md) method.

## -see-also

### Conceptual

[Gaze interactions and eye tracking in UWP apps](https://docs.microsoft.com/windows/uwp/design/input/gaze-interactions)

## -examples

