---
-api-id: M:Windows.UI.Xaml.Controls.Page.OnNavigatedTo(Windows.UI.Xaml.Navigation.NavigationEventArgs)
-api-type: winrt method
---

<!-- Method syntax
virtual protected void OnNavigatedTo(Windows.UI.Xaml.Navigation.NavigationEventArgs e)
-->

# Windows.UI.Xaml.Controls.Page.OnNavigatedTo

## -description
Invoked when the [Page](page.md) is loaded and becomes the current source of a parent [Frame](frame.md).

## -parameters
### -param e
Event data that can be examined by overriding code. The event data is representative of the pending navigation that will load the current [Page](page.md). Usually the most relevant property to examine is [Parameter](../windows.ui.xaml.navigation/navigationeventargs_parameter.md).

## -remarks
Unlike in prior XAML platforms, the [OnNavigated](page_onnavigatedto_1083052518.md) method is called before the visual tree is loaded. This has the following implications:
+ You cannot access a valid [Parent](../windows.ui.xaml/frameworkelement_parent.md) property value from an override of [OnNavigated](page_onnavigatedto_1083052518.md). If you need to access the [Parent](../windows.ui.xaml/frameworkelement_parent.md) property, do so in a [Loaded](../windows.ui.xaml/frameworkelement_loaded.md) event handler.
+ You cannot use [OnNavigatedTo](page_onnavigatedto_1083052518.md) for element manipulation or state change of controls on the destination page. Instead, attach a [Loaded](../windows.ui.xaml/frameworkelement_loaded.md) event handler at the root of the newly loaded page's content, and perform any element manipulations, state changes, event wiring and so on in the [Loaded](../windows.ui.xaml/frameworkelement_loaded.md) event handler.


## -examples

## -see-also
