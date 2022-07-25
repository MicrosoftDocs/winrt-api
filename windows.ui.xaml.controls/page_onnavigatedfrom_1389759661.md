---
-api-id: M:Windows.UI.Xaml.Controls.Page.OnNavigatedFrom(Windows.UI.Xaml.Navigation.NavigationEventArgs)
-api-type: winrt method
---

<!-- Method syntax
virtual protected void OnNavigatedFrom(Windows.UI.Xaml.Navigation.NavigationEventArgs e)
-->

# Windows.UI.Xaml.Controls.Page.OnNavigatedFrom

## -description
Invoked immediately after the [Page](page.md) is unloaded and is no longer the current source of a parent [Frame](frame.md).



## -parameters
### -param e
Event data that can be examined by overriding code. The event data is representative of the navigation that has unloaded the current [Page](page.md).

## -remarks

OnNavigatedFrom is invoked by default when you navigate between pages in your app. You can override this method and get info about the navigation from the NavigationEventArgs, and take any action required by your app. However, you should avoid changing the state of the page by unregistering event handlers or doing other cleanup, especially in apps that call [Frame.GetNavigationState](frame_getnavigationstate_1352043812.md) on suspend.

### On suspending

In addition to being invoked when navigating between pages, the OnNavigatedFrom method is invoked when the app is suspended if [Frame.GetNavigationState](frame_getnavigationstate_1352043812.md) is called in the [Application.Suspending](../windows.ui.xaml/application_suspending.md) event handler.

While it seems natural to use OnNavigatedFrom to unregister event handlers that were registered in [OnNavigatedTo](page_onnavigatedto_1083052518.md), this can lead to problems if your app saves its state on suspend. Saving state on suspend typically involves calling Frame.GetNavigationState, which then calls Page.OnNavigatedFrom on the current page, which signals the page to persist/serialize any state it retains on back navigation or rehydration. If the app is suspended and then resumed (without a termination and relaunch), any event handlers unregistered in OnNavigatedFrom won't be re-registered because Page.OnNavigatedTo isn't called on resume.

To avoid this issue, you should instead use [OnNavigatingFrom](page_onnavigatingfrom_425696585.md) or the [Unloaded](../windows.ui.xaml/frameworkelement_unloaded.md) event, which are only called on actual navigation, to unregister event handlers and do other cleanup.

## -examples

## -see-also
