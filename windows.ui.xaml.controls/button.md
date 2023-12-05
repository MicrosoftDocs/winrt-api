---
-api-id: T:Windows.UI.Xaml.Controls.Button
-api-type: winrt class
---

<!-- Class syntax.
public class Button : Windows.UI.Xaml.Controls.Primitives.ButtonBase, Windows.UI.Xaml.Controls.IButton, Windows.UI.Xaml.Controls.IButtonWithFlyout
-->

# Windows.UI.Xaml.Controls.Button

## -description
Represents a templated button control that interprets a [Click](../windows.ui.xaml.controls.primitives/buttonbase_click.md) user interaction.


## -xaml-syntax
```xaml
<Button .../>
-or-
<Button>
    singleObject
</Button>
-or-
<Button ...>stringContent</Button>
```


## -remarks

> [!TIP]
> For more info, design guidance, and code examples, see [Buttons](/windows/uwp/design/controls-and-patterns/buttons).

The Button class represents the most basic type of button control. For info on other similar button controls that are more specialized, see [HyperlinkButton](hyperlinkbutton.md) or [RepeatButton](../windows.ui.xaml.controls.primitives/repeatbutton.md).

<img src="images/controls/Button.png" alt="A standard button" />

### Button interaction

When you tap a Button with a finger or stylus, or press a left mouse button while the pointer is over it, the button raises the [Click](../windows.ui.xaml.controls.primitives/buttonbase_click.md) event. If a button has keyboard focus, pressing the Enter key or the Spacebar key also raises the [Click](../windows.ui.xaml.controls.primitives/buttonbase_click.md) event.

You generally can't handle low-level [PointerPressed](../windows.ui.xaml/uielement_pointerpressed.md) events on a Button because it has the [Click](../windows.ui.xaml.controls.primitives/buttonbase_click.md) behavior instead. For more info, see [Events and routed events overview](/windows/uwp/xaml-platform/events-and-routed-events-overview).

You can change how a button raises the [Click](../windows.ui.xaml.controls.primitives/buttonbase_click.md) event by changing the [ClickMode](../windows.ui.xaml.controls.primitives/buttonbase_clickmode.md) property. The default [ClickMode](../windows.ui.xaml.controls.primitives/buttonbase_clickmode.md) value is **Release**. If [ClickMode](../windows.ui.xaml.controls.primitives/buttonbase_clickmode.md) is **Hover**, the [Click](../windows.ui.xaml.controls.primitives/buttonbase_click.md) event can't be raised with the keyboard.

### Button content

Button is a [ContentControl](contentcontrol.md). Its XAML content property is [Content](contentcontrol_content.md), and this enables a syntax like this for XAML: `<Button>A button's content</Button>`. For more info about XAML content properties, see [XAML overview](/windows/uwp/xaml-platform/xaml-overview).

### **Button** derived classes

Button is the parent class for [AppBarButton](appbarbutton.md).

### Control style and template

You can modify the default [Style](../windows.ui.xaml/style.md) and [ControlTemplate](controltemplate.md) to give the control a unique appearance. For information about modifying a control's style and template, see [Styling controls](/windows/uwp/controls-and-patterns/styling-controls). The default style, template, and resources that define the look of the control are included in the `generic.xaml` file. For design purposes, `generic.xaml` is available locally with the SDK or NuGet package installation.

- **[WinUI Styles (recommended)](/windows/apps/design/style/xaml-styles#winui-and-styles):** For updated styles from WinUI, see `\Users\<username>\.nuget\packages\microsoft.ui.xaml\<version>\lib\uap10.0\Microsoft.UI.Xaml\Themes\generic.xaml`.
- **Non-WinUI styles:** For built-in styles, see `%ProgramFiles(x86)%\Windows Kits\10\DesignTime\CommonConfiguration\Neutral\UAP\<SDK version>\Generic\generic.xaml`.

Locations might be different if you customized the installation. Styles and resources from different versions of the SDK might have different values.

XAML also includes resources that you can use to modify the colors of a control in different visual states without modifying the control template. Modifying these resources is preferred to setting properties such as [Background](control_background.md) and [Foreground](control_foreground.md). For more info, see the [Light-weight styling](/windows/apps/design/style/xaml-styles#lightweight-styling) section of the [XAML styles](/windows/apps/design/style/xaml-styles) article. Light-weight styling resources are available starting in Windows 10, version 1607 (SDK 14393).

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [Buttons](/windows/apps/design/controls/buttons).

> [!div class="nextstepaction"]
> [Open the WinUI 2 Gallery app and see the Button in action](winui2gallery:/item/Button)

> The **WinUI 2 Gallery** app includes interactive examples of most WinUI 2 controls, features, and functionality. Get the app from the [Microsoft Store](https://www.microsoft.com/store/productId/9MSVH128X2ZT) or get the source code on [GitHub](https://github.com/Microsoft/WinUI-Gallery/tree/winui2).

The following example shows three buttons that respond to clicks in three different ways based on their [ClickMode](../windows.ui.xaml.controls.primitives/buttonbase_clickmode.md) property value.


+  **Hover** - When the mouse pointer hovers over the first button, the foreground color of the button changes.
+  **Press** - When the left mouse button is pressed over the second button, the foreground color of the button changes.
+  **Release** - When the mouse button is pressed and released when over the third button, the button resets the foreground color of the other two buttons to their original color.




[!code-xaml[1](../windows.ui.xaml.data/code/System.Windows.Controls.ButtonClickModeSL/csharp/Page.xaml#Snippet1)]

[!code-csharp[11](../windows.ui.xaml.data/code/System.Windows.Controls.ButtonClickModeSL/csharp/Page.xaml.cs#Snippet11)]

[!code-vb[11](../windows.ui.xaml.data/code/System.Windows.Controls.ButtonClickModeSL/vbnet/Page.xaml.vb#Snippet11)]

## -see-also
[Buttons overview](/windows/uwp/controls-and-patterns/buttons), [AppBarButton](appbarbutton.md), [CheckBox](checkbox.md), [HyperlinkButton](hyperlinkbutton.md), [RepeatButton](../windows.ui.xaml.controls.primitives/repeatbutton.md), [RadioButton](radiobutton.md), [ToggleSwitch](toggleswitch.md) 
