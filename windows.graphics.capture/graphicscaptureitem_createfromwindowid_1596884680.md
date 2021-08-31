---
-api-id: M:Windows.Graphics.Capture.GraphicsCaptureItem.CreateFromWindowId(Windows.UI.WindowId)
-api-type: winrt method
---

# Windows.Graphics.Capture.GraphicsCaptureItem.CreateFromWindowId(Windows.UI.WindowId)

<!--
public static Windows.Graphics.Capture.GraphicsCaptureItem CreateFromWindowId (Windows.UI.WindowId windowId);
-->


## -description

Constructs a [GraphicsCaptureItem](graphicscaptureitem.md) that represents the window with the specified [WindowId](../windows.ui/windowid.md).

## -parameters

### -param windowId

The **WindowId** with which to construct the **GraphicsCaptureItem**.

## -returns

A **GraphicsCaptureItem** that represents the given window.

## -remarks

To use this API, you must declare the **graphicsCaptureProgrammatic** capability in your app's package manifest. For more information, see [App capability declarations](/windows/uwp/packaging/app-capability-declarations).

## -see-also

[Windows.Graphics.Capture namespace](windows_graphics_capture.md),
[Windows.Graphics.Capture.GraphicsCaptureItem class](graphicscaptureitem.md),
[WindowId](../windows.ui/windowid.md),
[Screen capture](/windows/uwp/audio-video-camera/screen-capture)

## -examples


