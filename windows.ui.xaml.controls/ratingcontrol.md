---
-api-id: T:Windows.UI.Xaml.Controls.RatingControl
-api-type: winrt class
---

<!-- Class syntax.
public class RatingControl : Control, Control
-->

# Windows.UI.Xaml.Controls.RatingControl

## -description

Represents a control that lets a user enter a star rating.

Equivalent **WinUI 2 API for UWP**: [Microsoft.UI.Xaml.Controls.RatingControl](/windows/winui/api/microsoft.ui.xaml.controls.ratingcontrol) (for WinUI in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -xaml-syntax

```xaml
<RatingControl/>
```

## -remarks

### Control style and template

You can modify the default [Style](../windows.ui.xaml/style.md) and [ControlTemplate](controltemplate.md) to give the control a unique appearance. For information about modifying a control's style and template, see [Styling controls](/windows/uwp/controls-and-patterns/styling-controls). The default style, template, and resources that define the look of the control are included in the `generic.xaml` file. For design purposes, `generic.xaml` is available locally with the SDK or NuGet package installation.

- **WinUI Styles (recommended):** Use [Microsoft.UI.Xaml.Controls.RatingControl](/windows/winui/api/microsoft.ui.xaml.controls.ratingcontrol).
- **Non-WinUI styles:** For built-in styles, see `%ProgramFiles(x86)%\Windows Kits\10\DesignTime\CommonConfiguration\Neutral\UAP\<SDK version>\Generic\generic.xaml`.

Locations might be different if you customized the installation. Styles and resources from different versions of the SDK might have different values.

XAML also includes resources that you can use to modify the colors of a control in different visual states without modifying the control template. Modifying these resources is preferred to setting properties such as [Background](control_background.md) and [Foreground](control_foreground.md). For more info, see the [Light-weight styling](/windows/apps/design/style/xaml-styles#lightweight-styling) section of the [XAML styles](/windows/apps/design/style/xaml-styles) article. Light-weight styling resources are available starting in Windows 10, version 1607 (SDK 14393).

## -see-also
[Rating control overview](/windows/uwp/controls-and-patterns/rating)

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [Rating control](/windows/apps/design/controls/rating).

> [!div class="nextstepaction"]
> [Open the WinUI 2 Gallery app and see the RatingControl in action](winui2gallery:/item/RatingControl)

> The **WinUI 2 Gallery** app includes interactive examples of most WinUI 2 controls, features, and functionality. Get the app from the [Microsoft Store](https://www.microsoft.com/store/productId/9MSVH128X2ZT) or get the source code on [GitHub](https://github.com/Microsoft/WinUI-Gallery/tree/winui2).
