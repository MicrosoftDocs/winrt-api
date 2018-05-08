---
-api-id: E:Windows.Devices.Input.Preview.GazeInputSourcePreview.GazeMoved
-api-type: winrt event
---

<!-- Event syntax.
public event TypedEventHandler GazeMoved<GazeInputSourcePreview, GazeMovedPreviewEventArgs>
-->

# Windows.Devices.Input.Preview.GazeInputSourcePreview.GazeMoved

## -description

Occurs when the eye-tracking device detects eye movement and the [gaze pointer](gazepointpreview.md) remains within the bounding rectangle of the element.

## -remarks

This event can fire a lot. Be aware of the performance profile for code you put into the handler, and consider ways to use your own flags or tolerances that can throttle how many times the logic actually needs to run.

## -see-also

### Conceptual

[Gaze interactions and eye tracking in UWP apps](https://docs.microsoft.com/windows/uwp/design/input/gaze-interactions)

### Reference

- [GazeMovedPreviewEventArgs](gazemovedprevieweventargs.md)
- [GazeExited](gazeinputsourcepreview_gazeexited.md)
- [GazeEntered](gazeinputsourcepreview_gazeentered.md)

## -examples

