---
-api-id: M:Windows.UI.Xaml.Controls.DataTemplateSelector.SelectTemplateCore(System.Object)
-api-type: winrt method
---

<!-- Method syntax
virtual protected Windows.UI.Xaml.DataTemplate SelectTemplateCore(System.Object item)
-->

# Windows.UI.Xaml.Controls.DataTemplateSelector.SelectTemplateCore

## -description
When implemented by a derived class, returns a specific [DataTemplate](../windows.ui.xaml/datatemplate.md) for a given item or container.



## -parameters
### -param item
The item to return a template for.

## -returns
The template to use for the given item and/or container.

## -remarks
If your [ItemsControl.ItemsPanel](itemscontrol_itemspanel.md) is an [ItemsStackPanel](itemsstackpanel.md) or [ItemsWrapGrid](itemswrapgrid.md), provide an override for the SelectTemplateCore(Object) method. If the [ItemsPanel](itemscontrol_itemspanel.md) is a different panel, such as [VirtualizingStackPanel](virtualizingstackpanel.md) or [WrapGrid](wrapgrid.md), provide an override for the [SelectTemplateCore(Object, DependencyObject)](datatemplateselector_selecttemplatecore_711611086.md) method.

> [!NOTE]
> In Windows 8.1, [ItemsStackPanel](itemsstackpanel.md) is the default [ItemsPanel](itemscontrol_itemspanel.md) for [ListView](listview.md), and [ItemsWrapGrid](itemswrapgrid.md) is the default [ItemsPanel](itemscontrol_itemspanel.md) for [GridView](gridview.md).

## -examples

## -see-also
[DataTemplate](../windows.ui.xaml/datatemplate.md), [SelectTemplateCore(Object, DependencyObject)](datatemplateselector_selecttemplatecore_711611086.md), [Adding ListView and GridView controls](/previous-versions/windows/apps/hh780618(v=win.10))
