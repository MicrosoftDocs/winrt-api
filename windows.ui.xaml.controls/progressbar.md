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

Equivalent **WinUI 2 API for UWP**: [Microsoft.UI.Xaml.Controls.ProgressBar](/windows/winui/api/microsoft.ui.xaml.controls.progressbar) (for WinUI in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -xaml-syntax
```xaml
<ProgressBar .../>
```


## -remarks

> [!TIP]
> For more info, design guidance, and code examples, see [Progress controls](/windows/uwp/controls-and-patterns/progress-controls).

A ProgressBar control visually indicates progress of an operation with one of two styles: a bar that displays a repeating pattern, or a bar that fills based on a value.

<img src="images/controls/ProgressBar_Indeterminate.png" alt="Indeterminate progress bar control" />

<img alt="Progress bar control" src="images/controls/ProgressBar_Determinate.png" />

The [IsIndeterminate](progressbar_isindeterminate.md) property determines the appearance of a ProgressBar.
+ Set [IsIndeterminate](progressbar_isindeterminate.md) to **true** to display a repeating pattern. An alternative control to use for indeterminate progress is a [ProgressRing](progressring.md).
+ Set [IsIndeterminate](progressbar_isindeterminate.md) to **false** to fill the bar based on a value. When [IsIndeterminate](progressbar_isindeterminate.md) is **false**, you specify the range with the [Minimum](../windows.ui.xaml.controls.primitives/rangebase_minimum.md) and [Maximum](../windows.ui.xaml.controls.primitives/rangebase_maximum.md) properties. By default [Minimum](../windows.ui.xaml.controls.primitives/rangebase_minimum.md) is 0 and [Maximum](../windows.ui.xaml.controls.primitives/rangebase_maximum.md) is 100. To specify the progress value, you set the [Value](../windows.ui.xaml.controls.primitives/rangebase_value.md) property.

### Control style and template

You can modify the default [Style](../windows.ui.xaml/style.md) and [ControlTemplate](controltemplate.md) to give the control a unique appearance. For information about modifying a control's style and template, see [Styling controls](/windows/uwp/controls-and-patterns/styling-controls). The default style, template, and resources that define the look of the control are included in the `generic.xaml` file. For design purposes, `generic.xaml` is available locally with the SDK or NuGet package installation.

- **WinUI Styles (recommended):** Use [Microsoft.UI.Xaml.Controls.ProgressBar](/windows/winui/api/microsoft.ui.xaml.controls.progressbar).
- **Non-WinUI styles:** For built-in styles, see `%ProgramFiles(x86)%\Windows Kits\10\DesignTime\CommonConfiguration\Neutral\UAP\<SDK version>\Generic\generic.xaml`.

Locations might be different if you customized the installation. Styles and resources from different versions of the SDK might have different values.

XAML also includes resources that you can use to modify the colors of a control in different visual states without modifying the control template. Modifying these resources is preferred to setting properties such as [Background](control_background.md) and [Foreground](control_foreground.md). For more info, see the [Light-weight styling](/windows/apps/design/style/xaml-styles#lightweight-styling) section of the [XAML styles](/windows/apps/design/style/xaml-styles) article. Light-weight styling resources are available starting in Windows 10, version 1607 (SDK 14393).

### Notes for previous versions

> **Windows 8.x**
> In an app compiled for Windows 8, when the ProgressBar is indeterminate, the progress animation continues even if it's not visible on the screen, such as when the ProgressBar  [Visibility](../windows.ui.xaml/uielement_visibility.md) is [Collapsed](../windows.ui.xaml/visibility.md). This can keep the UI thread awake, use resources, and impair app performance. When the ProgressBar is not visible, you should disable the animation by setting [IsIndeterminate](progressbar_isindeterminate.md) to **false**.

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [Progress controls](/windows/uwp/controls-and-patterns/progress-controls).
>
> If you have the **WinUI 2 Gallery** app installed, click here to [open the app and see the ProgressBar in action](winui2gallery:/item/ProgressBar).
> + [Get the WinUI 2 Gallery app (Microsoft Store)](https://www.microsoft.com/store/productId/9MSVH128X2ZT)
> + [Get the source code (GitHub)](https://github.com/Microsoft/WinUI-Gallery)

The following example demonstrates a value-based ProgressBar and an indeterminate ProgressBar.

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

## -see-also
[Progress controls overview](/windows/uwp/controls-and-patterns/progress-controls), [ProgressRing](progressring.md), [Controls list](/windows/uwp/design/controls-and-patterns/)
