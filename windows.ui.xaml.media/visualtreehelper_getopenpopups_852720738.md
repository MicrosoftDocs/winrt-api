---
-api-id: M:Windows.UI.Xaml.Media.VisualTreeHelper.GetOpenPopups(Windows.UI.Xaml.Window)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.Collections.IVectorView<Windows.UI.Xaml.Controls.Primitives.Popup> GetOpenPopups(Windows.UI.Xaml.Window window)
-->

# Windows.UI.Xaml.Media.VisualTreeHelper.GetOpenPopups

## -description
Retrieves a collection of all open popup controls from the target [Window](../windows.ui.xaml/window.md).



## -parameters
### -param window
The current [Window](../windows.ui.xaml/window.md) instance to retrieve the popups from.

## -returns
The list of all open popups. If no popups are open, the list is empty.

## -remarks
Popups don't exist in the conventional XAML visual tree that begins from the root visual, although they are associated with the app main window. Unless your app maintains a list of all the [Popup](../windows.ui.xaml.controls.primitives/popup.md) elements you've created as well as a status (the [IsOpen](../windows.ui.xaml.controls.primitives/popup_isopen.md) value), it can be difficult to keep track of them. Sometimes you will want to clear all popups prior to initiating another UI action, like navigating the page or displaying a flyout. GetOpenPopups provides the utility so that you can get a reference to all these popups as [Popup](../windows.ui.xaml.controls.primitives/popup.md) instances, and then you would typically set [IsOpen](../windows.ui.xaml.controls.primitives/popup_isopen.md) to **false** on each of them.

Elements such as [AppBar](../windows.ui.xaml.controls/appbar.md) are not considered a popup, they are owned by the [Page](../windows.ui.xaml.controls/page.md). A [ToolTip](../windows.ui.xaml.controls/tooltip.md) is also not considered a popup, it's considered a child of the element that uses the [ToolTipService](../windows.ui.xaml.controls/tooltipservice.md) attached properties to host it. Both [AppBar](../windows.ui.xaml.controls/appbar.md) and [ToolTip](../windows.ui.xaml.controls/tooltip.md) elements are thus in the conventional XAML visual tree, even if they're not always displayed at the time. You could find these with [GetChild](visualtreehelper_getchild_2017450836.md) or other [VisualTreeHelper](visualtreehelper.md)API, or by walking the tree with **Child**/**Items**/**Children** and related properties if you know the exact structure by type.


## -examples

## -see-also
[Window](../windows.ui.xaml/window.md), [Popup](../windows.ui.xaml.controls.primitives/popup.md), [ToolTip](../windows.ui.xaml.controls/tooltip.md)
