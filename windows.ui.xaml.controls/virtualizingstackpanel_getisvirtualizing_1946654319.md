---
-api-id: M:Windows.UI.Xaml.Controls.VirtualizingStackPanel.GetIsVirtualizing(Windows.UI.Xaml.DependencyObject)
-api-type: winrt method
---

<!-- Method syntax
public bool GetIsVirtualizing(Windows.UI.Xaml.DependencyObject o)
-->

# Windows.UI.Xaml.Controls.VirtualizingStackPanel.GetIsVirtualizing

## -description
Gets a value that determines whether an item is currently being virtualized as part of an items set where the [ItemsPanel](itemscontrol_itemspanel.md) is templated with a [VirtualizingStackPanel](virtualizingstackpanel.md).



## -parameters
### -param o
The object item where you want to determine the current virtualization state.

## -returns
**true** if the item specified by *o* is currently virtualizing its content; otherwise, **false**.

## -remarks
**VirtualizingStackPanel.IsVirtualizing** uses the attached property model as a property store, but does not support a XAML usage. Instead, the property serves as a sentinel that any [VirtualizingStackPanel](virtualizingstackpanel.md) child element can check to determine whether that child is currently being represented as virtualized. To find out if an item is being virtualized, call GetIsVirtualizing, passing the item as the input parameter.

## -examples

## -see-also
