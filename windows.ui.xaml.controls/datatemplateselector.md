---
-api-id: T:Windows.UI.Xaml.Controls.DataTemplateSelector
-api-type: winrt class
---

<!-- Class syntax.
public class DataTemplateSelector : Windows.UI.Xaml.Controls.IDataTemplateSelector, Windows.UI.Xaml.Controls.IDataTemplateSelector2, Windows.UI.Xaml.Controls.IDataTemplateSelectorOverrides, Windows.UI.Xaml.Controls.IDataTemplateSelectorOverrides2
-->

# Windows.UI.Xaml.Controls.DataTemplateSelector

## -description
Enables custom template selection logic at the application level.



## -xaml-syntax
```xaml
See Remarks
```


## -remarks

For more info about data templates, see the [DataTemplate](../windows.ui.xaml/datatemplate.md) class and [Item containers and templates](/windows/uwp/design/controls-and-patterns/item-containers-templates).

The base DataTemplateSelector class is not used as an object element in XAML. However, it is a common scenario to derive a custom DataTemplateSelector, map an `xmlns` prefix for the custom class and its namespace/assembly, and then refer to an instance of the custom class as defined in a [Resources](../windows.ui.xaml/frameworkelement_resources.md) block in XAML. This makes it possible to refer to the custom template selector class by `x:Key`, and use that reference to set the value of properties such as [ItemTemplateSelector](itemscontrol_itemtemplateselector.md) in XAML templates and visual states.

The callable methods of DataTemplateSelector are the two [SelectTemplate](datatemplateselector_selecttemplate_375443783.md) overloads. The overridable methods of DataTemplateSelector are the two [SelectTemplateCore](datatemplateselector_selecttemplatecore_402628248.md) overloads. To define an effective DataTemplateSelector subclass, provide implementations for [SelectTemplateCore(Object)](datatemplateselector_selecttemplatecore_402628248.md) and [SelectTemplateCore(Object, DependencyObject)](datatemplateselector_selecttemplatecore_711611086.md). All these methods return a [DataTemplate](../windows.ui.xaml/datatemplate.md) instance that's typically a specific choice that's appropriate for the inputs of the method that was called to obtain it.

App code typically doesn't call [SelectTemplate](datatemplateselector_selecttemplate_375443783.md) methods; the methods exists so that the infrastructure can call it while choosing the correct templates based on using a DataTemplateSelector instance from a property value such as [ItemsControl.ItemsTemplateSelector](itemscontrol_itemtemplateselector.md).

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1809 | 17763 | GetElement |
| 1809 | 17763 | RecycleElement |

## -examples

## -see-also
[ItemTemplateSelector](itemscontrol_itemtemplateselector.md), [DataTemplate](../windows.ui.xaml/datatemplate.md), [ContentControl.ContentTemplateSelector](contentcontrol_contenttemplateselector.md), [GroupStyle.HeaderTemplateSelector](groupstyle_headertemplateselector.md)
