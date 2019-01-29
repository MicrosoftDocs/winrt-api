---
-api-id: P:Windows.UI.Xaml.Controls.HandwritingView.PlacementAlignment
-api-type: winrt property
---

<!-- Property syntax.
public HandwritingPanelPlacementAlignment PlacementAlignment { get;  set; }
-->

# Windows.UI.Xaml.Controls.HandwritingView.PlacementAlignment

## -description

Gets or sets a value that specifies the anchor point used to place the handwriting view over the control.

## -property-value

An enunmeration value that specifies the anchor point used to place the handwriting view. The default is **Auto**.

## -remarks

The enumeration has these values: Auto, TopLeft, TopRight, BottomLeft, and BottomRight.

## -see-also

[Text input with the handwriting view](https://docs.microsoft.com/windows/uwp/design/controls-and-patterns/text-handwriting-view)

## -examples

Here, we show how to use the [PlacementAlignment​](https://docs.microsoft.com/uwp/api/windows.ui.xaml.controls.handwritingview.placementalignment) property of a [TextBox](https://docs.microsoft.com/uwp/api/windows.ui.xaml.controls.textbox) [HandwritingView](https://docs.microsoft.com/uwp/api/windows.ui.xaml.controls.handwritingview) to specify which anchor on the underlying text control is used to align the handwriting view.
​
```xaml
<TextBox Name="SampleTextBox"​
    Height="50" Width="500" ​
    FontSize="36" FontFamily="Segoe UI" ​
    PlaceholderText="Try taping with your pen">​
        <TextBox.HandwritingView>​
            <HandwritingView PlacementAlignment="TopLeft"/>​
        </TextBox.HandwritingView>​
</TextBox>​
```