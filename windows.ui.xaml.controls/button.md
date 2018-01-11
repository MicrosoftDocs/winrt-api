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
The [Button](button.md) class represents the most basic type of button control. For info on other similar button controls that are more specialized, see [HyperlinkButton](hyperlinkbutton.md) or [RepeatButton](../windows.ui.xaml.controls.primitives/repeatbutton.md).

<img src="images/controls/Button.png" alt="A standard button" />

### Button interaction

When you tap a [Button](button.md) with a finger or stylus, or press a left mouse button while the pointer is over it, the button raises the [Click](../windows.ui.xaml.controls.primitives/buttonbase_click.md) event. If a button has keyboard focus, pressing the Enter key or the Spacebar key also raises the [Click](../windows.ui.xaml.controls.primitives/buttonbase_click.md) event.

You generally can't handle low-level [PointerPressed](../windows.ui.xaml/uielement_pointerpressed.md) events on a [Button](button.md) because it has the [Click](../windows.ui.xaml.controls.primitives/buttonbase_click.md) behavior instead. For more info, see [Events and routed events overview](http://msdn.microsoft.com/library/34c219e8-3efb-45bc-8bbd-6fd937698832).

You can change how a button raises the [Click](../windows.ui.xaml.controls.primitives/buttonbase_click.md) event by changing the [ClickMode](../windows.ui.xaml.controls.primitives/buttonbase_clickmode.md) property. The default [ClickMode](../windows.ui.xaml.controls.primitives/buttonbase_clickmode.md) value is **Release**. If [ClickMode](../windows.ui.xaml.controls.primitives/buttonbase_clickmode.md) is **Hover**, the [Click](../windows.ui.xaml.controls.primitives/buttonbase_click.md) event can't be raised with the keyboard.

### Button content

[Button](button.md) is a [ContentControl](contentcontrol.md). Its XAML content property is [Content](contentcontrol_content.md), and this enables a syntax like this for XAML: `<Button>A button's content</Button>`. For more info about XAML content properties, see [XAML overview](http://msdn.microsoft.com/library/48041b37-f1a8-44a4-bb8e-1d4de30e7823).

### **Button** derived classes

[Button](button.md) is the parent class for [AppBarButton](appbarbutton.md).

### Control style and template

You can modify the default [Style](../windows.ui.xaml/style.md) and [ControlTemplate](controltemplate.md) to give the control a unique appearance. For information about modifying a control's style and template, see [Styling controls](https://msdn.microsoft.com/windows/uwp/controls-and-patterns/styling-controls). The default style, template, and resources that define the look of the control are included in the generic.xaml file. For design purposes, generic.xaml is available in the \(Program Files)\Windows Kits\10\DesignTime\CommonConfiguration\Neutral\UAP\&lt;SDK version&gt;\Generic folder from a Windows Software Development Kit (SDK) installation. Styles and resources from different versions of the SDK might have different values.

Starting in Windows 10, version 1607 (Windows Software Development Kit (SDK) version 10.0.14393.0), generic.xaml includes resources that you can use to modify the colors of a control in different visual states without modifying the control template. In apps that target this software development kit (SDK) or later, modifying these resources is preferred to setting properties such as [Background](control_background.md) and [Foreground](control_foreground.md). For more info, see the [Light-weight styling](https://msdn.microsoft.com/windows/uwp/controls-and-patterns/styling-controls) section of the [Styling controls](https://msdn.microsoft.com/windows/uwp/controls-and-patterns/styling-controls) article.

This table shows the resources used by the [Button](button.md) control.

<table>
   <tr><th>Resource key</th><th>Description</th></tr>
   <tr><td>ButtonBackground</td><td>Background color at rest</td></tr>
   <tr><td>ButtonBackgroundPointerOver</td><td>Background color on hover</td></tr>
   <tr><td>ButtonBackgroundPressed</td><td>Background color when pressed</td></tr>
   <tr><td>ButtonBackgroundDisabled</td><td>Background color when disabled</td></tr>
   <tr><td>ButtonForeground</td><td>Foreground color at rest</td></tr>
   <tr><td>ButtonForegroundPointerOver</td><td>Foreground color on hover</td></tr>
   <tr><td>ButtonForegroundPressed</td><td>Foreground color when pressed</td></tr>
   <tr><td>ButtonForegroundDisabled</td><td>Foreground color when disabled</td></tr>
   <tr><td>ButtonBorderBrush</td><td>Border color at rest</td></tr>
   <tr><td>ButtonBorderBrushPointerOver</td><td>Border color on hover</td></tr>
   <tr><td>ButtonBorderBrushPressed</td><td>Border color when pressed</td></tr>
   <tr><td>ButtonBorderBrushDisabled</td><td>Border color when disabled</td></tr>
</table>

## -examples

<table>
<th align="left">XAML Controls Gallery<th>
<tr>
<td><img src="images/xaml-controls-gallery-sm.png" alt="XAML controls gallery"></img></td>
<td>
    <p>If you have the <strong style="font-weight: semi-bold">XAML Controls Gallery</strong> app installed, click here to <a href="xamlcontrolsgallery:/item/Button">open the app and see the Button in action</a>.</p>
    <ul>
    <li><a href="https://www.microsoft.com/store/productId/9MSVH128X2ZT">Get the XAML Controls Gallery app (Microsoft Store)</a></li>
    <li><a href="https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/XamlUIBasics">Get the source code (GitHub)</a></li>
    </ul>
</td>
</tr>
</table>

The following example shows three buttons that respond to clicks in three different ways based on their [ClickMode](../windows.ui.xaml.controls.primitives/buttonbase_clickmode.md) property value.


+  **Hover** - When the mouse pointer hovers over the first button, the foreground color of the button changes.
+  **Press** - When the left mouse button is pressed over the second button, the foreground color of the button changes.
+  **Release** - When the mouse button is pressed and released when over the third button, the button resets the foreground color of the other two buttons to their original color.




[!code-xml[1](../windows.ui.xaml.data/code/System.Windows.Controls.ButtonClickModeSL/csharp/Page.xaml#Snippet1)]

[!code-csharp[11](../windows.ui.xaml.data/code/System.Windows.Controls.ButtonClickModeSL/csharp/Page.xaml.cs#Snippet11)]

[!code-vb[11](../windows.ui.xaml.data/code/System.Windows.Controls.ButtonClickModeSL/vbnet/Page.xaml.vb#Snippet11)]

## -see-also
[Buttons overview](https://docs.microsoft.com/windows/uwp/controls-and-patterns/buttons), [Button styles and templates](http://msdn.microsoft.com/library/05f2b757-6a25-42a7-824a-45776e76c2d2), [AppBarButton](appbarbutton.md), [CheckBox](checkbox.md), [HyperlinkButton](hyperlinkbutton.md), [RepeatButton](../windows.ui.xaml.controls.primitives/repeatbutton.md), [RadioButton](radiobutton.md), [ToggleSwitch](toggleswitch.md) 
