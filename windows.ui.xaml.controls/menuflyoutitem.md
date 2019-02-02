---
-api-id: T:Windows.UI.Xaml.Controls.MenuFlyoutItem
-api-type: winrt class
---

<!-- Class syntax.
public class MenuFlyoutItem : Windows.UI.Xaml.Controls.MenuFlyoutItemBase, Windows.UI.Xaml.Controls.IMenuFlyoutItem
-->

# Windows.UI.Xaml.Controls.MenuFlyoutItem

## -description
Represents a command in a [MenuFlyout](menuflyout.md) control.

## -xaml-syntax
```xaml
<MenuFlyoutItem .../>
-or-
<MenuFlyoutItem>string</MenuFlyoutItem>
```


## -remarks
Use a [Flyout](flyout.md) control to display single items and a [MenuFlyout](menuflyout.md) control to show a menu of items.

### **MenuFlyoutItem** derived classes

[MenuFlyoutItem](menuflyoutitem.md) is the parent class for [ToggleMenuFlyoutItem](togglemenuflyoutitem.md).

### Control style and template

You can modify the default [Style](../windows.ui.xaml/style.md) and [ControlTemplate](controltemplate.md) to give the control a unique appearance. For information about modifying a control's style and template, see [Styling controls](https://msdn.microsoft.com/windows/uwp/controls-and-patterns/styling-controls). The default style, template, and resources that define the look of the control are included in the generic.xaml file. For design purposes, generic.xaml is available in the \(Program Files)\Windows Kits\10\DesignTime\CommonConfiguration\Neutral\UAP\&lt;SDK version&gt;\Generic folder from a Windows Software Development Kit (SDK) installation. Styles and resources from different versions of the SDK might have different values.

Starting in Windows 10, version 1607 (Windows Software Development Kit (SDK) version 10.0.14393.0), generic.xaml includes resources that you can use to modify the colors of a control in different visual states without modifying the control template. In apps that target this software development kit (SDK) or later, modifying these resources is preferred to setting properties such as [Background](control_background.md) and [Foreground](control_foreground.md). For more info, see the [Light-weight styling](https://msdn.microsoft.com/windows/uwp/controls-and-patterns/styling-controls) section of the [Styling controls](https://msdn.microsoft.com/windows/uwp/controls-and-patterns/styling-controls) article.

This table shows the resources used by the [MenuFlyoutItem](menuflyoutitem.md) control.

<table>
   <tr><th>Resource key</th><th>Description</th></tr>
   <tr><td>MenuFlyoutItemBackground</td><td>Background color of entire control bounds at rest</td></tr>
   <tr><td>MenuFlyoutItemBackgroundPointerOver</td><td>Background color on hover</td></tr>
   <tr><td>MenuFlyoutItemBackgroundPressed</td><td>Background color when pressed</td></tr>
   <tr><td>MenuFlyoutItemBackgroundDisabled</td><td>Background color when disabled</td></tr>
   <tr><td>MenuFlyoutItemForeground</td><td>Text color at rest</td></tr>
   <tr><td>MenuFlyoutItemForegroundPointerOver</td><td>Text color on hover</td></tr>
   <tr><td>MenuFlyoutItemForegroundPressed</td><td>Text color when pressed</td></tr>
   <tr><td>MenuFlyoutItemForegroundDisabled</td><td>Text color when disabled</td></tr>
</table>

## -examples

## -see-also
[MenuFlyoutItemBase](menuflyoutitembase.md), [MenuFlyout](menuflyout.md), [MenuFlyoutItem styles and templates](https://msdn.microsoft.com/library/fcb179f6-5dc3-4725-a5e2-c034bcfa865b)
