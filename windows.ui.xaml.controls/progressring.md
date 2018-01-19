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
[ProgressRing](progressring.md) is a control that indicates indeterminate progress by displaying an animated ring.

<img alt="Progress ring control" src="images/controls/ProgressRing.png" />

Use a [ProgressRing](progressring.md) to visually indicate that an operation is in progress. Set the [IsActive](progressring_isactive.md) property to turn the [ProgressRing](progressring.md) on or off. If [IsActive](progressring_isactive.md) is false, the [ProgressRing](progressring.md) is not shown, but space is reserved for it in the UI layout. To not reserve space for the [ProgressRing](progressring.md), set its [Visibility](../windows.ui.xaml/uielement_visibility.md) property to [Collapsed](../windows.ui.xaml/visibility.md).

### Notes for Windows 8.x

> **Windows 8.x**
> In an app compiled for Windows 8, when the [ProgressRing](progressring.md) is active, the progress animation continues even if its not visible on the screen, such as when it's [Visibility](../windows.ui.xaml/uielement_visibility.md) is [Collapsed](../windows.ui.xaml/visibility.md). This can keep the UI thread awake, use resources, and impair app performance. When the [ProgressRing](progressring.md) is not visible, you should disable the animation by setting [IsActive](progressring_isactive.md) to **false**.

## -examples

<table>
<th align="left">XAML Controls Gallery<th>
<tr>
<td><img src="images/xaml-controls-gallery-sm.png" alt="XAML controls gallery"></img></td>
<td>
    <p>If you have the <strong style="font-weight: semi-bold">XAML Controls Gallery</strong> app installed, click here to open the app and see the <a href="xamlcontrolsgallery:/item/ProgressRing">ProgressRing</a> in action.</p>
    <ul>
    <li><a href="https://www.microsoft.com/store/productId/9MSVH128X2ZT">Get the XAML Controls Gallery app (Microsoft Store)</a></li>
    <li><a href="https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/XamlUIBasics">Get the source code (GitHub)</a></li>
    </ul>
</td>
</tr>
</table>

This example shows how to set the [IsActive](progressring_isactive.md) property of a [ProgressRing](progressring.md) in code. A [ToggleSwitch](toggleswitch.md) is used to turn the[ProgressRing](progressring.md) control on or off.

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
[Progress controls overview](https://docs.microsoft.com/windows/uwp/controls-and-patterns/progress-controls), [ProgressRing styles and templates](http://msdn.microsoft.com/library/ea3c6fe2-af06-4ada-8f77-cb78bd1388da), [ProgressBar](progressbar.md), [Controls list](http://msdn.microsoft.com/library/11172840-a63d-4f48-9db4-7baca06308ee), [Controls by function](http://msdn.microsoft.com/library/8db4347b-91d6-4659-91f2-80ecf7bbb596)