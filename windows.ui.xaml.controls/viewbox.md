---
-api-id: T:Windows.UI.Xaml.Controls.Viewbox
-api-type: winrt class
---

<!-- Class syntax.
public class Viewbox : Windows.UI.Xaml.FrameworkElement, Windows.UI.Xaml.Controls.IViewbox
-->

# Windows.UI.Xaml.Controls.Viewbox

## -description
Defines a content decorator that can stretch and scale a single child to fill the available space.

## -xaml-syntax
```xaml
<ViewBox .../>
-or-
<ViewBox ...>
  child
</ViewBox>

```


## -remarks
Viewbox is a container control that scales its content to a specified size.

<img alt="Viewbox control" src="images/controls/Viewbox.png" />

## -examples

> [!TIP]
> If you have the **XAML Controls Gallery** app installed, click here to [open the app and see the ViewBox in action](xamlcontrolsgallery:/item/ViewBox).
> + [Get the XAML Controls Gallery app (Microsoft Store)](https://www.microsoft.com/store/productId/9MSVH128X2ZT)
> + [Get the source code (GitHub)](https://github.com/Microsoft/Xaml-Controls-Gallery)

The following example shows what happens when you change the [StretchDirection](viewbox_stretchdirection.md) and [Stretch](viewbox_stretch.md) properties of a Viewbox. The example includes three Viewbox controls that have different sizes. The same image is displayed in the Viewbox controls so that you can compare the differences. You can manipulate the stretching and scaling of the image by clicking the buttons that correspond to the values for the [Stretch](viewbox_stretch.md) and [StretchDirection](viewbox_stretchdirection.md) enumerations.

[!code-xaml[ViewBoxXAML](../windows.ui.xaml/code/ViewBoxSnippet/csharp/MainPage.xaml#SnippetViewBoxXAML)]

[!code-csharp[ViewBoxCode](../windows.ui.xaml/code/ViewBoxSnippet/csharp/MainPage.xaml.cs#SnippetViewBoxCode)]

[!code-vb[ViewBoxCode](../windows.ui.xaml/code/ViewBoxSnippet/vbnet/MainPage.xaml.vb#SnippetViewBoxCode)]

## -see-also
[FrameworkElement](../windows.ui.xaml/frameworkelement.md)
