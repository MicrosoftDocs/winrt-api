---
-api-id: M:Windows.UI.ViewManagement.ApplicationView.GetApplicationViewIdForWindow(Windows.UI.Core.ICoreWindow)
-api-type: winrt method
---

<!-- Method syntax
public int GetApplicationViewIdForWindow(Windows.UI.Core.ICoreWindow window)
-->

# Windows.UI.ViewManagement.ApplicationView.GetApplicationViewIdForWindow

## -description
Gets the window ID that corresponds to a specific [CoreWindow](../windows.ui.core/corewindow.md) managed by the app.

## -parameters
### -param window
Reference to the [CoreWindow](../windows.ui.core/corewindow.md) object that contains a window handle used by the app.

## -returns
The ID of the window associated with the supplied [CoreWindow](../windows.ui.core/corewindow.md).

## -remarks
Every view has an associated [CoreWindow](../windows.ui.core/corewindow.md), which handles the core UI events for the window and manages drawing operations to the window. An app can have multiple views, with separate UI threads. Use this method to determine which window is provided by a specific [CoreWindow](../windows.ui.core/corewindow.md) instance managed by your app.

For languages other than Javascript, this is a static member of the [ApplicationView](applicationview.md) class. JavaScript does not support this method ([CoreWindow](../windows.ui.core/corewindow.md) is not available as an API).

## -examples

## -see-also
