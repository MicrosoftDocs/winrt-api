---
-api-id: T:Windows.UI.Xaml.Controls.AppBarSeparator
-api-type: winrt class
---

<!-- Class syntax.
public class AppBarSeparator : Windows.UI.Xaml.Controls.Control, Windows.UI.Xaml.Controls.IAppBarSeparator, Windows.UI.Xaml.Controls.ICommandBarElement, Windows.UI.Xaml.Controls.ICommandBarElement2
-->

# Windows.UI.Xaml.Controls.AppBarSeparator

## -description

Represents a line that separates items in an [AppBar](appbar.md) or [CommandBar](commandbar.md).


## -xaml-syntax

```xaml
<AppBarSeparator .../>
```

## -remarks

### Control style and template

You can modify the default [Style](../windows.ui.xaml/style.md) and [ControlTemplate](controltemplate.md) to give the control a unique appearance. For information about modifying a control's style and template, see [Styling controls](/windows/uwp/controls-and-patterns/styling-controls). The default style, template, and resources that define the look of the control are included in the `generic.xaml` file. For design purposes, `generic.xaml` is available locally with the SDK or NuGet package installation.

- **[WinUI Styles (recommended)](/windows/apps/design/style/xaml-styles#winui-and-styles):** For updated styles from WinUI, see `\Users\<username>\.nuget\packages\microsoft.ui.xaml\<version>\lib\uap10.0\Microsoft.UI.Xaml\Themes\generic.xaml`.
- **Non-WinUI styles:** For built-in styles, see `%ProgramFiles(x86)%\Windows Kits\10\DesignTime\CommonConfiguration\Neutral\UAP\<SDK version>\Generic\generic.xaml`.

Locations might be different if you customized the installation. Styles and resources from different versions of the SDK might have different values.

XAML also includes resources that you can use to modify the colors of a control in different visual states without modifying the control template. Modifying these resources is preferred to setting properties such as [Background](control_background.md) and [Foreground](control_foreground.md). For more info, see the [Light-weight styling](/windows/apps/design/style/xaml-styles#lightweight-styling) section of the [XAML styles](/windows/apps/design/style/xaml-styles) article. Light-weight styling resources are available starting in Windows 10, version 1607 (SDK 14393).

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1607 | 14393 | DynamicOverflowOrder |
| 1607 | 14393 | IsInOverflow |

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [Command bar](/windows/apps/design/controls/command-bar).

> [!div class="nextstepaction"]
> [Open the WinUI 2 Gallery app and see the AppBarSeparator in action](winui2gallery:/item/AppBarSeparator)

> The **WinUI 2 Gallery** app includes interactive examples of most WinUI 2 controls, features, and functionality. Get the app from the [Microsoft Store](https://www.microsoft.com/store/productId/9MSVH128X2ZT) or get the source code on [GitHub](https://github.com/Microsoft/WinUI-Gallery/tree/winui2).

## -see-also

[Control](control.md), [AppBar](appbar.md), [AppBarButton](appbarbutton.md), [AppBarToggleButton](appbartogglebutton.md), [CommandBar](commandbar.md), [Controls list](/windows/uwp/design/controls-and-patterns/), [Controls by function](/windows/uwp/controls-and-patterns/controls-by-function), [Commanding sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/XamlCommanding)
