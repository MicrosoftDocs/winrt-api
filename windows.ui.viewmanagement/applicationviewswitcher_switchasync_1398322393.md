---
-api-id: M:Windows.UI.ViewManagement.ApplicationViewSwitcher.SwitchAsync(System.Int32)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction SwitchAsync(System.Int32 viewId)
-->

# Windows.UI.ViewManagement.ApplicationViewSwitcher.SwitchAsync

## -description

Visually switches the calling window (app view) to another window.

## -parameters

### -param viewId

The ID of the window under preparation for display.

## -returns

The asynchronous results of the operation. Use this to determine when the async call is complete.

## -remarks

This method can only be called from the Application Single-Threaded Apartment (ASTA) thread of the calling, currently displayed window (core UI).

Unlike [SwitchAsync(System.Int32 toViewId, System.Int32 fromViewId)](applicationviewswitcher_switchasync_1708606889.md), this method infers *fromViewId* through the call from the ASTA thread.

## -examples

## -see-also

[SwitchAsync(Int32, Int32)](applicationviewswitcher_switchasync_1708606889.md), [SwitchAsync(Int32, Int32, ApplicationViewSwitchingOptions)](applicationviewswitcher_switchasync_1967756911.md)
