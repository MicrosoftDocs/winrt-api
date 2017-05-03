---
-api-id: M:Windows.UI.ViewManagement.ApplicationViewSwitcher.TryShowAsViewModeAsync(System.Int32,Windows.UI.ViewManagement.ApplicationViewMode,Windows.UI.ViewManagement.ViewModePreferences)
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<bool> ApplicationViewSwitcher.TryShowAsViewModeAsync(Int32 viewId, ApplicationViewMode viewMode, ViewModePreferences viewModePreferences)
-->

# Windows.UI.ViewManagement.ApplicationViewSwitcher.TryShowAsViewModeAsync

## -description
Displays a view as a standalone view in the desired view mode with the specified options.

## -parameters

### -param viewId
The ID of the window to display.

### -param viewMode
The desired view mode for the window.

### -param viewModePreferences
Preferred settings for the desired view mode.

## -returns
Asynchronously returns **true** if the call succeeds; **false** if it does not.

## -remarks
If this method succeeds, a new window is created next to the original window. It can only be called from an ASTA (core UI) thread.

The new window has its own UI thread (ASTA) and associated [CoreWindow](../windows.ui.core/corewindow.md). Developers should use thread-safe methods for communication between the windows, such as **window.postMessage** for JavaScript apps and the [CoreDispatcher](../windows.ui.core/coredispatcher.md) ([CoreWindow.Dispatcher](../windows.ui.core/corewindow_dispatcher.md)) messaging for C# and C++ developers.

## -see-also

## -examples

