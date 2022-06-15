---
-api-id: M:Windows.UI.Xaml.Controls.ListBox.ScrollIntoView(System.Object)
-api-type: winrt method
---

<!-- Method syntax
public void ScrollIntoView(System.Object item)
-->

# Windows.UI.Xaml.Controls.ListBox.ScrollIntoView

## -description
Causes the object to scroll into view.

Equivalent **WinUI 2 API for UWP**: [Microsoft.UI.Xaml.Controls.ListBox.ScrollIntoView](/windows/winui/api/microsoft.ui.xaml.controls.listbox.scrollintoview) (for WinUI in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -parameters
### -param item
The object to scroll to.

## -remarks
When the contents of the [ItemsSource](itemscontrol_itemssource.md) collection changes, particularly if many items are added to or removed from the collection, you might need to call [UpdateLayout](../windows.ui.xaml/uielement_updatelayout_1243658106.md) prior to calling ScrollIntoView for the specified item to scroll into the viewport.

## -examples

## -see-also
