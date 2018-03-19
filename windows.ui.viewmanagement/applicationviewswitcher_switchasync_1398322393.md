---
-api-id: M:Windows.UI.ViewManagement.ApplicationViewSwitcher.SwitchAsync(System.Int32)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction SwitchAsync(System.Int32 viewId)
-->

# Windows.UI.ViewManagement.ApplicationViewSwitcher.SwitchAsync

## -description
Visually replaces the calling window (app view) with a specified window.

## -parameters
### -param viewId
The ID of the window under preparation for display.

## -returns
The asynchronous results of the operation. Use this to determine when the async call is complete.

## -remarks
This method can only be called from the ASTA (core UI) thread of the calling, currently displayed window.

## -examples

## -see-also
[SwitchAsync(Int32, Int32)](applicationviewswitcher_switchasync_1708606889.md), [SwitchAsync(Int32, Int32, ApplicationViewSwitchingOptions)](applicationviewswitcher_switchasync_1967756911.md)
