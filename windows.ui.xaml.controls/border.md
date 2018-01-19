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
[Border](border.md) is a container control that draws a border, background, or both, around another object. Here's a gray border around two rectangles.

<img alt="A border around 2 rectangles" src="images/controls/Border.png" />

You can specify basic properties of a [Border](border.md) by setting its [Width](../windows.ui.xaml/frameworkelement_width.md), [Height](../windows.ui.xaml/frameworkelement_height.md), [BorderBrush](border_borderbrush.md), [BorderThickness](border_borderthickness.md), and [Background](border_background.md) color. In addition, you can round the border corners by setting the [CornerRadius](border_cornerradius.md) property, and you can position the object inside the [Border](border.md) by setting the [Padding](border_padding.md) property.

A [Border](border.md) can contain only one child object. If you want to put a border around multiple objects, wrap them in a container object such as [StackPanel](stackpanel.md).

## -examples

<table>
<th align="left">XAML Controls Gallery<th>
<tr>
<td><img src="images/xaml-controls-gallery-sm.png" alt="XAML controls gallery"></img></td>
<td>
    <p>If you have the <strong style="font-weight: semi-bold">XAML Controls Gallery</strong> app installed, click here to <a href="xamlcontrolsgallery:/item/Border">open the app and see the Border in action</a>.</p>
    <ul>
    <li><a href="https://www.microsoft.com/store/productId/9MSVH128X2ZT">Get the XAML Controls Gallery app (Microsoft Store)</a></li>
    <li><a href="https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/XamlUIBasics">Get the source code (GitHub)</a></li>
    </ul>
</td>
</tr>
</table>

This example shows how to put a [Border](border.md) around several [Rectangle](../windows.ui.xaml.shapes/rectangle.md) objects contained in a [StackPanel](stackpanel.md).

[!code-xml[BasicBorderXAML](../windows.ui.xaml.controls/code/BasicLayoutSnippets/CS/BlankPage.xaml#SnippetBasicBorderXAML)]

[!code-xml[LayoutOvwBorder](../windows.ui.xaml/code/layout_ovw_all/CSharp/MainPage.xaml#SnippetLayoutOvwBorder)]

## -see-also
[FrameworkElement](../windows.ui.xaml/frameworkelement.md), [Alignment, margin, and padding](http://msdn.microsoft.com/library/9412abd4-3674-4865-b07d-64c7c26e4842)
