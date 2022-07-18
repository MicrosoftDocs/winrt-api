---
-api-id: T:Windows.UI.Xaml.DataTemplate
-api-type: winrt class
---

<!-- Class syntax.
public class DataTemplate : Windows.UI.Xaml.FrameworkTemplate, Windows.UI.Xaml.IDataTemplate
-->

# Windows.UI.Xaml.DataTemplate

## -description
Describes the visual structure of a data object. Use data binding for specific elements in the template that display the data values.



## -xaml-syntax
```xaml
<DataTemplate ...>
  templateContent
</DataTemplate>
 

```


## -remarks
A DataTemplate object is used as the value for these properties:
+ [ItemsControl.ItemTemplate](../windows.ui.xaml.controls/itemscontrol_itemtemplate.md) (which is inherited by various items controls such as [ListView](../windows.ui.xaml.controls/listview.md), [GridView](../windows.ui.xaml.controls/gridview.md), [ListBox](../windows.ui.xaml.controls/listbox.md))
+ [ContentControl.ContentTemplate](../windows.ui.xaml.controls/contentcontrol_contenttemplate.md) (which is inherited by various content controls such as [Button](../windows.ui.xaml.controls/button.md), [Frame](../windows.ui.xaml.controls/frame.md), [SettingsFlyout](../windows.ui.xaml.controls/settingsflyout.md))
+ **HeaderTemplate** and **FooterTemplate** properties of various items control classes
+ [ItemsPresenter.HeaderTemplate](../windows.ui.xaml.controls/itemspresenter_headertemplate.md) and [ItemsPresenter.FooterTemplate](../windows.ui.xaml.controls/itemspresenter_footertemplate.md)
+ **HeaderTemplate** and **FooterTemplate** properties of text controls such as [RichEditBox](../windows.ui.xaml.controls/richeditbox.md), [TextBox](../windows.ui.xaml.controls/textbox.md)
+ **HeaderTemplate** property of controls such as [ComboBox](../windows.ui.xaml.controls/combobox.md), [DatePicker](../windows.ui.xaml.controls/datepicker.md), [Hub](../windows.ui.xaml.controls/hub.md), [HubSection](../windows.ui.xaml.controls/hubsection.md), [Pivot](../windows.ui.xaml.controls/pivot.md), [Slider](../windows.ui.xaml.controls/slider.md), [TimePicker](../windows.ui.xaml.controls/timepicker.md), [ToggleSwitch](../windows.ui.xaml.controls/toggleswitch.md); some of these also have **FooterTemplate**

You typically use a DataTemplate to specify the visual representation of your data. DataTemplate objects are particularly useful when you are binding an [ItemsControl](../windows.ui.xaml.controls/itemscontrol.md) such as a [ListBox](../windows.ui.xaml.controls/listbox.md) to an entire collection. Without specific instructions, a [ListBox](../windows.ui.xaml.controls/listbox.md) displays the string representation of the objects in a collection. Use a DataTemplate to define the appearance of each of your data objects. The content of your DataTemplate becomes the visual structure of your data objects.

You typically use data binding in a DataTemplate. For example, suppose that a [ListBox](../windows.ui.xaml.controls/listbox.md) is bound to a collection of `Customer` objects and has the [ItemTemplate](../windows.ui.xaml.controls/itemscontrol_itemtemplate.md) property set to a DataTemplate. When the [ListBox](../windows.ui.xaml.controls/listbox.md) is created, a [ListBoxItem](../windows.ui.xaml.controls/listboxitem.md) is created for each `Customer` in the collection, and the [DataContext](frameworkelement_datacontext.md) of the [ListBoxItem](../windows.ui.xaml.controls/listboxitem.md) is set to the appropriate customer. In other words, the [DataContext](frameworkelement_datacontext.md) of the first [ListBoxItem](../windows.ui.xaml.controls/listboxitem.md) is set to the first customer, the [DataContext](frameworkelement_datacontext.md) of the second [ListBoxItem](../windows.ui.xaml.controls/listboxitem.md) is set to the second customer, and so on. You can bind elements in the DataTemplate to show property values that come from each of the `Customer` objects.

You can also use a DataTemplate to share [UIElement](uielement.md) objects across multiple [ContentControl](../windows.ui.xaml.controls/contentcontrol.md) objects. For example, suppose you need multiple buttons on your application to have the same graphic. You can create a DataTemplate that contains the graphic and use it as the [ContentTemplate](../windows.ui.xaml.controls/contentcontrol_contenttemplate.md) for the buttons. A data template for [ContentTemplate](../windows.ui.xaml.controls/contentcontrol_contenttemplate.md) can also use data binding. But in this case the data context is the same as the element where the template's applied. Usually this is one data object, and there's no concept of items.

You can place a DataTemplate as the direct child of an [ItemTemplate](../windows.ui.xaml.controls/itemscontrol_itemtemplate.md) property element in XAML. This is know as an *inline template* and you'd do this if you had no need to use that same data template for other areas of your UI. You can also define a DataTemplate as a resource and then reference the resource as the value of the [ItemTemplate](../windows.ui.xaml.controls/itemscontrol_itemtemplate.md) property. Once it's a resource, you can use the same template for multiple UI elements that need a data template. If you factor the data template into [Application.Resources](application_resources.md), you can even share the same template for different pages of your UI.

The XAML usage for contents of a data template is not exposed as a settable code property. It is special behavior built into the XAML processing for a DataTemplate.

For advanced data binding scenarios, you might want to have properties of the data determine which template should produce their UI representations. For this scenario, you can use a [DataTemplateSelector](../windows.ui.xaml.controls/datatemplateselector.md) and set properties such as [ItemTemplateSelector](../windows.ui.xaml.controls/itemscontrol_itemtemplateselector.md) to assign it to a data view. A [DataTemplateSelector](../windows.ui.xaml.controls/datatemplateselector.md) is a logic class you write yourself, which has a method that returns exactly one DataTemplate to the binding engine based on your own logic interacting with your data. For more info, see [Data binding in depth](/windows/uwp/data-binding/data-binding-in-depth).

### XAML attached properties

DataTemplate is the host service class for a [XAML attached property](/windows/uwp/xaml-platform/attached-properties-overview).

In order to support XAML processor access to the attached properties, and also to expose equivalent _get_ and _set_ operations to code, each XAML attached property has a pair of Get and Set accessor methods. Another way to get or set the value in code is to use the dependency property system, calling either [GetValue](dependencyobject_getvalue_1188551207.md) or [SetValue](dependencyobject_setvalue_52578133.md) and passing the identifier field as the dependency property identifier.

| Attached property | Description |
| - | - |
| [ExtensionInstance](datatemplate_extensioninstance.md) | Gets or sets an extension instance that defines helper methods for phased rendering of a data template. |

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1809 | 17763 | GetElement |
| 1809 | 17763 | RecycleElement |

## -examples
The following example uses a DataTemplate to display the items of a [ListBox](../windows.ui.xaml.controls/listbox.md). In this example, the [ListBox](../windows.ui.xaml.controls/listbox.md) is bound to a collection of `Customer` objects. The DataTemplate contains [TextBlock](../windows.ui.xaml.controls/textblock.md) controls that bind to the `FirstName`, `LastName`, and `Address` properties. For more info on data binding, see [Data binding in depth](/windows/uwp/data-binding/data-binding-in-depth).




[!code-xaml[Snippet4_XAML](../windows.ui.xaml.data/code/System.Windows.Controls.ListBoxEx/csharp/Page.xaml#Snippet4_XAML)]




[!code-csharp[Snippet101_CS](../windows.ui.xaml.data/code/System.Windows.Controls.ListBoxEx/csharp/Page.xaml.cs#Snippet101_CS)]


[!code-vb[Snippet101_VB](../windows.ui.xaml.data/code/System.Windows.Controls.ListBoxEx/vbnet/Page.xaml.vb#Snippet101_VB)]

## -see-also
[FrameworkTemplate](frameworktemplate.md), [ItemsControl.ItemTemplate](../windows.ui.xaml.controls/itemscontrol_itemtemplate.md), [ContentControl.ContentTemplate](../windows.ui.xaml.controls/contentcontrol_contenttemplate.md), [DataTemplateSelector](../windows.ui.xaml.controls/datatemplateselector.md), [Data binding in depth](/windows/uwp/data-binding/data-binding-in-depth), [ResourceDictionary and XAML resource references](/windows/apps/design/style/xaml-resource-dictionary)
