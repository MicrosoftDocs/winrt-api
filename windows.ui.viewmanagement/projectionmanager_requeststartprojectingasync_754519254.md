---
-api-id: M:Windows.UI.ViewManagement.ProjectionManager.RequestStartProjectingAsync(System.Int32,System.Int32,Windows.Foundation.Rect,Windows.UI.Popups.Placement)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<bool> RequestStartProjectingAsync(System.Int32 projectionViewId, System.Int32 anchorViewId, Windows.Foundation.Rect selection, Windows.UI.Popups.Placement prefferedPlacement)
-->

# Windows.UI.ViewManagement.ProjectionManager.RequestStartProjectingAsync

## -description
Makes a request to asynchronously sends a window (app view) to the projector or other secondary display with the specified preferred placement.

## -parameters
### -param projectionViewId
The new ID of the window to be displayed by the projector or other secondary display.

### -param anchorViewId
The ID of the original window before projection.

### -param selection
The area to one side of which the flyout is displayed.

### -param prefferedPlacement
The side of the rectangle where the flyout should appear.

## -returns
**true** if projection started; otherwise, **false**.

## -remarks

## -examples

## -see-also
[RequestStartProjectingAsync(Int32, Int32, Rect)](projectionmanager_requeststartprojectingasync_968965102.md)