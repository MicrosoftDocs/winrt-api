---
-api-id: E:Windows.UI.Xaml.Controls.TextBox.Paste
-api-type: winrt event
---

<!-- Event syntax
public event Windows.UI.Xaml.Controls.TextControlPasteEventHandler Paste
-->

# Windows.UI.Xaml.Controls.TextBox.Paste

## -description
Occurs when text is pasted into the control.



## -xaml-syntax
```xaml
<TextBox Paste="eventhandler"/>
```


## -remarks
The Paste event occurs before any content is inserted into the control. You can handle this event to check the contents of the clipboard and perform any actions on the content before it's inserted. If you perform any action, set the [Handled](textcontrolpasteeventargs_handled.md) property of the event args to **true**; otherwise, the default paste action is performed. If you mark the event as handled, then it's assumed the app has handled the paste operation, and no default action is performed. You are responsible for determining the insertion point and clipboard content to insert, and inserting the content.

You should set the [Handled](textcontrolpasteeventargs_handled.md) property to **true** in your handler before the code to perform a custom paste action. Otherwise, the default paste action is performed, and then the custom action is performed. The user can see the content changing in the [TextBox](textbox.md).



## -examples
This example shows how to handle the Paste event to replace line breaks with commas when pasting into an address field. Otherwise, pasting an address copied from multiple lines would cause data loss.

```xaml
<TextBox Header="Address" Paste="AddressTextBox_Paste"/>
```

```csharp
private async void AddressTextBox_Paste(object sender, TextControlPasteEventArgs e)
{
    TextBox addressBox = sender as TextBox;
    if (addressBox != null)
    {
        // Mark the event as handled first. Otherwise, the
        // default paste action will happen, then the custom paste
        // action, and the user will see the text box content change.
        e.Handled = true;

        // Get content from the clipboard.
        var dataPackageView = Windows.ApplicationModel.DataTransfer.Clipboard.GetContent();
        if (dataPackageView.Contains(Windows.ApplicationModel.DataTransfer.StandardDataFormats.Text))
        {
            try
            {
                var text = await dataPackageView.GetTextAsync();
                
                // Remove line breaks from multi-line text and
                // replace with comma(,).
                string singleLineText = text.Replace("\r\n", ", ");

                // Replace any text currently in the text box.
                addressBox.Text = singleLineText;
            }
            catch (Exception)
            {
                // Ignore or handle exception as needed.
            }
        }
    }
}
```

This example shows how to handle the Paste event to limit the number of characters pasted into the [TextBox](textbox.md). If the length of the text on the clipboard exceeds the [MaxLength](textbox_maxlength.md) of the [TextBox](textbox.md), a message is shown to the user. The user has the option to continue with the text truncated, or cancel the paste operation.

```xaml
<TextBox Paste="TextBox_Paste" MaxLength="10"/>
```

```csharp
private async void TextBox_Paste(object sender, TextControlPasteEventArgs e)
{
    TextBox tb = sender as TextBox;
    if (tb != null)
    {
        // Mark the event as handled first. Otherwise, the
        // default paste action will happen, then the custom paste
        // action, and the user will see the text box content change.
        e.Handled = true;

        // Get content from the clipboard.
        var dataPackageView = Windows.ApplicationModel.DataTransfer.Clipboard.GetContent();
        if (dataPackageView.Contains(Windows.ApplicationModel.DataTransfer.StandardDataFormats.Text))
        {
            try
            {
                var text = await dataPackageView.GetTextAsync();
                if (text.Length > tb.MaxLength)
                {
                    // Pasted text is too long. Show a message to the user.
                    // Create the message dialog and set its content
                    var messageDialog = 
                        new Windows.UI.Popups.MessageDialog(
                            "Pasted text excedes maximum allowed (" 
                            + tb.MaxLength.ToString() + 
                            " characters). The text will be truncated.");

                    // Add commands to the message dialog.
                    messageDialog.Commands.Add(new UICommand("Continue", (command) =>
                    {
                        // Truncate the text to be pasted to the MaxLength of the text box.
                        string truncatedText = text.Substring(0, tb.MaxLength);
                        tb.Text = truncatedText;
                    }));
                    messageDialog.Commands.Add(new UICommand("Cancel", (command) =>
                    {
                        // Cancelled. Do nothing.
                    }));

                    // Set the command that will be invoked by default.
                    messageDialog.DefaultCommandIndex = 0;

                    // Set the command to be invoked when escape is pressed.
                    messageDialog.CancelCommandIndex = 1;

                    // Show the message dialog.
                    await messageDialog.ShowAsync();
                }
                else
                {
                    tb.Text = text;
                }                          
            }
            catch (Exception)
            {
                // Ignore or handle exception as needed.
            }
        }
    }
}
```



## -see-also
