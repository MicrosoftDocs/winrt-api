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

You can modify the default [Style](../windows.ui.xaml/style.md) and [ControlTemplate](controltemplate.md) to give the control a unique appearance. For information about modifying a control's style and template, see [Styling controls](/windows/uwp/controls-and-patterns/styling-controls). The default style, template, and resources that define the look of the control are included in the `generic.xaml` file. For design purposes, `generic.xaml` is available locally with the SDK or NuGet package installation.

- **[WinUI Styles (recommended)](/windows/apps/design/style/xaml-styles#winui-and-styles):** For updated styles from WinUI, see `\Users\<username>\.nuget\packages\microsoft.ui.xaml\<version>\lib\uap10.0\Microsoft.UI.Xaml\Themes\generic.xaml`.
- **Non-WinUI styles:** For built-in styles, see `%ProgramFiles(x86)%\Windows Kits\10\DesignTime\CommonConfiguration\Neutral\UAP\<SDK version>\Generic\generic.xaml`.

Locations might be different if you customized the installation. Styles and resources from different versions of the SDK might have different values.

XAML also includes resources that you can use to modify the colors of a control in different visual states without modifying the control template. Modifying these resources is preferred to setting properties such as [Background](control_background.md) and [Foreground](control_foreground.md). For more info, see the [Light-weight styling](/windows/apps/design/style/xaml-styles#lightweight-styling) section of the [XAML styles](/windows/apps/design/style/xaml-styles) article. Light-weight styling resources are available starting in Windows 10, version 1607 (SDK 14393).

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
> If you have the **WinUI 2 Gallery** app installed, click here to [open the app and see the MenuFlyoutItem in action](winui2gallery:/item/MenuFlyout).
> + [Get the WinUI 2 Gallery app (Microsoft Store)](https://www.microsoft.com/store/productId/9MSVH128X2ZT)
> + [Get the source code (GitHub)](https://github.com/Microsoft/WinUI-Gallery)

## -see-also
[MenuFlyoutItemBase](menuflyoutitembase.md), [MenuFlyout](menuflyout.md)
