---
-api-id: T:Windows.UI.Xaml.Controls.PasswordBox
-api-type: winrt class
---

<!-- Class syntax.
public class PasswordBox : Windows.UI.Xaml.Controls.Control, Windows.UI.Xaml.Controls.IPasswordBox, Windows.UI.Xaml.Controls.IPasswordBox2, Windows.UI.Xaml.Controls.IPasswordBox3
-->

# Windows.UI.Xaml.Controls.PasswordBox

## -description
Represents a control for entering passwords.

## -xaml-syntax
```xaml
<PasswordBox .../>
```


## -remarks
[PasswordBox](passwordbox.md) lets a user enter a masked password.

<img alt="Password box control" src="images/controls/PasswordBox.png" />

The user can enter a single line of non-wrapping text in a [PasswordBox](passwordbox.md) control. The text is not displayed while it is entered; only password characters that mask the text are displayed. You can specify this password character by setting the [PasswordChar](passwordbox_passwordchar.md) property.

Use the [Password](passwordbox_password.md) property to get or set the content of the [PasswordBox](passwordbox.md). Handle the [PasswordChanged](passwordbox_passwordchanged.md) event to get the [Password](passwordbox_password.md) value while the user enters it.

For more info, see [PasswordBox control guide](http://msdn.microsoft.com/library/4bfdecc6-9bc5-4ff5-8c63-bb36f6ddf2ef).

### Password reveal mode

The [PasswordRevealMode](passwordbox_passwordrevealmode.md) property lets you customize the password viewing experience. By default, the [PasswordBox](passwordbox.md) has a built-in button that the user can press to display the password text. When the user releases it, the password is automatically hidden again.

Windows 10, version 1607, introduces a new keyboard shortcut for accessibility. When the focus is in the [PasswordBox](passwordbox.md) and the password reveal button is visible, the user can press and hold Alt+F8 to reveal their password. When they let go of either key press, the password is hidden again.

<img src="images/PasswordBox_Revealed.png" alt="A password box with the password shown." />

You can hide the password reveal button, or provide a custom UI to let the user reveal the password. For more info and examples, see [PasswordRevealMode](passwordbox_passwordrevealmode.md) and [PasswordBox control guide](http://msdn.microsoft.com/library/4bfdecc6-9bc5-4ff5-8c63-bb36f6ddf2ef).

> [!NOTE]
> Use the [PasswordRevealMode](passwordbox_passwordrevealmode.md) property instead of the [IsPasswordRevealButtonEnabled](passwordbox_ispasswordrevealbuttonenabled.md) property. [IsPasswordRevealButtonEnabled](passwordbox_ispasswordrevealbuttonenabled.md) is deprecated in Windows 10 and any value is ignored.

### Control style and template

You can modify the default [Style](../windows.ui.xaml/style.md) and [ControlTemplate](controltemplate.md) to give the control a unique appearance. For information about modifying a control's style and template, see [Styling controls](https://msdn.microsoft.com/windows/uwp/controls-and-patterns/styling-controls). The default style, template, and resources that define the look of the control are included in the generic.xaml file. For design purposes, generic.xaml is available in the \(Program Files)\Windows Kits\10\DesignTime\CommonConfiguration\Neutral\UAP\&lt;SDK version&gt;\Generic folder from a Windows Software Development Kit (SDK) installation. Styles and resources from different versions of the SDK might have different values.

Starting in Windows 10, version 1607 (Windows Software Development Kit (SDK) version 10.0.14393.0), generic.xaml includes resources that you can use to modify the colors of a control in different visual states without modifying the control template. In apps that target this software development kit (SDK) or later, modifying these resources is preferred to setting properties such as [Background](control_background.md) and [Foreground](control_foreground.md). For more info, see the [Light-weight styling](https://msdn.microsoft.com/windows/uwp/controls-and-patterns/styling-controls) section of the [Styling controls](https://msdn.microsoft.com/windows/uwp/controls-and-patterns/styling-controls) article.

This table shows the resources used by the [PasswordBox](passwordbox.md) control. Resources that start with "TextControl" are shared by [TextBox](textbox.md), [PasswordBox](passwordbox.md), [RichEditBox](richeditbox.md), and [AutoSuggestBox](autosuggestbox.md).

<table>
   <tr><th>Resource key</th><th>Description</th></tr>
   <tr><td>TextControlForeground</td><td>Text color at rest and not focused</td></tr>
   <tr><td>TextControlForegroundPointerOver</td><td>Text color on hover</td></tr>
   <tr><td>TextControlForegroundFocused</td><td>Text color when focused</td></tr>
   <tr><td>TextControlForegroundDisabled</td><td>Text color when disabled</td></tr>
   <tr><td>TextControlBackground</td><td>Background color at rest and not focused</td></tr>
   <tr><td>TextControlBackgroundPointerOver</td><td>Background color on hover</td></tr>
   <tr><td>TextControlBackgroundFocused</td><td>Background color when focused</td></tr>
   <tr><td>TextControlBackgroundDisabled</td><td>Background color when disabled</td></tr>
   <tr><td>TextControlBorderBrush</td><td>Border color at rest and not focused</td></tr>
   <tr><td>TextControlBorderBrushPointerOver</td><td>Border color on hover</td></tr>
   <tr><td>TextControlBorderBrushFocused</td><td>Border color when focused</td></tr>
   <tr><td>TextControlBorderBrushDisabled</td><td>Border color when disabled</td></tr>
   <tr><td>TextControlPlaceholderForeground</td><td>Placeholder text color at rest and not focused</td></tr>
   <tr><td>TextControlPlaceholderForegroundPointerOver</td><td>Placeholder text color on hover</td></tr>
   <tr><td>TextControlPlaceholderForegroundFocused</td><td>Placeholder text color when focused</td></tr>
   <tr><td>TextControlPlaceholderForegroundDisabled</td><td>Placeholder text color when disabled</td></tr>
   <tr><td>TextControlHeaderForeground</td><td>Header text color</td></tr>
   <tr><td>TextControlHeaderForegroundDisabled</td><td>Header text color when disabled</td></tr>
   <tr><td>TextControlSelectionHighlightColor</td><td>Highlight color of selected text</td></tr>
   <tr><td>TextControlButtonBackground</td><td>Background color of reveal button at rest</td></tr>
   <tr><td>TextControlButtonBackgroundPointerOver</td><td>Background color of reveal button on hover</td></tr>
   <tr><td>TextControlButtonBackgroundPressed</td><td>Background color of reveal button when pressed</td></tr>
   <tr><td>TextControlButtonBorderBrush</td><td>Border color of reveal button at rest</td></tr>
   <tr><td>TextControlButtonBorderBrushPointerOver</td><td>Border color of reveal button on hover</td></tr>
   <tr><td>TextControlButtonBorderBrushPressed</td><td>Border color of reveal button when pressed</td></tr>
   <tr><td>TextControlButtonForeground</td><td>Foreground color of reveal button at rest</td></tr>
   <tr><td>TextControlButtonForegroundPointerOver</td><td>Foreground color of reveal button on hover</td></tr>
   <tr><td>TextControlButtonForegroundPressed</td><td>Foreground color of reveal button when pressed</td></tr>
</table>

### Notes for previous versions

> **Windows 8.x**
> Use the [IsPasswordRevealButtonEnabled](passwordbox_ispasswordrevealbuttonenabled.md) property to specify whether the user can see the password, or see only the masking characters.

In Windows, the user reveals the password by pressing and holding a button in the text entry box. The password is automatically hidden when the user stops pressing the button.

In Windows Phone, the user reveals the password by checking a checkbox, so the password can stay shown while the user in entering it. (For more info on implementing this behavior in Universal Windows Platform (UWP) apps, see [PasswordRevealMode](passwordbox_passwordrevealmode.md).)

## -examples
This example shows a [PasswordBox](passwordbox.md) control that demonstrates the [Password](passwordbox_password.md) property and the [PasswordChanged](passwordbox_passwordchanged.md) event. When the user enters text into this [PasswordBox](passwordbox.md), it's checked to see if it's the literal value, "Password". If it is, a message is displayed to the user.

```xaml
<PasswordBox x:Name="passwordBox" Width="200" MaxLength="16"
             PasswordChanged="passwordBox_PasswordChanged"/>
           
<TextBlock x:Name="statusText" Margin="10" HorizontalAlignment="Center"/>
```

```csharp

private void passwordBox_PasswordChanged(object sender, RoutedEventArgs e)
{
    if (passwordBox.Password == "Password")
    {
        statusText.Text = "'Password' is not allowed as a password.";
    }
    else
    {
        statusText.Text = string.Empty;
    }
}
```

```vbnet

Private Sub passwordBox_PasswordChanged(sender As Object, e As RoutedEventArgs)
    If passwordBox.Password = "Password" Then
        statusText.Text = "'Password' is not allowed as a password."
    Else
        statusText.Text = String.Empty
    End If
End Sub
```


<!--<auto_snippet sample_id="PasswordBoxSnippet" snippet_id="PasswordBoxXAML"/>
    <auto_snippet sample_id="PasswordBoxSnippet" snippet_id="PasswordBoxCode"/>-->

## -see-also
[Control](control.md), [PasswordBox styles and templates](http://msdn.microsoft.com/library/2e6e0ed5-c763-4713-8749-0621a123568b), [PasswordBox control guide](http://msdn.microsoft.com/library/4bfdecc6-9bc5-4ff5-8c63-bb36f6ddf2ef), [TextBox](textbox.md), [Controls list](http://msdn.microsoft.com/library/11172840-a63d-4f48-9db4-7baca06308ee), [Controls by function](http://msdn.microsoft.com/library/8db4347b-91d6-4659-91f2-80ecf7bbb596)