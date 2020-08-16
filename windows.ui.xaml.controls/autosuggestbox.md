---
-api-id: T:Windows.UI.Xaml.Controls.AutoSuggestBox
-api-type: winrt class
---

<!-- Class syntax.
public class AutoSuggestBox : Windows.UI.Xaml.Controls.ItemsControl, Windows.UI.Xaml.Controls.IAutoSuggestBox, Windows.UI.Xaml.Controls.IAutoSuggestBox2, Windows.UI.Xaml.Controls.IAutoSuggestBox3
-->

# Windows.UI.Xaml.Controls.AutoSuggestBox

## -description

Represents a text control that makes suggestions to users as they enter text using a keyboard or pen (using ink and handwriting recognition). The app is notified when text has been changed by the user and is responsible for providing relevant suggestions for this control to display.

## -xaml-syntax

```xaml
<AutoSuggestBox .../>
```

## -remarks

> [!TIP]
> For more info, design guidance, and code examples, see [Auto-suggest box](/windows/uwp/design/controls-and-patterns/auto-suggest-box).

Use an AutoSuggestBox to provide a list of suggestions for a user to select from as they type.

By default, the text entry box doesn’t have a query button shown. You can set the [QueryIcon](autosuggestbox_queryicon.md) property to add a button with the specified icon on the right side of the text box. For example, to make the AutoSuggestBox look like a typical search box, add a ‘find’ icon, like this.

```xaml
<AutoSuggestBox QueryIcon="Find"/>
```

Here's an AutoSuggestBox with a 'find' icon. The suggestion list shows suggested results based on the user's entry.

<img src="images/controls/AutoSuggestBox_Open.png" alt="An auto suggest box with an icon and suggestions" />
To use an AutoSuggestBox, you need to respond to 3 user actions.

+ Text changed - When the user enters text, update the suggestion list.
+ Suggestion chosen - When the user chooses a suggestion in the suggestion list, update the text box.
+ Query submitted - When the user submits a query, show the query results.

### Text changed

The [TextChanged](autosuggestbox_textchanged.md) event occurs whenever the content of the text box is updated. Use the event args [Reason](autosuggestboxtextchangedeventargs_reason.md) property to determine whether the change was due to user input. If the change reason is **UserInput**, filter your data based on the input. Then, set the filtered data as the [ItemsSource](itemscontrol_itemssource.md) of the AutoSuggestBox to update the suggestion list.

To control how items are displayed in the suggestion list, you can use [DisplayMemberPath](itemscontrol_displaymemberpath.md) or [ItemTemplate](itemscontrol_itemtemplate.md).

+ To display the text of a single property of your data item, set the [DisplayMemberPath](itemscontrol_displaymemberpath.md) property to choose which property from your object to display in the suggestion list.
+ To define a custom look for each item in the list, use the [ItemTemplate](itemscontrol_itemtemplate.md) property .

### Suggestion chosen

When a user navigates through the suggestion list using the keyboard, you need to update the text in the text box to match.

You can set the [TextMemberPath](autosuggestbox_textmemberpath.md) property to choose which property from your data object to display in the text box. If you specify a [TextMemberPath](autosuggestbox_textmemberpath.md), the text box is updated automatically. You should typically specify the same value for [DisplayMemberPath](itemscontrol_displaymemberpath.md) and [TextMemberPath](autosuggestbox_textmemberpath.md) so the text is the same in the suggestion list and the text box.

If you need to show more than a simple property, handle the [SuggestionChosen](autosuggestbox_suggestionchosen.md) event to populate the text box with custom text based on the selected item.

### Query submitted

Handle the [QuerySubmitted](autosuggestbox_querysubmitted.md) event to perform a query action appropriate to your app and show result to the user.

The [QuerySubmitted](autosuggestbox_querysubmitted.md) event occurs when a user commits a query string. The user can commit a query in one of these ways:
+ While focus is in the text box, press Enter or click the query icon. The event args [ChosenSuggestion](autosuggestboxquerysubmittedeventargs_chosensuggestion.md) property is **null**.
+ While focus is in the suggestion list, press Enter, click, or tap an item. The event args [ChosenSuggestion](autosuggestboxquerysubmittedeventargs_chosensuggestion.md) property contains the item that was selected from the list.
 In all cases, the event args [QueryText](autosuggestboxquerysubmittedeventargs_querytext.md) property contains the text from the text box.

### Accessibility

If you are using an assistive technology, such as [Narrator](https://support.microsoft.com/help/17173/windows-10-hear-text-read-aloud), to interact with the AutoSuggestBox the accessibility experience has already been hooked up for you. A user will:

+ Know the list is present and when the list closes
+ Know how many suggestions are available
+ Be able to move Narrator focus to the list
+ Be able to Navigate through a suggestion with all other reading modes
See [Auto-suggest accessibility](https://docs.microsoft.com/windows/uwp/design/accessibility/accessible-text-requirements#auto-suggest-accessibility) for more information.

## Pen input

Starting with Windows 10, version 1803, XAML text input boxes feature embedded support for pen input using [Windows Ink](../input/pen-and-stylus-interactions.md). When a user taps into a text input box using a Windows pen, the text box transforms to let the user write directly into it with a pen, rather than opening a separate input panel.

You can configure the handwriting view of the AutoSuggestBox through its TextBox control, as we show here.

```xaml
<AutoSuggestBox Name="NoHandwritingAutoSuggestBox"
        BorderThickness="0"  Width="680"
        FontSize="24" VerticalAlignment="Top"
        HorizontalAlignment="Center"
        PlaceholderText="Handwriting view is not supported">
    <AutoSuggestBox.TextBoxStyle>
        <Style TargetType="TextBox">
            <Setter Property="IsHandwritingViewEnabled" Value="False"/>
        </Style>
    </AutoSuggestBox.TextBoxStyle>
</AutoSuggestBox>
```

<img src="images/controls/handwritingview-inksuggestion1.gif" alt="Text box with ink and suggestions" />

For more info, see [Text input with the handwriting view](https://docs.microsoft.com/windows/uwp/design/controls-and-patterns/text-handwriting-view).

### Control style and template

You can modify the default [Style](../windows.ui.xaml/style.md) and [ControlTemplate](controltemplate.md) to give the control a unique appearance. For information about modifying a control's style and template, see [Styling controls](https://docs.microsoft.com/windows/uwp/controls-and-patterns/styling-controls). The default style, template, and resources that define the look of the control are included in the generic.xaml file. For design purposes, generic.xaml is available in the \(Program Files)\Windows Kits\10\DesignTime\CommonConfiguration\Neutral\UAP\ &lt;SDK version&gt;\Generic folder from a Windows Software Development Kit (SDK) installation. Styles and resources from different versions of the SDK might have different values.

Starting in Windows 10, version 1607 (SDK 14393), generic.xaml includes resources that you can use to modify the colors of a control in different visual states without modifying the control template. In apps that target this software development kit (SDK) or later, modifying these resources is preferred to setting properties such as [Background](control_background.md) and [Foreground](control_foreground.md). For more info, see the [Light-weight styling](https://docs.microsoft.com/windows/uwp/controls-and-patterns/styling-controls) section of the [Styling controls](https://docs.microsoft.com/windows/uwp/controls-and-patterns/styling-controls) article.

This table shows the resources used by the AutoSuggestBox control. Resources that start with "TextControl" are shared by [TextBox](textbox.md), [PasswordBox](passwordbox.md), [RichEditBox](richeditbox.md), and AutoSuggestBox.

<table>
   <tr><th>Resource key</th><th>Description</th></tr>
   <tr><td>AutoSuggestBoxSuggestionsListBackground</td><td>Background color of suggestion list</td></tr>
   <tr><td>AutoSuggestBoxSuggestionsListBorderBrush</td><td>Border color of suggestion list</td></tr>
   <tr><td>TextControlForeground</td><td>Text color at rest</td></tr>
   <tr><td>TextControlForegroundPointerOver</td><td>Text color on hover</td></tr>
   <tr><td>TextControlForegroundFocused</td><td>Text color when focused</td></tr>
   <tr><td>TextControlForegroundDisabled</td><td>Text color when disabled</td></tr>
   <tr><td>TextControlBackground</td><td>Background color at rest</td></tr>
   <tr><td>TextControlBackgroundPointerOver</td><td>Background color on hover</td></tr>
   <tr><td>TextControlBackgroundFocused</td><td>Background color when focused</td></tr>
   <tr><td>TextControlBackgroundDisabled</td><td>Background color when disabled</td></tr>
   <tr><td>TextControlBorderBrush</td><td>Border color at rest</td></tr>
   <tr><td>TextControlBorderBrushPointerOver</td><td>Border color on hover</td></tr>
   <tr><td>TextControlBorderBrushFocused</td><td>Border color when focused</td></tr>
   <tr><td>TextControlBorderBrushDisabled</td><td>Border color when disabled</td></tr>
   <tr><td>TextControlPlaceholderForeground</td><td>Placeholder text color at rest</td></tr>
   <tr><td>TextControlPlaceholderForegroundPointerOver</td><td>Placeholder text color on hover</td></tr>
   <tr><td>TextControlPlaceholderForegroundFocused</td><td>Placeholder text color when focused</td></tr>
   <tr><td>TextControlPlaceholderForegroundDisabled</td><td>Placeholder text color when disabled</td></tr>
   <tr><td>TextControlHeaderForeground</td><td>Header text color at rest</td></tr>
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

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1607 | 14393 | LightDismissOverlayMode |
| 1809 | 17763 | Description |

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [Auto-suggest box](/windows/uwp/design/controls-and-patterns/auto-suggest-box).
>
> If you have the **XAML Controls Gallery** app installed, click here to [open the app and see the AutoSuggestBox in action](xamlcontrolsgallery:/item/AutoSuggestBox).
> + [Get the XAML Controls Gallery app (Microsoft Store)](https://www.microsoft.com/p/xaml-controls-gallery/9msvh128x2zt)
> + [Get the source code (GitHub)](https://github.com/Microsoft/Xaml-Controls-Gallery)

To see a complete working example of AutoSuggestBox, see the [AutoSuggestBox migration sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/XamlAutoSuggestBox?amp;amp;clcid=0x409).

Here is a simple AutoSuggestBox with the required event handlers.

```xaml
<AutoSuggestBox PlaceholderText="Search" QueryIcon="Find" Width="200"
                TextChanged="AutoSuggestBox_TextChanged"
                QuerySubmitted="AutoSuggestBox_QuerySubmitted"
                SuggestionChosen="AutoSuggestBox_SuggestionChosen"/>
```

```csharp
private void AutoSuggestBox_TextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
{
    // Only get results when it was a user typing, 
    // otherwise assume the value got filled in by TextMemberPath 
    // or the handler for SuggestionChosen.
    if (args.Reason == AutoSuggestionBoxTextChangeReason.UserInput)
    {
        //Set the ItemsSource to be your filtered dataset
        //sender.ItemsSource = dataset;
    }
}


private void AutoSuggestBox_SuggestionChosen(AutoSuggestBox sender, AutoSuggestBoxSuggestionChosenEventArgs args)
{
    // Set sender.Text. You can use args.SelectedItem to build your text string.
}


private void AutoSuggestBox_QuerySubmitted(AutoSuggestBox sender, AutoSuggestBoxQuerySubmittedEventArgs args)
{
    if (args.ChosenSuggestion != null)
    {
        // User selected an item from the suggestion list, take an action on it here.
    }
    else
    {
        // Use args.QueryText to determine what to do.
    }
}
```



## -see-also
[ItemsControl](itemscontrol.md), [IItemContainerMapping](iitemcontainermapping.md), [AutoSuggestBox styles and templates](https://docs.microsoft.com/windows/uwp/design/controls-and-patterns/xaml-styles), [AutoSuggestBox migration sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/XamlAutoSuggestBox), [Guidelines for auto-suggest boxes](https://docs.microsoft.com/windows/uwp/design/controls-and-patterns/auto-suggest-box), [Search and find-in-page](https://docs.microsoft.com/windows/uwp/design/controls-and-patterns/search)
