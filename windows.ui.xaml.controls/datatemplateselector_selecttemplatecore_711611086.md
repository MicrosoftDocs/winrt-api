---
-api-id: M:Windows.UI.Xaml.Controls.DataTemplateSelector.SelectTemplateCore(System.Object,Windows.UI.Xaml.DependencyObject)
-api-type: winrt method
---

<!-- Method syntax
virtual protected Windows.UI.Xaml.DataTemplate SelectTemplateCore(System.Object item, Windows.UI.Xaml.DependencyObject container)
-->

# Windows.UI.Xaml.Controls.DataTemplateSelector.SelectTemplateCore

## -description
When implemented by a derived class, returns a specific [DataTemplate](../windows.ui.xaml/datatemplate.md) for a given item or container.

## -parameters
### -param item
The item to return a template for.

### -param container
The parent container for the templated item.

## -returns
The template to use for the given item and/or container.

## -remarks
Most implementations will choose to implement the selection logic based on the value of either *item* or *container*, not both. Implementations should still pass the unused parameter as-is to base.

## -examples

## -see-also
[DataTemplate](../windows.ui.xaml/datatemplate.md), [SelectTemplateCore(Object)](datatemplateselector_selecttemplatecore_402628248.md), [Adding ListView and GridView controls](https://msdn.microsoft.com/library/ede8164f-ad0f-4249-b5ab-6f46ca65754a)
