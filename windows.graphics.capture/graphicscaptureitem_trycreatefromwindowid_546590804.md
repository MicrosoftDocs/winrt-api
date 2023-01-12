---
-api-id: M:Windows.Graphics.Capture.GraphicsCaptureItem.TryCreateFromWindowId(Windows.UI.WindowId)
-api-type: winrt method
---

# Windows.Graphics.Capture.GraphicsCaptureItem.TryCreateFromWindowId(Windows.UI.WindowId)

<!--
public static Windows.Graphics.Capture.GraphicsCaptureItem TryCreateFromWindowId (Windows.UI.WindowId windowId);
-->


## -description

Attempts to create a [GraphicsCaptureItem](graphicscaptureitem.md) that represents the window with the specified [WindowId](../windows.ui/windowid.md).


## -parameters

### -param windowId

The **WindowId** with which to construct the **GraphicsCaptureItem**.

## -returns

Upon success, returns a **GraphicsCaptureItem** that represents the given window.

## -remarks

Before attempting to create a **GraphicsCaptureItem** with this method, you must call [GraphicsCaptureAccess.RequestAccessAsync](graphicscaptureaccess_requestaccessasync_1551329835.md), passing in a value of [GraphicsCaptureAccessKind.Programmatic](graphicscaptureaccesskind.md). To call **RequestAccessAsync** with **GraphicsCaptureAccessKind.Programmatic**, you must declare the **graphicsCaptureProgrammatic** capability in your app's package manifest. For more information, see [App capability declarations](/windows/uwp/packaging/app-capability-declarations).

## -see-also

## -examples


