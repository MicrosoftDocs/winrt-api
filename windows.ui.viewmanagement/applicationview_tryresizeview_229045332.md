---
-api-id: M:Windows.UI.ViewManagement.ApplicationView.TryResizeView(Windows.Foundation.Size)
-api-type: winrt method
---

<!-- Method syntax
public bool TryResizeView(Windows.Foundation.Size value)
-->

# Windows.UI.ViewManagement.ApplicationView.TryResizeView

## -description
Attempts to change the size of the view to the specified size in effective pixels.

## -parameters
### -param value
The new size of the view in effective pixels.

## -returns
**true** if the view is resized to the requested size; otherwise, **false**.

## -remarks
A resize request affects only the view it was requested on. Resizing one view does not affect the size of any other views.

Even when this method returns **false**, the user can manually resize the view and cause a [SizeChanged](../windows.ui.core/corewindow_sizechanged.md) event to occur.

If the resize forces parts of the app to go outside of available work area, the system will move it back into the available work area.


The resize request has no effect and the method returns false in these cases:

+ The requested size is larger than the available work area.
+ The requested size is less than the view's minimum size. (See [SetPreferredMinSize](applicationview_setpreferredminsize_991571047.md).)
+ This method is called while in while the app is running in Tablet Mode.


We recommend that you not begin any layout work until the window's [SizeChanged](../windows.ui.core/corewindow_sizechanged.md) event occurs. This avoids two different layout passes (one that happens immediately after [TryResizeView](applicationview_tryresizeview_229045332.md) and then another when the [SizeChanged](../windows.ui.core/corewindow_sizechanged.md) event occurs).

## -examples

## -see-also
[Window resizing sample](https://go.microsoft.com/fwlink/p/?LinkId=620026), [
      Responsive design 101 for ](https://msdn.microsoft.com/library/bf42e810-cdc8-47d2-9c30-baa19dcbe2da)
