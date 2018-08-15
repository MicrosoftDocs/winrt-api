---
-api-id: M:Windows.UI.ViewManagement.ApplicationViewSwitcher.PrepareForCustomAnimatedSwitchAsync(System.Int32,System.Int32,Windows.UI.ViewManagement.ApplicationViewSwitchingOptions)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<bool> PrepareForCustomAnimatedSwitchAsync(System.Int32 toViewId, System.Int32 fromViewId, Windows.UI.ViewManagement.ApplicationViewSwitchingOptions options)
-->

# Windows.UI.ViewManagement.ApplicationViewSwitcher.PrepareForCustomAnimatedSwitchAsync

## -description
Prepares your app to visually transition between two windows with a custom animation.

## -parameters
### -param toViewId
The ID of the window from which your app is transitioning.

### -param fromViewId
The ID of the window to which your app is transitioning.

### -param options
Enumeration value that specifies thw view switching behaviors.

## -returns
Asynchronously returns **true** if the call succeeds; **false** if it does not.

## -remarks
The view ID can be obtained for the current app view with [ApplicationView.Id](applicationview_id.md). For a specific app view managed by the app, call [ApplicationView.GetApplicationViewIdForWindow](applicationview_getapplicationviewidforwindow_543884123.md) with the [CoreWindow](../windows.ui.core/corewindow.md) for the app view.

## -examples

## -see-also
