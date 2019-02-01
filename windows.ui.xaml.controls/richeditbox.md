---
-api-id: T:Windows.UI.Xaml.Controls.RichEditBox
-api-type: winrt class
---

<!-- Class syntax.
public class RichEditBox : Windows.UI.Xaml.Controls.Control, Windows.UI.Xaml.Controls.IRichEditBox, Windows.UI.Xaml.Controls.IRichEditBox2, Windows.UI.Xaml.Controls.IRichEditBox3, Windows.UI.Xaml.Controls.IRichEditBox4, Windows.UI.Xaml.Controls.IRichEditBox5
-->

# Windows.UI.Xaml.Controls.RichEditBox

## -description

Represents a rich text editing control that supports formatted text, hyperlinks, and other rich content.

## -xaml-syntax

```xaml
<RichEditBox .../>

```

## -remarks

> [!TIP]
> For more info, design guidance, and code examples, see [Rich edit box](/windows/uwp/design/controls-and-patterns/rich-edit-box).

[RichEditBox](richeditbox.md) is a control that lets a user enter formatted text such as bold, italic, and underlined. [RichEditBox](richeditbox.md) can also display Rich Text Format (.rtf) documents including hyperlinks and images (.jpg, .png, etc). This control is designed for advanced text editing scenarios. For simple plain text input, like on a form, consider using [TextBox](textbox.md).

You use the [Document](richeditbox_document.md) property of the [RichEditBox](richeditbox.md) to get its content. The content of a [RichEditBox](richeditbox.md) is a [Windows.UI.Text.ITextDocument](../windows.ui.text/itextdocument.md) object, which gives you access to the underlying [Text Object Model](https://msdn.microsoft.com/library/windows/desktop/bb787607.aspx) APIs. See the [Windows.UI.Text](../windows.ui.text/windows_ui_text.md) namespace for APIs that you can use to work with the text document.

For more info and examples, see the [RichEditBox control guide](https://msdn.microsoft.com/library/4afc0dfa-3b89-434d-9f86-4309ccff7839).

### Pen input

Starting with Windows 10, version 1803, XAML text input boxes feature embedded support for pen input using [Windows Ink](../input/pen-and-stylus-interactions.md). When a user taps into a text input box using a Windows pen, the text box transforms to let the user write directly into it with a pen, rather than opening a separate input panel.

<img src="images/controls/handwritingview-inksuggestion1.gif" alt="Text box with ink and suggestions" />

For more info, see [Text input with the handwriting view](https://docs.microsoft.com/windows/uwp/design/controls-and-patterns/text-handwriting-view).

### Control style and template

You can modify the default [Style](../windows.ui.xaml/style.md) and [ControlTemplate](controltemplate.md) to give the control a unique appearance. For information about modifying a control's style and template, see [Styling controls](https://msdn.microsoft.com/windows/uwp/controls-and-patterns/styling-controls). The default style, template, and resources that define the look of the control are included in the generic.xaml file. For design purposes, generic.xaml is available in the \(Program Files)\Windows Kits\10\DesignTime\CommonConfiguration\Neutral\UAP\&lt;SDK version&gt;\Generic folder from a Windows Software Development Kit (SDK) installation. Styles and resources from different versions of the SDK might have different values.

Starting in Windows 10, version 1607 (Windows Software Development Kit (SDK) version 10.0.14393.0), generic.xaml includes resources that you can use to modify the colors of a control in different visual states without modifying the control template. In apps that target this software development kit (SDK) or later, modifying these resources is preferred to setting properties such as [Background](control_background.md) and [Foreground](control_foreground.md). For more info, see the [Light-weight styling](https://msdn.microsoft.com/windows/uwp/controls-and-patterns/styling-controls) section of the [Styling controls](https://msdn.microsoft.com/windows/uwp/controls-and-patterns/styling-controls) article.

This table shows the resources used by the [RichEditBox](richeditbox.md) control. Resources that start with "TextControl" are shared by [TextBox](textbox.md), [PasswordBox](passwordbox.md), [RichEditBox](richeditbox.md), and [AutoSuggestBox](autosuggestbox.md).

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
   <tr><td>TextControlButtonBackground</td><td>Background color of delete button at rest</td></tr>
   <tr><td>TextControlButtonBackgroundPointerOver</td><td>Background color of delete button on hover</td></tr>
   <tr><td>TextControlButtonBackgroundPressed</td><td>Background color of delete button when pressed</td></tr>
   <tr><td>TextControlButtonBorderBrush</td><td>Border color of delete button at rest</td></tr>
   <tr><td>TextControlButtonBorderBrushPointerOver</td><td>Border color of delete button on hover</td></tr>
   <tr><td>TextControlButtonBorderBrushPressed</td><td>Border color of delete button when pressed</td></tr>
   <tr><td>TextControlButtonForeground</td><td>Foreground color of delete button at rest</td></tr>
   <tr><td>TextControlButtonForegroundPointerOver</td><td>Foreground color of delete button on hover</td></tr>
   <tr><td>TextControlButtonForegroundPressed</td><td>Foreground color of delete button when pressed</td></tr>
</table>

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [Rich edit box](/windows/uwp/design/controls-and-patterns/rich-edit-box).
>
> If you have the **XAML Controls Gallery** app installed, click here to [open the app and see the RichEditBox in action](xamlcontrolsgallery:/item/RichEditBox).
> + [Get the XAML Controls Gallery app (Microsoft Store)](https://www.microsoft.com/store/productId/9MSVH128X2ZT)
> + [Get the source code (GitHub)](https://github.com/Microsoft/Xaml-Controls-Gallery)

This example shows how to use the [ITextDocument.SetText](../windows.ui.text/itextdocument_settext_522499431.md) method to programmatically add text to a [RichEditBox](richeditbox.md).

```xaml
<RichEditBox x:Name="richEditBox" Width="500" Header="Notes"/>
```

```csharp
richEditBox.Document.SetText(Windows.UI.Text.TextSetOptions.None, "This is some sample text");
```

This example shows how to edit, load, and save a Rich Text Format (.rtf) file in a [RichEditBox](richeditbox.md).

```xaml
 <RelativePanel Margin="20" HorizontalAlignment="Stretch">
     <RelativePanel.Resources>
         <Style TargetType="AppBarButton">
             <Setter Property="IsCompact" Value="True"/>
         </Style>
     </RelativePanel.Resources>
     <AppBarButton x:Name="openFileButton" Icon="OpenFile" 
                   Click="OpenButton_Click" ToolTipService.ToolTip="Open file"/>
     <AppBarButton Icon="Save" Click="SaveButton_Click" 
                   ToolTipService.ToolTip="Save file" 
                   RelativePanel.RightOf="openFileButton" Margin="8,0,0,0"/>

     <AppBarButton Icon="Bold" Click="BoldButton_Click" ToolTipService.ToolTip="Bold" 
                   RelativePanel.LeftOf="italicButton" Margin="0,0,8,0"/>
     <AppBarButton x:Name="italicButton" Icon="Italic" Click="ItalicButton_Click" 
                   ToolTipService.ToolTip="Italic" RelativePanel.LeftOf="underlineButton" Margin="0,0,8,0"/>
     <AppBarButton x:Name="underlineButton" Icon="Underline" Click="UnderlineButton_Click" 
                   ToolTipService.ToolTip="Underline" RelativePanel.AlignRightWithPanel="True"/>


     <RichEditBox x:Name="editor" Height="200" RelativePanel.Below="openFileButton" 
                  RelativePanel.AlignLeftWithPanel="True" RelativePanel.AlignRightWithPanel="True"/>
 </RelativePanel>
```

```csharp
private async void OpenButton_Click(object sender, RoutedEventArgs e)
{
    // Open a text file.
    Windows.Storage.Pickers.FileOpenPicker open =
        new Windows.Storage.Pickers.FileOpenPicker();
    open.SuggestedStartLocation =
        Windows.Storage.Pickers.PickerLocationId.DocumentsLibrary;
    open.FileTypeFilter.Add(".rtf");

    Windows.Storage.StorageFile file = await open.PickSingleFileAsync();

    if (file != null)
    {
        try
        {
            Windows.Storage.Streams.IRandomAccessStream randAccStream =
        await file.OpenAsync(Windows.Storage.FileAccessMode.Read);

            // Load the file into the Document property of the RichEditBox.
            editor.Document.LoadFromStream(Windows.UI.Text.TextSetOptions.FormatRtf, randAccStream);
        }
        catch (Exception)
        {
            ContentDialog errorDialog = new ContentDialog()
            {
                Title = "File open error",
                Content = "Sorry, I couldn't open the file.",
                PrimaryButtonText = "Ok"
            };

            await errorDialog.ShowAsync();
        }
    }
}

private async void SaveButton_Click(object sender, RoutedEventArgs e)
{
    Windows.Storage.Pickers.FileSavePicker savePicker = new Windows.Storage.Pickers.FileSavePicker();
    savePicker.SuggestedStartLocation = Windows.Storage.Pickers.PickerLocationId.DocumentsLibrary;

    // Dropdown of file types the user can save the file as
    savePicker.FileTypeChoices.Add("Rich Text", new List<string>() { ".rtf" });

    // Default file name if the user does not type one in or select a file to replace
    savePicker.SuggestedFileName = "New Document";

    Windows.Storage.StorageFile file = await savePicker.PickSaveFileAsync();
    if (file != null)
    {
        // Prevent updates to the remote version of the file until we 
        // finish making changes and call CompleteUpdatesAsync.
        Windows.Storage.CachedFileManager.DeferUpdates(file);
        // write to file
        Windows.Storage.Streams.IRandomAccessStream randAccStream =
            await file.OpenAsync(Windows.Storage.FileAccessMode.ReadWrite);

        editor.Document.SaveToStream(Windows.UI.Text.TextGetOptions.FormatRtf, randAccStream);

        // Let Windows know that we're finished changing the file so the 
        // other app can update the remote version of the file.
        Windows.Storage.Provider.FileUpdateStatus status = await Windows.Storage.CachedFileManager.CompleteUpdatesAsync(file);
        if (status != Windows.Storage.Provider.FileUpdateStatus.Complete)
        {
            Windows.UI.Popups.MessageDialog errorBox =
                new Windows.UI.Popups.MessageDialog("File " + file.Name + " couldn't be saved.");
            await errorBox.ShowAsync();
        }
    }
}

private void BoldButton_Click(object sender, RoutedEventArgs e)
{
    Windows.UI.Text.ITextSelection selectedText = editor.Document.Selection;
    if (selectedText != null)
    {
        Windows.UI.Text.ITextCharacterFormat charFormatting = selectedText.CharacterFormat;
        charFormatting.Bold = Windows.UI.Text.FormatEffect.Toggle;
        selectedText.CharacterFormat = charFormatting;
    }
}

private void ItalicButton_Click(object sender, RoutedEventArgs e)
{
    Windows.UI.Text.ITextSelection selectedText = editor.Document.Selection;
    if (selectedText != null)
    {
        Windows.UI.Text.ITextCharacterFormat charFormatting = selectedText.CharacterFormat;
        charFormatting.Italic = Windows.UI.Text.FormatEffect.Toggle;
        selectedText.CharacterFormat = charFormatting;
    }
}

private void UnderlineButton_Click(object sender, RoutedEventArgs e)
{
    Windows.UI.Text.ITextSelection selectedText = editor.Document.Selection;
    if (selectedText != null)
    {
        Windows.UI.Text.ITextCharacterFormat charFormatting = selectedText.CharacterFormat;
        if (charFormatting.Underline == Windows.UI.Text.UnderlineType.None)
        {
            charFormatting.Underline = Windows.UI.Text.UnderlineType.Single;
        }
        else {
            charFormatting.Underline = Windows.UI.Text.UnderlineType.None;
        }
        selectedText.CharacterFormat = charFormatting;
    }
}
```

## -see-also

[Control](control.md), [RichEditBox styles and templates](https://msdn.microsoft.com/library/12fc81ba-c638-4b41-8aa4-7c0fb5a43f97), [RichEditBox overview](https://docs.microsoft.com/windows/uwp/design/controls-and-patterns/rich-edit-box), [Touch keyboard text input sample (Windows 10)](https://go.microsoft.com/fwlink/p/?LinkId=690716)
