---
-api-id: M:Windows.UI.ViewManagement.ApplicationView.TryConsolidateAsync
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<bool> ApplicationView.TryConsolidateAsync()
-->

# Windows.UI.ViewManagement.ApplicationView.TryConsolidateAsync


## -description

Tries to hide the current app view. This method is a programmatic equivalent to a user closing the app.

## -returns

**true** if the app views are consolidated; otherwise, **false**.

## -remarks

Consolidating an app view doesn't close it but rather hides it from the Windows shell, whether the user closed the app or this method is called programmatically. It can still be shown programmatically by the app using the various methods of [ApplicationViewSwitcher](/uwp/api/windows.ui.viewmanagement.applicationviewswitcher). To close the app view permanently, call [CoreWindow.Close](/uwp/api/windows.ui.core.corewindow.close).

## -see-also

## -examples

