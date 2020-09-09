---
-api-id: T:Windows.UI.Xaml.Controls.ToggleMenuFlyoutItem
-api-type: winrt class
---

<!-- Class syntax.
public class ToggleMenuFlyoutItem : Windows.UI.Xaml.Controls.MenuFlyoutItem, Windows.UI.Xaml.Controls.IToggleMenuFlyoutItem
-->

# Windows.UI.Xaml.Controls.ToggleMenuFlyoutItem

## -description
Represents an item in a [MenuFlyout](menuflyout.md) that a user can change between two states, checked or unchecked.

## -xaml-syntax
```xaml
<ToggleMenuFlyoutItem .../>
-or-
<ToggleMenuFlyoutItem>text</ToggleMenuFlyoutItem>
```


## -remarks
There are three elements that you can use to compose the menu items in a [MenuFlyout](menuflyout.md) control: [MenuFlyoutItem](menuflyoutitem.md) , ToggleMenuFlyoutItem, and [MenuFlyoutSeparator](menuflyoutseparator.md). You can use these in any combination.

### Control style and template

You can modify the default [Style](../windows.ui.xaml/style.md) and [ControlTemplate](controltemplate.md) to give the control a unique appearance. For information about modifying a control's style and template, see [Styling controls](/windows/uwp/controls-and-patterns/styling-controls). The default style, template, and resources that define the look of the control are included in the generic.xaml file. For design purposes, generic.xaml is available in the \(Program Files)\Windows Kits\10\DesignTime\CommonConfiguration\Neutral\UAP\ &lt;SDK version&gt;\Generic folder from a Windows Software Development Kit (SDK) installation. Styles and resources from different versions of the SDK might have different values.

Starting in Windows 10, version 1607 (SDK 14393), generic.xaml includes resources that you can use to modify the colors of a control in different visual states without modifying the control template. In apps that target this software development kit (SDK) or later, modifying these resources is preferred to setting properties such as [Background](control_background.md) and [Foreground](control_foreground.md). For more info, see the [Light-weight styling](/windows/uwp/controls-and-patterns/styling-controls) section of the [Styling controls](/windows/uwp/controls-and-patterns/styling-controls) article.

This table shows the resources used by the ToggleMenuFlyoutItem control.

<table>
   <tr><th>Resource key</th><th>Description</th></tr>
   <tr><td>ToggleMenuFlyoutItemBackground</td><td>Background color of entire control bounds at rest</td></tr>
   <tr><td>ToggleMenuFlyoutItemBackgroundPointerOver</td><td>Background color on hover</td></tr>
   <tr><td>ToggleMenuFlyoutItemBackgroundPressed</td><td>Background color when pressed</td></tr>
   <tr><td>ToggleMenuFlyoutItemBackgroundDisabled</td><td>Background color when disabled</td></tr>
   <tr><td>ToggleMenuFlyoutItemForeground</td><td>Text color at rest</td></tr>
   <tr><td>ToggleMenuFlyoutItemForegroundPointerOver</td><td>Text color on hover</td></tr>
   <tr><td>ToggleMenuFlyoutItemForegroundPressed</td><td>Text color when pressed</td></tr>
   <tr><td>ToggleMenuFlyoutItemForegroundDisabled</td><td>Text color when disabled</td></tr>
   <tr><td>ToggleMenuFlyoutItemCheckGlyphForeground</td><td>Color of selected check mark</td></tr>
   <tr><td>ToggleMenuFlyoutItemCheckGlyphForegroundPointerOver</td><td>Color of selected check mark on hover</td></tr>
   <tr><td>ToggleMenuFlyoutItemCheckGlyphForegroundPressed</td><td>Color of selected check mark when pressed</td></tr>
   <tr><td>ToggleMenuFlyoutItemCheckGlyphForegroundDisabled</td><td>Color of selected check mark when disabled</td></tr>
</table>

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [Menus and context menus](/windows/uwp/design/controls-and-patterns/menus).
>
> If you have the **XAML Controls Gallery** app installed, click here to [open the app and see the ToggleMenuFlyoutItem in action](xamlcontrolsgallery:/item/MenuFlyout).
> + [Get the XAML Controls Gallery app (Microsoft Store)](https://www.microsoft.com/store/productId/9MSVH128X2ZT)
> + [Get the source code (GitHub)](https://github.com/Microsoft/Xaml-Controls-Gallery)

## -see-also
[MenuFlyout](menuflyout.md), [MenuFlyoutItem](menuflyoutitem.md), [ToggleMenuFlyoutItem styles and templates](/windows/uwp/design/controls-and-patterns/xaml-styles)
