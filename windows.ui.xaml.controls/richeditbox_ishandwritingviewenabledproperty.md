---
-api-id: P:Windows.UI.Xaml.Controls.RichEditBox.IsHandwritingViewEnabledProperty
-api-type: winrt property
---

<!-- Property syntax.
public DependencyProperty IsHandwritingViewEnabledProperty { get; }
-->

# Windows.UI.Xaml.Controls.RichEditBox.IsHandwritingViewEnabledProperty

## -description

Identifies the IsHandwritingViewEnabled dependency property.

## -property-value

The identifier for the IsHandwritingViewEnabled dependency property.

## -remarks

## -see-also

[Text input with the handwriting view](/windows/uwp/design/controls-and-patterns/text-handwriting-view)

## -examples

In this example, we disable the handwriting view by setting the [IsHandwritingViewEnabled](/uwp/api/windows.ui.xaml.controls.textbox.ishandwritingviewenabled) ​property of the [RichEditBox](/uwp/api/windows.ui.xaml.controls.richeditbox) control to false. All text controls that support the handwriting view support a similar property.
​
```xaml
<RIchEditBox Name="SampleTextBox"​
    Height="50" Width="500" ​
    FontSize="36" FontFamily="Segoe UI" ​
    PlaceholderText="Try taping with your pen" ​
    IsHandwritingViewEnabled="False">​
</RichEditBox>​
```
