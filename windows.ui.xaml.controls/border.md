---
-api-id: T:Windows.UI.Xaml.Controls.Border
-api-type: winrt class
---

<!-- Class syntax.
public class Border : Windows.UI.Xaml.FrameworkElement, Windows.UI.Xaml.Controls.IBorder
-->

# Windows.UI.Xaml.Controls.Border

## -description
Draws a border, background, or both, around another object.


## -xaml-syntax
```xaml
<Border>
  singleChild
</Border>

```


## -remarks
Border is a container control that draws a border, background, or both, around another object. Here's a gray border around two rectangles.

<img alt="A border around 2 rectangles" src="images/controls/Border.png" />

You can specify basic properties of a Border by setting its [Width](../windows.ui.xaml/frameworkelement_width.md), [Height](../windows.ui.xaml/frameworkelement_height.md), [BorderBrush](border_borderbrush.md), [BorderThickness](border_borderthickness.md), and [Background](border_background.md) color. In addition, you can round the border corners by setting the [CornerRadius](border_cornerradius.md) property, and you can position the object inside the Border by setting the [Padding](border_padding.md) property.

A Border can contain only one child object. If you want to put a border around multiple objects, wrap them in a container object such as [StackPanel](stackpanel.md).

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1809 | 17763 | BackgroundSizing |
| 1809 | 17763 | BackgroundTransition |

## -examples

> [!div class="nextstepaction"]
> [Open the WinUI 2 Gallery app and see the Border in action](winui2gallery:/item/Border)

> The **WinUI 2 Gallery** app includes interactive examples of most WinUI 2 controls, features, and functionality. Get the app from the [Microsoft Store](https://www.microsoft.com/store/productId/9MSVH128X2ZT) or get the source code on [GitHub](https://github.com/Microsoft/WinUI-Gallery/tree/winui2).

[!code-xaml[BasicBorderXAML](../windows.ui.xaml.controls/code/BasicLayoutSnippets/CS/BlankPage.xaml#SnippetBasicBorderXAML)]

[!code-xaml[LayoutOvwBorder](../windows.ui.xaml/code/layout_ovw_all/CSharp/MainPage.xaml#SnippetLayoutOvwBorder)]

## -see-also
[FrameworkElement](../windows.ui.xaml/frameworkelement.md), [Alignment, margin, and padding](/windows/uwp/layout/alignment-margin-padding)
