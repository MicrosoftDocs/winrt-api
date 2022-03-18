---
-api-id: P:Windows.UI.Xaml.Controls.TextBox.IsHandwritingViewEnabled
-api-type: winrt property
---

<!-- Property syntax.
public bool IsHandwritingViewEnabled { get;  set; }
-->

# Windows.UI.Xaml.Controls.TextBox.IsHandwritingViewEnabled

## -description

Gets or sets a value that indicates whether a user can enter text in the handwriting view.

## -property-value

**true** to allow the user to enter text in the handwriting view; otherwise, **false**.

## -remarks

When a user taps into a text input box using a Windows pen, the text box transforms to let the user write directly into it with a pen, rather than opening a separate input panel.

<img src="images/controls/handwritingview-inksuggestion1.gif" alt="Text box with ink and suggestions" />

## -see-also

[Text input with the handwriting view](/windows/uwp/design/controls-and-patterns/text-handwriting-view)

## -examples

In this example, we disable the handwriting view by setting the [IsHandwritingViewEnabled](/uwp/api/windows.ui.xaml.controls.textbox.ishandwritingviewenabled) ​property of the [TextBox](/uwp/api/windows.ui.xaml.controls.textbox) control to false. All text controls that support the handwriting view support a similar property.
​
```xaml
<TextBox Name="SampleTextBox"​
    Height="50" Width="500" ​
    FontSize="36" FontFamily="Segoe UI" ​
    PlaceholderText="Try taping with your pen" ​
    IsHandwritingViewEnabled="False">​
</TextBox>​
```
