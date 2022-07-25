---
-api-id: T:Windows.UI.Xaml.Controls.BitmapIcon
-api-type: winrt class
---

<!-- Class syntax.
public class BitmapIcon : Windows.UI.Xaml.Controls.IconElement, Windows.UI.Xaml.Controls.IBitmapIcon
-->

# Windows.UI.Xaml.Controls.BitmapIcon

## -description
Represents an icon that uses a bitmap as its content.


## -xaml-syntax
```xaml
<BitmapIcon .../>
```


## -remarks

> [!NOTE]
> BitmapIcon is typically used to provide the icon for an AppBarButton, and the remarks in this section assume this usage. However, it can be used anywhere a UIElement can be used. The remarks apply to all usages.

To use a BitmapIcon as the [Icon](appbarbutton_icon.md) for an [AppBarButton](appbarbutton.md), you specify the URI of an image file.

The file that you use should be a solid image on a transparent background. The bitmap image as retrieved from the [UriSource](bitmapicon_urisource.md) location is expected to be a true bitmap that has transparent pixels and non-transparent pixels. The recommended format is PNG. Other file-format image sources will load apparently without error but result in a solid block of the foreground color inside the [AppBarButton](appbarbutton.md). This behavior can be ignored by setting the [ShowAsMonochrome](bitmapicon_showasmonochrome.md) property to false.

All color info is stripped from the bitmap when the BitmapIcon is rendered. The remaining non-transparent colors are combined to produce an image that's entirely the foreground color as set by the [Foreground](iconelement_foreground.md) property (this typically comes from styles or templates, such as the default template resolving to a theme resource). You can override this behavior by setting the [ShowAsMonochrome](bitmapicon_showasmonochrome.md) property.

The value of the [Foreground](iconelement_foreground.md) property must be a [SolidColorBrush](../windows.ui.xaml.media/solidcolorbrush.md). After the Foreground's Color property is read, changes to it are ignored. To change the  color you must change the value of the Foreground property itself to a new SolidColorBrush.

> [!NOTE]
> You can set the **Foreground** property on the [AppBarButton](appbarbutton.md) or on the BitmapIcon. If you set the [Foreground](control_foreground.md) on the [AppBarButton](appbarbutton.md), it's applied only to the default visual state. It's not applied to the other visual states defined in the [AppBarButton](appbarbutton.md) template, like `MouseOver`. If you set the [Foreground](iconelement_foreground.md) on the BitmapIcon, the color is applied to all visual states.

The default font size for an AppBarButton Icon is 20px.

You typically specify a [UriSource](bitmapicon_urisource.md) value that references a bitmap that you've included as part of the app, as a resource or otherwise within the app package. For more info on the **ms-appx:** scheme and other URI schemes that you can use to reference resources in your app, see [Uri schemes](/previous-versions/windows/apps/jj655406(v=win.10)).

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1703 | 15063 | ShowAsMonochrome |

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [Command bar](/windows/apps/design/controls/command-bar).

> [!div class="nextstepaction"]
> [Open the WinUI 2 Gallery app and see the BitmapIcon in action](winui2gallery:/item/AppBarButton)

> The **WinUI 2 Gallery** app includes interactive examples of most WinUI 2 controls, features, and functionality. Get the app from the [Microsoft Store](https://www.microsoft.com/store/productId/9MSVH128X2ZT) or get the source code on [GitHub](https://github.com/Microsoft/WinUI-Gallery/tree/winui2).

This example shows an [AppBarButton](appbarbutton.md) with a BitmapIcon. The [UriSource](bitmapicon_urisource.md) specifies an image that's included in the app package.

```xaml
<AppBarButton Label="BitmapIcon" Click="AppBarButton_Click">
    <AppBarButton.Icon>
        <BitmapIcon UriSource="ms-appx:///Assets/globe.png"/>
    </AppBarButton.Icon>
</AppBarButton>
```


## -see-also
[IconElement](iconelement.md), [AppBarButton](appbarbutton.md), [Icons for UWP apps](/windows/uwp/style/icons)
