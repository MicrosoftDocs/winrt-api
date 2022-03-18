---
-api-id: M:Windows.UI.WindowManagement.AppWindow.RequestMoveRelativeToDisplayRegion(Windows.UI.WindowManagement.DisplayRegion,Windows.Foundation.Point)
-api-type: winrt method
ms.custom: 19H1
---

<!-- Method syntax.
public void AppWindow.RequestMoveRelativeToDisplayRegion(DisplayRegion displayRegion, Point displayRegionOffset)
-->

# Windows.UI.WindowManagement.AppWindow.RequestMoveRelativeToDisplayRegion

## -description

Makes a request to position the window in the specified display region at the specified offset.

## -parameters

### -param displayRegion

The display region to move the window to.

### -param displayRegionOffset

The offset of the window in the display region.

## -remarks

The `displayRegionOffset` parameter is ignored if the [AppWindow.WindowingEnvironment](appwindow_windowingenvironment.md) is `Tiled`.

## -see-also

## -examples

