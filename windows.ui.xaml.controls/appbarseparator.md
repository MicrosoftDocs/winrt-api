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

You can modify the default [Style](../windows.ui.xaml/style.md) and [ControlTemplate](controltemplate.md) to give the control a unique appearance. For information about modifying a control's style and template, see [Styling controls](https://docs.microsoft.com/windows/uwp/controls-and-patterns/styling-controls). The default style, template, and resources that define the look of the control are included in the generic.xaml file. For design purposes, generic.xaml is available in the \(Program Files)\Windows Kits\10\DesignTime\CommonConfiguration\Neutral\UAP\ &lt;SDK version&gt;\Generic folder from a Windows Software Development Kit (SDK) installation. Styles and resources from different versions of the SDK might have different values.

Starting in Windows 10, version 1607 (SDK 14393), generic.xaml includes resources that you can use to modify the colors of a control in different visual states without modifying the control template. In apps that target this software development kit (SDK) or later, modifying these resources is preferred to setting properties such as [Background](control_background.md) and [Foreground](control_foreground.md). For more info, see the [Light-weight styling](https://docs.microsoft.com/windows/uwp/controls-and-patterns/styling-controls) section of the [Styling controls](https://docs.microsoft.com/windows/uwp/controls-and-patterns/styling-controls) article.

This table shows the resources used by the AppBarSeparator control.

<table>
   <tr><th>Resource key</th><th>Description</th></tr>
   <tr><td>AppBarSeparatorForeground</td><td>Foreground color at rest</td></tr>
</table>

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1607 | 14393 | DynamicOverflowOrder |
| 1607 | 14393 | IsInOverflow |

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [Command bar](/windows/uwp/controls-and-patterns/app-bars).
>
> If you have the **XAML Controls Gallery** app installed, click here to [open the app and see the AppBarSeparator in action](xamlcontrolsgallery:/item/AppBarSeparator).
> + [Get the XAML Controls Gallery app (Microsoft Store)](https://www.microsoft.com/store/productId/9MSVH128X2ZT)
> + [Get the source code (GitHub)](https://github.com/Microsoft/Xaml-Controls-Gallery)

## -see-also

[Control](control.md), [AppBarSeparator styles and templates](https://docs.microsoft.com/windows/uwp/design/controls-and-patterns/xaml-styles), [AppBar](appbar.md), [AppBarButton](appbarbutton.md), [AppBarToggleButton](appbartogglebutton.md), [CommandBar](commandbar.md), [Controls list](https://docs.microsoft.com/windows/uwp/design/controls-and-patterns/), [Controls by function](https://docs.microsoft.com/windows/uwp/controls-and-patterns/controls-by-function), [Commanding sample (Windows 10)](https://go.microsoft.com/fwlink/p/?LinkId=620019)
