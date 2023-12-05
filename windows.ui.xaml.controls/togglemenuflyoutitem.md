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

You can modify the default [Style](../windows.ui.xaml/style.md) and [ControlTemplate](controltemplate.md) to give the control a unique appearance. For information about modifying a control's style and template, see [Styling controls](/windows/uwp/controls-and-patterns/styling-controls). The default style, template, and resources that define the look of the control are included in the `generic.xaml` file. For design purposes, `generic.xaml` is available locally with the SDK or NuGet package installation.

- **[WinUI Styles (recommended)](/windows/apps/design/style/xaml-styles#winui-and-styles):** For updated styles from WinUI, see `\Users\<username>\.nuget\packages\microsoft.ui.xaml\<version>\lib\uap10.0\Microsoft.UI.Xaml\Themes\generic.xaml`.
- **Non-WinUI styles:** For built-in styles, see `%ProgramFiles(x86)%\Windows Kits\10\DesignTime\CommonConfiguration\Neutral\UAP\<SDK version>\Generic\generic.xaml`.

Locations might be different if you customized the installation. Styles and resources from different versions of the SDK might have different values.

XAML also includes resources that you can use to modify the colors of a control in different visual states without modifying the control template. Modifying these resources is preferred to setting properties such as [Background](control_background.md) and [Foreground](control_foreground.md). For more info, see the [Light-weight styling](/windows/apps/design/style/xaml-styles#lightweight-styling) section of the [XAML styles](/windows/apps/design/style/xaml-styles) article. Light-weight styling resources are available starting in Windows 10, version 1607 (SDK 14393).

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [Menus and context menus](/windows/uwp/design/controls-and-patterns/menus).
>
> If you have the **WinUI 2 Gallery** app installed, click here to [open the app and see the ToggleMenuFlyoutItem in action](winui2gallery:/item/MenuFlyout).
> + [Get the WinUI 2 Gallery app (Microsoft Store)](https://www.microsoft.com/store/productId/9MSVH128X2ZT)
> + [Get the source code (GitHub)](https://github.com/Microsoft/WinUI-Gallery)

## -see-also
[MenuFlyout](menuflyout.md), [MenuFlyoutItem](menuflyoutitem.md)
