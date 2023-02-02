---
-api-id: T:Windows.UI.Xaml.Controls.DropDownButton
-api-type: winrt class
ms.custom: RS5
---

<!-- Class syntax.
public class DropDownButton : Button, Button
-->

# Windows.UI.Xaml.Controls.DropDownButton

## -description

Represents a button with a chevron intended to open a menu.

Equivalent **WinUI 2 API for UWP**: [Microsoft.UI.Xaml.Controls.DropDownButton](/windows/winui/api/microsoft.ui.xaml.controls.dropdownbutton) (for WinUI in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -xaml-syntax

```xaml
<DropDownButton />
```

## -remarks

A DropDownButton is a button that shows a chevron as a visual indicator that it has an attached flyout that contains more options. It has the same behavior as a standard Button with a flyout; only the appearance is different.

For more info and examples, see [Buttons](/windows/apps/design/controls/buttons#create-a-drop-down-button).

### Control style and template

You can modify the default [Style](../windows.ui.xaml/style.md) and [ControlTemplate](controltemplate.md) to give the control a unique appearance. For information about modifying a control's style and template, see [XAML styles](/windows/apps/design/style/xaml-styles). XAML also includes resources that you can use to modify the colors of a control in different visual states without modifying the control template. Modifying these resources is preferred to setting properties such as [Background](control_background.md) and [Foreground](control_foreground.md). For more info, see the [Light-weight styling](/windows/apps/design/style/xaml-styles#lightweight-styling) section of the [XAML styles](/windows/apps/design/style/xaml-styles) article.

**WinUI Styles (recommended):** Use [Microsoft.UI.Xaml.Controls.DropDownButton](/windows/winui/api/microsoft.ui.xaml.controls.dropdownbutton).

**Non-WinUI styles:** When you use the built-in styles, the default style, template, and resources that define the look of the control are included in the generic.xaml file. For design purposes, generic.xaml is available in the \(Program Files)\Windows Kits\10\DesignTime\CommonConfiguration\Neutral\UAP\ &lt;SDK version&gt;\Generic folder from a Windows SDK installation. Light-weight styling resources are available starting in Windows 10, version 1607 (SDK 14393). Styles and resources from different versions of the SDK might have different values.

## -see-also

[Buttons](/windows/apps/design/controls/buttons#create-a-drop-down-button)

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [Buttons](/windows/apps/design/controls/buttons#create-a-drop-down-button).

> [!div class="nextstepaction"]
> [Open the WinUI 2 Gallery app and see the DropDownButton in action](winui2gallery:/item/DropDownButton)

> The **WinUI 2 Gallery** app includes interactive examples of most WinUI 2 controls, features, and functionality. Get the app from the [Microsoft Store](https://www.microsoft.com/store/productId/9MSVH128X2ZT) or get the source code on [GitHub](https://github.com/Microsoft/WinUI-Gallery/tree/winui2).
