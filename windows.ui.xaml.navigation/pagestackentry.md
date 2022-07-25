---
-api-id: T:Windows.UI.Xaml.Navigation.PageStackEntry
-api-type: winrt class
---

<!-- Class syntax.
public class PageStackEntry : Windows.UI.Xaml.DependencyObject, Windows.UI.Xaml.Navigation.IPageStackEntry
-->

# Windows.UI.Xaml.Navigation.PageStackEntry

## -description
Represents an entry in the [BackStack](../windows.ui.xaml.controls/frame_backstack.md) or [ForwardStack](../windows.ui.xaml.controls/frame_forwardstack.md) of a [Frame](../windows.ui.xaml.controls/frame.md).



## -remarks
This class contains info about a specific navigation in the history of a [Frame](../windows.ui.xaml.controls/frame.md). It typically represents entries in the [BackStack](../windows.ui.xaml.controls/frame_backstack.md) and [ForwardStack](../windows.ui.xaml.controls/frame_forwardstack.md) as a result of previous [Frame](../windows.ui.xaml.controls/frame.md) navigations. You can also use this class to add new entries to the navigation history for special purposes. For example, when the user navigates to a specific page using a secondary tile, you can add an entry for the app's main page to the [BackStack](../windows.ui.xaml.controls/frame_backstack.md). This will enable the back button on the secondary tile's page so that the user can easily navigate from there to the home page.

## -examples

## -see-also
[DependencyObject](../windows.ui.xaml/dependencyobject.md)
