---
-api-id: T:Windows.UI.Xaml.Controls.ProgressRing
-api-type: winrt class
---

<!-- Class syntax.
public class ProgressRing : Windows.UI.Xaml.Controls.Control, Windows.UI.Xaml.Controls.IProgressRing
-->

# Windows.UI.Xaml.Controls.ProgressRing

## -description
Represents a control that indicates that an operation is ongoing. The typical visual appearance is a ring-shaped "spinner" that cycles an animation as progress continues.

Equivalent **WinUI 2 API for UWP**: [Microsoft.UI.Xaml.Controls.ProgressRing](/windows/winui/api/microsoft.ui.xaml.controls.progressring) (for WinUI in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -xaml-syntax
```xaml
<ProgressRing .../>
```


## -remarks

> [!TIP]
> For more info, design guidance, and code examples, see [[Progress controls](/windows/uwp/controls-and-patterns/progress-controls).

ProgressRing is a control that indicates indeterminate progress by displaying an animated ring.

<img alt="Progress ring control" src="images/controls/ProgressRing.png" />

Use a ProgressRing to visually indicate that an operation is in progress. Set the [IsActive](progressring_isactive.md) property to turn the ProgressRing on or off. If [IsActive](progressring_isactive.md) is false, the ProgressRing is not shown, but space is reserved for it in the UI layout. To not reserve space for the ProgressRing, set its [Visibility](../windows.ui.xaml/uielement_visibility.md) property to [Collapsed](../windows.ui.xaml/visibility.md).

### Control style and template

You can modify the default [Style](../windows.ui.xaml/style.md) and [ControlTemplate](controltemplate.md) to give the control a unique appearance. For information about modifying a control's style and template, see [Styling controls](/windows/uwp/controls-and-patterns/styling-controls). The default style, template, and resources that define the look of the control are included in the `generic.xaml` file. For design purposes, `generic.xaml` is available locally with the SDK or NuGet package installation.

- **WinUI Styles (recommended):** Use [Microsoft.UI.Xaml.Controls.ProgressRing](/windows/winui/api/microsoft.ui.xaml.controls.progressring).
- **Non-WinUI styles:** For built-in styles, see `%ProgramFiles(x86)%\Windows Kits\10\DesignTime\CommonConfiguration\Neutral\UAP\<SDK version>\Generic\generic.xaml`.

Locations might be different if you customized the installation. Styles and resources from different versions of the SDK might have different values.

XAML also includes resources that you can use to modify the colors of a control in different visual states without modifying the control template. Modifying these resources is preferred to setting properties such as [Background](control_background.md) and [Foreground](control_foreground.md). For more info, see the [Light-weight styling](/windows/apps/design/style/xaml-styles#lightweight-styling) section of the [XAML styles](/windows/apps/design/style/xaml-styles) article. Light-weight styling resources are available starting in Windows 10, version 1607 (SDK 14393).

### Notes for previous versions

> **Windows 8.x**
> In an app compiled for Windows 8, when the ProgressRing is active, the progress animation continues even if its not visible on the screen, such as when its [Visibility](../windows.ui.xaml/uielement_visibility.md) is [Collapsed](../windows.ui.xaml/visibility.md). This can keep the UI thread awake, use resources, and impair app performance. When the ProgressRing is not visible, you should disable the animation by setting [IsActive](progressring_isactive.md) to **false**.

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [[Progress controls](/windows/uwp/controls-and-patterns/progress-controls).
>
> If you have the **WinUI 2 Gallery** app installed, click here to [open the app and see the ProgressRing in action](winui2gallery:/item/ProgressRing).
> + [Get the WinUI 2 Gallery app (Microsoft Store)](https://www.microsoft.com/store/productId/9MSVH128X2ZT)
> + [Get the source code (GitHub)](https://github.com/Microsoft/WinUI-Gallery)

This example shows how to set the [IsActive](progressring_isactive.md) property of a ProgressRing in code. A [ToggleSwitch](toggleswitch.md) is used to turn theProgressRing control on or off.

```xaml
            <StackPanel Orientation="Horizontal">
                <ToggleSwitch Header="Toggle Switch Example" OffContent="Do work" 
                              OnContent="Working" Toggled="ToggleSwitch_Toggled"/>  
                <ProgressRing x:Name="progress1"/>
            </StackPanel>
```

```csharp
        private void ToggleSwitch_Toggled(object sender, RoutedEventArgs e)
        {
            ToggleSwitch toggleSwitch = sender as ToggleSwitch;
            if (toggleSwitch != null)
            {
                if (toggleSwitch.IsOn == true)
                {
                    progress1.IsActive = true;
                    progress1.Visibility = Visibility.Visible;
                }
                else
                {
                    progress1.IsActive = false;
                    progress1.Visibility = Visibility.Collapsed;
                }
            }
        }
```



## -see-also
[Progress controls overview](/windows/uwp/controls-and-patterns/progress-controls), [ProgressBar](progressbar.md), [Controls list](/windows/uwp/design/controls-and-patterns/), [Controls by function](/windows/uwp/controls-and-patterns/controls-by-function)
