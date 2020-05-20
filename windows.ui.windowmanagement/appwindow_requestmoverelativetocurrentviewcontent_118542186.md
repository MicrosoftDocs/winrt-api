---
-api-id: M:Windows.UI.WindowManagement.AppWindow.RequestMoveRelativeToCurrentViewContent(Windows.Foundation.Point)
-api-type: winrt method
---

<!-- Method syntax.
public void AppWindow.RequestMoveRelativeToCurrentViewContent(Point contentOffset)
-->

# Windows.UI.WindowManagement.AppWindow.RequestMoveRelativeToCurrentViewContent

## -description

Makes a request to position the window at the specified offset relative to the current view.

## -parameters

### -param contentOffset

The offset of the window relative to the current view.

## -remarks

If the [AppWindow.WindowingEnvironment](appwindow_windowingenvironment.md) is `Tiled`, the window is placed on the same [DisplayRegion](displayregion.md) as the current view.

## -see-also

## -examples

