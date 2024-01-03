---
-api-id: T:Windows.UI.Xaml.Controls.CommandBarFlyout
-api-type: winrt class
ms.custom: RS5
---

<!-- Class syntax.
public class CommandBarFlyout : FlyoutBase, FlyoutBase
-->

# Windows.UI.Xaml.Controls.CommandBarFlyout

## -description

Represents a specialized flyout that provides layout for [AppBarButton](appbarbutton.md) and related command elements.

Equivalent **WinUI 2 API for UWP**: [Microsoft.UI.Xaml.Controls.CommandBarFlyout](/windows/winui/api/microsoft.ui.xaml.controls.commandbarflyout) (for WinUI in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -xaml-syntax

```xaml
<CommandBarFlyout .../>
-or-
<CommandBarFlyout>
  commandBarElements
</CommandBarFlyout>
```

## -remarks

### Control style and template

You can modify the default [Style](../windows.ui.xaml/style.md) and [ControlTemplate](controltemplate.md) to give the control a unique appearance. For information about modifying a control's style and template, see [Styling controls](/windows/uwp/controls-and-patterns/styling-controls). The default style, template, and resources that define the look of the control are included in the `generic.xaml` file. For design purposes, `generic.xaml` is available locally with the SDK or NuGet package installation.

- ***WinUI Styles (recommended):** Use [Microsoft.UI.Xaml.Controls.CommandBarFlyout](/windows/winui/api/microsoft.ui.xaml.controls.commandbarflyout).
- **Non-WinUI styles:** For built-in styles, see `%ProgramFiles(x86)%\Windows Kits\10\DesignTime\CommonConfiguration\Neutral\UAP\<SDK version>\Generic\generic.xaml`.

Locations might be different if you customized the installation. Styles and resources from different versions of the SDK might have different values.

XAML also includes resources that you can use to modify the colors of a control in different visual states without modifying the control template. Modifying these resources is preferred to setting properties such as [Background](control_background.md) and [Foreground](control_foreground.md). For more info, see the [Light-weight styling](/windows/apps/design/style/xaml-styles#lightweight-styling) section of the [XAML styles](/windows/apps/design/style/xaml-styles) article. Light-weight styling resources are available starting in Windows 10, version 1607 (SDK 14393).

## -see-also

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [Command bar flyout](/windows/uwp/design/controls-and-patterns/command-bar-flyout).
>
> If you have the **WinUI 2 Gallery** app installed, click here to [open the app and see the CommandBarFlyout in action](winui2gallery:/item/CommandBarFlyout).
> + [Get the WinUI 2 Gallery app (Microsoft Store)](https://www.microsoft.com/store/productId/9MSVH128X2ZT)
> + [Get the source code (GitHub)](https://github.com/Microsoft/WinUI-Gallery)
