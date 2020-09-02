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

MenuFlyoutItem is the parent class for [ToggleMenuFlyoutItem](togglemenuflyoutitem.md).

### Control style and template

You can modify the default [Style](../windows.ui.xaml/style.md) and [ControlTemplate](controltemplate.md) to give the control a unique appearance. For information about modifying a control's style and template, see [Styling controls](/windows/uwp/controls-and-patterns/styling-controls). The default style, template, and resources that define the look of the control are included in the generic.xaml file. For design purposes, generic.xaml is available in the \(Program Files)\Windows Kits\10\DesignTime\CommonConfiguration\Neutral\UAP\ &lt;SDK version&gt;\Generic folder from a Windows Software Development Kit (SDK) installation. Styles and resources from different versions of the SDK might have different values.

Starting in Windows 10, version 1607 (SDK 14393), generic.xaml includes resources that you can use to modify the colors of a control in different visual states without modifying the control template. In apps that target this software development kit (SDK) or later, modifying these resources is preferred to setting properties such as [Background](control_background.md) and [Foreground](control_foreground.md). For more info, see the [Light-weight styling](/windows/uwp/controls-and-patterns/styling-controls) section of the [Styling controls](/windows/uwp/controls-and-patterns/styling-controls) article.

This table shows the resources used by the MenuFlyoutItem control.

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

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1703 | 15063 | Icon |
| 1803 | 17134 | KeyboardAcceleratorTextOverride |
| 1803 | 17134 | TemplateSettings |

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [Menus and context menus](/windows/uwp/design/controls-and-patterns/menus).
>
> If you have the **XAML Controls Gallery** app installed, click here to [open the app and see the MenuFlyoutItem in action](xamlcontrolsgallery:/item/MenuFlyout).
> + [Get the XAML Controls Gallery app (Microsoft Store)](https://www.microsoft.com/store/productId/9MSVH128X2ZT)
> + [Get the source code (GitHub)](https://github.com/Microsoft/Xaml-Controls-Gallery)

## -see-also
[MenuFlyoutItemBase](menuflyoutitembase.md), [MenuFlyout](menuflyout.md), [MenuFlyoutItem styles and templates](/windows/uwp/design/controls-and-patterns/xaml-styles)
