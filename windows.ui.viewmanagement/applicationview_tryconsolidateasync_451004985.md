---
-api-id: M:Windows.UI.ViewManagement.ApplicationView.TryConsolidateAsync
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<bool> ApplicationView.TryConsolidateAsync()
-->

# Windows.UI.ViewManagement.ApplicationView.TryConsolidateAsync


## -description

Tries to hide the current app view. This method is a programmatic equivalent to a user initiating a close gesture for the app view.

## -returns

**true** if the app views are consolidated; otherwise, **false**.

## -remarks
Consolidating an app view doesn't close it but rather hides it from the Windows shell, regardless of whether the user closed the close (X) button or this method is called programmatically. 
It can still be shown programmatically by the app using the various methods of [ApplicationViewSwitcher. To close the app view permanently, call CoreWindow.Close.

## -see-also

## -examples

