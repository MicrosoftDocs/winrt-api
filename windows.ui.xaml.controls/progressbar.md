---
-api-id: T:Windows.UI.Xaml.Controls.ProgressBar
-api-type: winrt class
---

<!-- Class syntax.
public class ProgressBar : Windows.UI.Xaml.Controls.Primitives.RangeBase, Windows.UI.Xaml.Controls.IProgressBar
-->

# Windows.UI.Xaml.Controls.ProgressBar

## -description
Represents a control that indicates the progress of an operation, where the typical visual appearance is a bar that animates a filled area as progress continues.

## -xaml-syntax
```xaml
<ProgressBar .../>
```


## -remarks
A [ProgressBar](progressbar.md) control visually indicates progress of an operation with one of two styles: a bar that displays a repeating pattern, or a bar that fills based on a value.

<img src="images/controls/ProgressBar_Indeterminate.png" alt="Indeterminate progress bar control" />

<img alt="Progress bar control" src="images/controls/ProgressBar_Determinate.png" />

The [IsIndeterminate](progressbar_isindeterminate.md) property determines the appearance of a [ProgressBar](progressbar.md).
+ Set [IsIndeterminate](progressbar_isindeterminate.md) to **true** to display a repeating pattern. An alternative control to use for indeterminate progress is a [ProgressRing](progressring.md).
+ Set [IsIndeterminate](progressbar_isindeterminate.md) to **false** to fill the bar based on a value. When [IsIndeterminate](progressbar_isindeterminate.md) is **false**, you specify the range with the [Minimum](../windows.ui.xaml.controls.primitives/rangebase_minimum.md) and [Maximum](../windows.ui.xaml.controls.primitives/rangebase_maximum.md) properties. By default [Minimum](../windows.ui.xaml.controls.primitives/rangebase_minimum.md) is 0 and [Maximum](../windows.ui.xaml.controls.primitives/rangebase_maximum.md) is 1. To specify the progress value, you set the [Value](../windows.ui.xaml.controls.primitives/rangebase_value.md) property.


### Notes for Windows 8.x

> **Windows 8.x**
> In an app compiled for Windows 8, when the [ProgressBar](progressbar.md) is indeterminate, the progress animation continues even if it's not visible on the screen, such as when the [ProgressBar](progressbar.md)  [Visibility](../windows.ui.xaml/uielement_visibility.md) is [Collapsed](../windows.ui.xaml/visibility.md). This can keep the UI thread awake, use resources, and impair app performance. When the [ProgressBar](progressbar.md) is not visible, you should disable the animation by setting [IsIndeterminate](progressbar_isindeterminate.md) to **false**.

## -examples
The following example demonstrates a value-based [ProgressBar](progressbar.md) and an indeterminate [ProgressBar](progressbar.md).

```xaml
<StackPanel x:Name="LayoutRoot">
    <StackPanel BorderBrush="Black" BorderThickness="4" Padding="12">
        <TextBlock Text="Value-Based Progress Bar"/>
        <ProgressBar x:Name="progressBar1" Value="0" Maximum="200" Margin="0,12"/>
        <RepeatButton Content="Press and hold" Click="RepeatButton_Click"/>
    </StackPanel>
    <StackPanel BorderThickness="4" BorderBrush="Black" Padding="12">
        <TextBlock Text="Indeterminate Progress Bar"/>
        <ProgressBar IsIndeterminate="True" Margin="0,12"/>
    </StackPanel>
</StackPanel>
```

```csharp

private static int _clicks = 0;

private void RepeatButton_Click(object sender, RoutedEventArgs e)
{
    _clicks += 1;
    progressBar1.Value = _clicks;
    if (_clicks >= progressBar1.Maximum) _clicks = 0;
}
```


<!--<auto_snippet sample_id="System.Windows.Controls.ProgressBarEx" snippet_id="3"/>-->

## -see-also
[RangeBase](../windows.ui.xaml.controls.primitives/rangebase.md), [ProgressBar styles and templates](http://msdn.microsoft.com/library/43967846-0b5c-47a8-a727-fbeeec96a25b), [ProgressRing](progressring.md), [Controls list](http://msdn.microsoft.com/library/11172840-a63d-4f48-9db4-7baca06308ee), [Controls by function](http://msdn.microsoft.com/library/8db4347b-91d6-4659-91f2-80ecf7bbb596)