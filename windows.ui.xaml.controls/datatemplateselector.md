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

For more info about data templates, see the [DataTemplate](../windows.ui.xaml/datatemplate.md) class and [Item containers and templates](https://docs.microsoft.com/windows/uwp/design/controls-and-patterns/item-containers-templates).

The base [DataTemplateSelector](datatemplateselector.md) class is not used as an object element in XAML. However, it is a common scenario to derive a custom [DataTemplateSelector](datatemplateselector.md), map a xmlns prefix for the custom class and its namespace/assembly, and then refer to an instance of the custom class as defined in a [Resources](../windows.ui.xaml/frameworkelement_resources.md) block in XAML. This makes it possible to refer to the custom template selector class by **x:Key**, and use that reference to set the value of properties such as [ItemTemplateSelector](itemscontrol_itemtemplateselector.md) in XAML templates and visual states.

The callable methods of [DataTemplateSelector](datatemplateselector.md) are the two [SelectTemplate](datatemplateselector_selecttemplate_375443783.md) overloads. The overridable methods of [DataTemplateSelector](datatemplateselector.md) are the two [SelectTemplateCore](datatemplateselector_selecttemplatecore_402628248.md) overloads. To define an effective [DataTemplateSelector](datatemplateselector.md) subclass, provide implementations for [SelectTemplateCore(Object)](datatemplateselector_selecttemplatecore_402628248.md) and [SelectTemplateCore(Object, DependencyObject)](datatemplateselector_selecttemplatecore_711611086.md). All these methods return a [DataTemplate](../windows.ui.xaml/datatemplate.md) instance that's typically a specific choice that's appropriate for the inputs of the method that was called to obtain it.

App code typically doesn't call [SelectTemplate](datatemplateselector_selecttemplate_375443783.md) methods; the methods exists so that the infrastructure can call it while choosing the correct templates based on using a [DataTemplateSelector](datatemplateselector.md) instance from a property value such as [ItemsControl.ItemsTemplateSelector](itemscontrol_itemtemplateselector.md).

For example XAML that references a custom [DataTemplateSelector](datatemplateselector.md) as the [HeaderTemplateSelector](groupstyle_headertemplateselector.md) value, and example code that shows the overrides for [HeaderTemplateSelector](groupstyle_headertemplateselector.md) methods, see [How to group items in a list or grid](https://msdn.microsoft.com/library/b9ed59b9-651c-40c7-a39c-c4db432dc132).

## -examples

## -see-also
[ItemTemplateSelector](itemscontrol_itemtemplateselector.md), [DataTemplate](../windows.ui.xaml/datatemplate.md), [ContentControl.ContentTemplateSelector](contentcontrol_contenttemplateselector.md), [GroupStyle.HeaderTemplateSelector](groupstyle_headertemplateselector.md), [ItemsControl.ItemsTemplateSelector](itemscontrol_itemtemplateselector.md), [How to group items in a list or grid](https://msdn.microsoft.com/library/b9ed59b9-651c-40c7-a39c-c4db432dc132), [Adding ListView and GridView controls](https://msdn.microsoft.com/library/ede8164f-ad0f-4249-b5ab-6f46ca65754a)
