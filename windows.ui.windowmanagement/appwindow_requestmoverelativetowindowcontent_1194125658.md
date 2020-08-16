---
-api-id: M:Windows.UI.WindowManagement.AppWindow.RequestMoveRelativeToWindowContent(Windows.UI.WindowManagement.AppWindow,Windows.Foundation.Point)
-api-type: winrt method
---

<!-- Method syntax.
public void AppWindow.RequestMoveRelativeToWindowContent(AppWindow anchorWindow, Point contentOffset)
-->

# Windows.UI.WindowManagement.AppWindow.RequestMoveRelativeToWindowContent

## -description

Makes a request to position the window at the specified offset relative to the anchor window.

## -parameters

### -param anchorWindow

The window to position this window relative to.

### -param contentOffset

The offset of the window relative to the anchor window.

## -remarks

If the [AppWindow.WindowingEnvironment](appwindow_windowingenvironment.md) is `Tiled`, the window is placed on the same [DisplayRegion](displayregion.md) as the anchor window.

## -see-also

## -examples

