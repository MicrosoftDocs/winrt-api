---
-api-id: M:Windows.UI.ViewManagement.ApplicationViewSwitcher.DisableShowingMainViewOnActivation
-api-type: winrt method
---

<!-- Method syntax
public void DisableShowingMainViewOnActivation()
-->

# Windows.UI.ViewManagement.ApplicationViewSwitcher.DisableShowingMainViewOnActivation

## -description
Disables the primary window (app view) when the app is activated, showing the most recently displayed window instead.

## -remarks
By default, the app object displays the main window of the app when it is first activated. This method forces the app to display the most recently displayed window upon subsequent activations. Note that the app must call this method before completing the first non-hosted activation, and the app must also only call [CoreWindow.Activate](../windows.ui.core/icorewindow_activate_1797342875.md) for hosted activations from the UI thread of the displayed window.

## -examples

## -see-also
[SwitchAsync](/uwp/api/windows.ui.viewmanagement.applicationviewswitcher.switchasync)