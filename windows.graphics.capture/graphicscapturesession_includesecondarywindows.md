---
-api-id: P:Windows.Graphics.Capture.GraphicsCaptureSession.IncludeSecondaryWindows
-api-type: winrt property
---

# Windows.Graphics.Capture.GraphicsCaptureSession.IncludeSecondaryWindows

<!--
public bool IncludeSecondaryWindows { get; set; }
-->


## -description

Gets or sets a value indicating whether secondary windows are included in the capture session.

## -property-value

True if secondary windows are included in the capture session; otherwise, false.

## -remarks

The default value for this property is false. The property can be changed during the capture.

Secondary Windows are considered to be windows that have either the [WS_POPUP](/windows/win32/winmsg/window-styles) or [WS_EX_TOOLWINDOW](/windows/win32/winmsg/window-styles) styles that intersect the main window, and have only other qualifying secondary windows between it and the main window. The windows are drawn into the texture the app receives and are clipped if they go outside the bounds of the main top level window.



## -see-also

## -examples


