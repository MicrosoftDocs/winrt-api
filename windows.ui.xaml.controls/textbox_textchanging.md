---
-api-id: E:Windows.UI.Xaml.Controls.TextBox.TextChanging
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler TextChanging<Windows.UI.Xaml.Controls.TextBox,  Windows.UI.Xaml.Controls.TextBoxTextChangingEventArgs>
-->

# Windows.UI.Xaml.Controls.TextBox.TextChanging

## -description

Occurs synchronously when the text in the text box starts to change, but before it is rendered.



## -xaml-syntax

```xaml
<TextBox TextChanging="eventhandler"/>
```

## -remarks

For event data, see [TextBoxTextChangingEventArgs](textboxtextchangingeventargs.md).

The TextChanging event occurs synchronously before the new text is rendered. In contrast, the [TextChanged](textbox_textchanged.md) event is asynchronous and occurs after the new text is rendered.

When the TextChanging event occurs, the [Text](textbox_text.md) property already reflects the new value (but it's not rendered in the UI). You typically handle this event to update the [Text](textbox_text.md) value and selection before the text is rendered. This prevents the text flickering that can happen when text is rendered, updated, and re-rendered rapidly.

> [!NOTE]
> This is a synchronous event that can occur at times when changes to the XAML visual tree are not allowed, such as during layout. Therefore, you should limit code within the TextChanging event handler primarily to inspecting and updating the [Text](textbox_text.md) property. Attempting to perform other actions, such as showing a popup or adding/removing elements from the visual tree, might cause potentially fatal errors that can lead to a crash. We recommend that you perform these other changes either in a [TextChanged](textbox_textchanged.md) event handler, or run them as a separate asynchronous operation.

## -examples

This example shows how to handle the TextChanging event to implement simple auto-complete for a [TextBox](textbox.md).

```xaml
<!-- Text box in MainPage.xaml -->
<TextBox x:Name="textBox" TextChanging="textBox_TextChanging"
         Width="200" Height="32"/>
```

```csharp
public sealed partial class MainPage : Page
{
    // Boolean to keep track of whether or not you should ignore the next TextChanged event.  
    // This is needed to support the correct behavior when backspace is tapped.
    public bool m_ignoreNextTextChanged = false;

    // Sample list of strings to use in the autocomplete.
    public string[] m_options = { "microsoft.com", "dev.windows.com", "msn.com", "office.com", "msdn.microsoft.com" };

    public MainPage()
    {
        this.InitializeComponent();
    }

    private void textBox_TextChanging(TextBox sender, TextBoxTextChangingEventArgs args)
    {
        // Needed for the backspace scenario.
        if (m_ignoreNextTextChanged)
        {
            m_ignoreNextTextChanged = false;
            return;
        }
        // All other scenarios other than the backspace scenario.
        // Do the auto complete.
        else
        {
            string s = textBox.Text;
            if (s.Length > 0)
            {
                for (int i = 0; i < m_options.Length; i++)
                {
                    if (m_options[i].IndexOf(s) >= 0)
                    {
                        if (s == m_options[i])
                            break;

                        textBox.Text = m_options[i];
                        textBox.Select(s.Length, m_options[i].Length - s.Length);
                        break;
                    }
                }
            }
        }
    }

    protected override void OnKeyDown(KeyRoutedEventArgs e)
    {
        if (e.Key == Windows.System.VirtualKey.Back
            || e.Key == Windows.System.VirtualKey.Delete)
        {
            m_ignoreNextTextChanged = true;
        }
        base.OnKeyDown(e);
    }
}
```

## -see-also

[TextBoxTextChangingEventArgs](textboxtextchangingeventargs.md)
