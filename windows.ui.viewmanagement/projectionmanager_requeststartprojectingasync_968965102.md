---
-api-id: M:Windows.UI.ViewManagement.ProjectionManager.RequestStartProjectingAsync(System.Int32,System.Int32,Windows.Foundation.Rect)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<bool> RequestStartProjectingAsync(System.Int32 projectionViewId, System.Int32 anchorViewId, Windows.Foundation.Rect selection)
-->

# Windows.UI.ViewManagement.ProjectionManager.RequestStartProjectingAsync

## -description
Makes a request to asynchronously sends a window (app view) to the projector or other secondary display.

## -parameters
### -param projectionViewId
The new ID of the window to be displayed by the projector or other secondary display.

### -param anchorViewId
The ID of the original window before projection.

### -param selection
The area to one side of which the flyout is displayed.

## -returns
**true** if projection started; otherwise, **false**.

## -remarks

## -examples

## -see-also
[RequestStartProjectingAsync(Int32, Int32, Rect, Placement)](projectionmanager_requeststartprojectingasync_754519254.md)