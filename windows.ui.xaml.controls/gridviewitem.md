---
-api-id: T:Windows.UI.Xaml.Controls.GridViewItem
-api-type: winrt class
---

<!-- Class syntax.
public class GridViewItem : Windows.UI.Xaml.Controls.Primitives.SelectorItem, Windows.UI.Xaml.Controls.IGridViewItem
-->

# Windows.UI.Xaml.Controls.GridViewItem

## -description
Represents the container for an item in a [GridView](gridview.md) control.

## -xaml-syntax
```xaml
<GridViewItem .../>
-or-
<GridViewItem ...>
  content
</GridViewItem>
```


## -remarks
The GridViewItem class provides the container for items displayed in a [GridView](gridview.md) control. You populate the [GridView](gridview.md) by adding objects directly to its [Items](itemscontrol_items.md) collection or by binding its [ItemsSource](itemscontrol_itemssource.md) property to a data source. When items are added to the [GridView](gridview.md), a GridViewItem container is created automatically for each item in the collection.

You can specify the look of the GridViewItem by setting the [GridView](gridview.md)'s [ItemContainerStyle](itemscontrol_itemcontainerstyle.md) property to a [Style](../windows.ui.xaml/style.md) with a [TargetType](../windows.ui.xaml/style_targettype.md) of GridViewItem.

### Control style and template

You can modify the default [Style](../windows.ui.xaml/style.md) and [ControlTemplate](controltemplate.md) to give the control a unique appearance. For information about modifying a control's style and template, see [Styling controls](/windows/uwp/controls-and-patterns/styling-controls). The default style, template, and resources that define the look of the control are included in the generic.xaml file. For design purposes, generic.xaml is available in the \(Program Files)\Windows Kits\10\DesignTime\CommonConfiguration\Neutral\UAP\ &lt;SDK version&gt;\Generic folder from a Windows Software Development Kit (SDK) installation. Styles and resources from different versions of the SDK might have different values.

Starting in Windows 10, version 1607 (SDK 14393), generic.xaml includes resources that you can use to modify the colors of a control in different visual states without modifying the control template. In apps that target this software development kit (SDK) or later, modifying these resources is preferred to setting properties such as [Background](control_background.md) and [Foreground](control_foreground.md). For more info, see the [Light-weight styling](/windows/uwp/controls-and-patterns/styling-controls) section of the [Styling controls](/windows/uwp/controls-and-patterns/styling-controls) article.

This table shows the resources used by the GridViewItem control.

<table>
   <tr><th>Resource key</th><th>Description</th></tr>
   <tr><td>GridViewItemForeground</td><td>Text color at rest</td></tr>
   <tr><td>GridViewItemForegroundPointerOver</td><td>Text color on hover</td></tr>
   <tr><td>GridViewItemForegroundPressed</td><td>Text color when pressed</td></tr>
   <tr><td>GridViewItemBackground</td><td>Background color at rest</td></tr>
   <tr><td>GridViewItemBackgroundPointerOver</td><td>Background color on hover</td></tr>
   <tr><td>GridViewItemBackgroundPressed</td><td>Background color when pressed</td></tr>
   <tr><td>GridViewItemBackgroundSelected</td><td>Background color when selected</td></tr>
   <tr><td>GridViewItemBackgroundSelectedPointerOver</td><td>Background color on hover and selected</td></tr>
   <tr><td>GridViewItemBackgroundSelectedPressed</td><td>Background color when pressed and selected</td></tr>
   <tr><td>GridViewItemFocusVisualPrimaryBrush</td><td>Focus indicator color when focused</td></tr>
   <tr><td>GridViewItemFocusVisualSecondaryBrush</td><td>Secondary focus indicator color when focused</td></tr>
   <tr><td>GridViewItemFocusBorderBrush</td><td>Border color when focused</td></tr>
   <tr><td>GridViewItemFocusSecondaryBorderBrush</td><td>Secondary border color when focused</td></tr>
   <tr><td>GridViewItemCheckBrush</td><td>Check mark color on selected item</td></tr>
   <tr><td>GridViewItemCheckBoxBrush</td><td>Checkmark box color on selected item</td></tr>
   <tr><td>GridViewItemDragBackground</td><td>Item background color when being dragged</td></tr>
   <tr><td>GridViewItemDragForeground</td><td>Item foreground color when being dragged</td></tr>
   <tr><td>GridViewItemPlaceholderBackground</td><td>Background color of item placeholder</td></tr>
   <tr><td>GridViewItemSelectionCheckMarkVisualEnabled</td><td>Boolean that specifies whether checkmark visual is shown</td></tr>
   <tr><td>GridViewItemCheckMode</td><td>Specifies how checkmark is shown ("Overlay" or "Inline")</td></tr>
</table>

> **Windows 8.1**
> To assign a custom value based on the data item to the [AutomationProperties.Name](/uwp/api/windows.ui.xaml.automation.automationproperties#xaml-attached-properties) attached property, you must bind to the item container's [Content](contentcontrol_content.md) property. For example, assume you have a `Customer` data item that has a `Name` property and you want to use the `Customer.Name` property as the [AutomationProperties.Name](/uwp/api/windows.ui.xaml.automation.automationproperties#xaml-attached-properties) value.

In Windows 8, the data item is set as the [DataContext](../windows.ui.xaml/frameworkelement_datacontext.md) of the item container, so you can use a binding like this: `AutomationProperties.Name="{Binding Name}"`.

In Windows 8.1, the item container's [DataContext](../windows.ui.xaml/frameworkelement_datacontext.md) is not set. To bind the [AutomationProperties.Name](/uwp/api/windows.ui.xaml.automation.automationproperties#xaml-attached-properties) value to the data item's `Name` property, use a binding like this: `AutomationProperties.Name="{Binding Path=Content.Name,RelativeSource={RelativeSource Mode=Self}}"`.

## -examples

## -see-also
[SelectorItem](../windows.ui.xaml.controls.primitives/selectoritem.md), [GridView](gridview.md), [ItemContainerStyle](itemscontrol_itemcontainerstyle.md), [GridViewItem styles and templates](/windows/uwp/design/controls-and-patterns/xaml-styles), [Item templates for GridView](/windows/uwp/controls-and-patterns/item-templates-gridview)
