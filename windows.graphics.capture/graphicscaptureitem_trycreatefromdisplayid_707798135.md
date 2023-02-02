---
-api-id: M:Windows.Graphics.Capture.GraphicsCaptureItem.TryCreateFromDisplayId(Windows.Graphics.DisplayId)
-api-type: winrt method
---

# Windows.Graphics.Capture.GraphicsCaptureItem.TryCreateFromDisplayId(Windows.Graphics.DisplayId)

<!--
public static Windows.Graphics.Capture.GraphicsCaptureItem TryCreateFromDisplayId (Windows.Graphics.DisplayId displayId);
-->


## -description

Attempts to create a [GraphicsCaptureItem](graphicscaptureitem.md) that represents the display with the specified [DisplayId](../windows.graphics/displayid.md).

## -parameters

### -param displayId

The **DisplayId** with which to construct the **GraphicsCaptureItem**.

## -returns

Upon success, returns a **GraphicsCaptureItem** that represents the given display.

## -remarks

Before attempting to create a **GraphicsCaptureItem** with this method, you must call [GraphicsCaptureAccess.RequestAccessAsync](graphicscaptureaccess_requestaccessasync_1551329835.md), passing in a value of [GraphicsCaptureAccessKind.Programmatic](graphicscaptureaccesskind.md). To call **RequestAccessAsync** with **GraphicsCaptureAccessKind.Programmatic**, you must declare the **graphicsCaptureProgrammatic** capability in your app's package manifest. For more information, see [App capability declarations](/windows/uwp/packaging/app-capability-declarations).

## -see-also

[Windows.Graphics.Capture namespace](windows_graphics_capture.md),
[Windows.Graphics.Capture.GraphicsCaptureItem class](graphicscaptureitem.md),
[DisplayId](../windows.graphics/displayid.md),
[Screen capture](/windows/uwp/audio-video-camera/screen-capture)

## -examples


