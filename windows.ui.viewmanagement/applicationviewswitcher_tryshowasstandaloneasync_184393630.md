---
-api-id: M:Windows.UI.ViewManagement.ApplicationViewSwitcher.TryShowAsStandaloneAsync(System.Int32)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<bool> TryShowAsStandaloneAsync(System.Int32 viewId)
-->

# Windows.UI.ViewManagement.ApplicationViewSwitcher.TryShowAsStandaloneAsync

## -description
Displays another window (app view) for the app on the screen, adjacent to the original window

## -parameters
### -param viewId
The ID of the new window to display.

## -returns
Asynchronously returns **true** if the call succeeds; **false** if it does not.

## -remarks
If this method succeeds, a new window is created next to the original window. It can only be called from an ASTA (core UI) thread.

The new window has its own UI thread (ASTA) and associated [CoreWindow](../windows.ui.core/corewindow.md). Developers should use thread-safe methods for communication between the windows, such as **window.postMessage** for JavaScript apps and the [CoreDispatcher](../windows.ui.core/coredispatcher.md) ([CoreWindow.Dispatcher](../windows.ui.core/corewindow_dispatcher.md)) messaging for C# and C++ developers.

## -examples

## -see-also
[TryShowAsStandaloneAsync(Int32, ViewSizePreference)](applicationviewswitcher_tryshowasstandaloneasync_825806666.md), [TryShowAsStandaloneAsync(Int32, ViewSizePreference, Int32, ViewSizePreference)](applicationviewswitcher_tryshowasstandaloneasync_1288540426.md)