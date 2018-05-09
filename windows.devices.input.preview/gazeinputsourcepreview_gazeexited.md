---
-api-id: E:Windows.Devices.Input.Preview.GazeInputSourcePreview.GazeExited
-api-type: winrt event
---

<!-- Event syntax.
public event TypedEventHandler GazeExited<GazeInputSourcePreview, GazeExitedPreviewEventArgs>
-->

# Windows.Devices.Input.Preview.GazeInputSourcePreview.GazeExited

## -description

Occurs when the eye-tracking device detects that the [gaze point](gazepointpreview.md) has moved outside the bounding area of the element.

## -remarks

This event fires only in response to a [gaze point](gazepointpreview.md) leaving the bounding area of an element where a [GazeEntered](gazeinputsourcepreview_gazeentered.md) event already occurred.

## -see-also

### Conceptual

[Gaze interactions and eye tracking in UWP apps](https://docs.microsoft.com/windows/uwp/design/input/gaze-interactions)

### Reference

- [GazeEntered](gazeinputsourcepreview_gazeentered.md)
- [GazeMoved](gazeinputsourcepreview_gazemoved.md)

## -examples

