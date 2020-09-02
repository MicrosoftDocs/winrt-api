---
-api-id: P:Windows.UI.Xaml.Controls.RichEditBox.IsHandwritingViewEnabled
-api-type: winrt property
---

<!-- Property syntax.
public bool IsHandwritingViewEnabled { get;  set; }
-->

# Windows.UI.Xaml.Controls.RichEditBox.IsHandwritingViewEnabled

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

In this example, we disable the handwriting view by setting the [IsHandwritingViewEnabled](/uwp/api/windows.ui.xaml.controls.richeditbox.ishandwritingviewenabled) ​property of the [RichEditBox](/uwp/api/windows.ui.xaml.controls.richeditbox) control to false. All text controls that support the handwriting view support a similar property.
​
```xaml
<RichEditBox Name="NoHandwritingRichEditBox" 
    Width="680"
    FontSize="24" 
    VerticalAlignment="Top" HorizontalAlignment="Center" 
    IsHandwritingViewEnabled="False">​
    PlaceholderText="Handwriting view not supported">
</RichEditBox>
```