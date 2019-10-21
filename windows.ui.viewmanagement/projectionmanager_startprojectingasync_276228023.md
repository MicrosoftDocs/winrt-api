---
-api-id: M:Windows.UI.ViewManagement.ProjectionManager.StartProjectingAsync(System.Int32,System.Int32,Windows.Devices.Enumeration.DeviceInformation)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction StartProjectingAsync(System.Int32 projectionViewId, System.Int32 anchorViewId, Windows.Devices.Enumeration.DeviceInformation displayDeviceInfo)
-->

# Windows.UI.ViewManagement.ProjectionManager.StartProjectingAsync

## -description
Asynchronously sends a window (app view) to the projector or other secondary display, and provides info about the display.

## -parameters
### -param projectionViewId
The new ID of the window to be displayed by the projector or other secondary display.

### -param anchorViewId
The ID of the original window before projection.

### -param displayDeviceInfo
Information about the display device.

## -returns
The asynchronous results of the operation. Use this to determine when the async call is complete.

## -remarks
If this method succeeds, an existing window (app view) is placed on a secondary display, if one is detected. Otherwise, the window is placed on the primary display. This window can only be accessed from an ASTA UI thread.

The moved window has its own ASTA UI thread and associated [CoreWindow](../windows.ui.core/corewindow.md). Always use thread-safe methods, such as [window.postMessage](https://developer.mozilla.org/en-US/docs/Web/API/Worker/postMessage) for JavaScript apps or the [CoreDispatcher](../windows.ui.core/coredispatcher.md) event messaging API for C# and C++ apps, when communicating between the windows.

Either the current app view window or the projection view window must be active for this call to succeed. The view ID can be obtained for the current app view with [ApplicationView.Id](applicationview_id.md). For a specific app view managed by the app, call [ApplicationView.GetApplicationViewIdForWindow](applicationview_getapplicationviewidforwindow_543884123.md) with the [CoreWindow](../windows.ui.core/corewindow.md) for the app view.

## -examples

## -see-also
[StartProjectingAsync(Int32, Int32)](projectionmanager_startprojectingasync_1909101429.md)