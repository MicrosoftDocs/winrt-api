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

### Notes for Windows 8.x

> **Windows 8.x**
> In an app compiled for Windows 8, when the ProgressRing is active, the progress animation continues even if its not visible on the screen, such as when its [Visibility](../windows.ui.xaml/uielement_visibility.md) is [Collapsed](../windows.ui.xaml/visibility.md). This can keep the UI thread awake, use resources, and impair app performance. When the ProgressRing is not visible, you should disable the animation by setting [IsActive](progressring_isactive.md) to **false**.

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [[Progress controls](/windows/uwp/controls-and-patterns/progress-controls).
>
> If you have the **XAML Controls Gallery** app installed, click here to [open the app and see the ProgressRing in action](xamlcontrolsgallery:/item/ProgressRing).
> + [Get the XAML Controls Gallery app (Microsoft Store)](https://www.microsoft.com/store/productId/9MSVH128X2ZT)
> + [Get the source code (GitHub)](https://github.com/Microsoft/Xaml-Controls-Gallery)

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
[Progress controls overview](https://docs.microsoft.com/windows/uwp/controls-and-patterns/progress-controls), [ProgressBar](progressbar.md), [Controls list](https://docs.microsoft.com/windows/uwp/design/controls-and-patterns/), [Controls by function](https://docs.microsoft.com/windows/uwp/controls-and-patterns/controls-by-function)
