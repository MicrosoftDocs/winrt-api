---
-api-id: P:Windows.UI.Xaml.Controls.IconElement.Foreground
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Media.Brush Foreground { get;  set; }
-->

# Windows.UI.Xaml.Controls.IconElement.Foreground

## -description
Gets or sets a brush that describes the foreground color.



## -xaml-syntax
```xaml
<icon Foreground="{StaticResource resourceName}"/>
- or -
<icon Foreground="colorString"/>

```


## -xaml-values
<dl><dt>resourceName</dt><dd>resourceNameThe resource name (x:Key attribute value) of an existing XAML resource that defines a brush. This is the recommended way to specify Brush values in XAML if you have any intention of using the same colors or brushes in more than one part of your UI. See Remarks in Brush or ResourceDictionary and XAML resource references.</dd>
<dt>colorString</dt><dd>colorStringThe Color for a SolidColorBrush expressed as an attribute string. This can be a named color, an RGB value, or an ScRGB value. RGB or ScRGB may also specify alpha information. See the XAML Values section in Color.</dd>
</dl>
## -property-value
The brush that paints the foreground of the control. The default is **null**, (a null brush) which is evaluated as [Transparent](../windows.ui/colors_transparent.md) for rendering. However, this value is typically set by a default system resource at runtime, which is tied to the active theme and other settings.

## -remarks
You can set the **Foreground** property on the [AppBarButton](appbarbutton.md) or on an [IconElement](iconelement.md) derived icon. If you set the [Foreground](control_foreground.md) on the [AppBarButton](appbarbutton.md), it's applied only to the default visual state. It's not applied to the other visual states defined in the [AppBarButton](appbarbutton.md) template, like `MouseOver`. If you set the Foreground on the [IconElement](iconelement.md) derived icon, the color is applied to all visual states.

The only valid [Brush](../windows.ui.xaml.media/brush.md) type for the Foreground value is [SolidColorBrush](../windows.ui.xaml.media/solidcolorbrush.md). If you attempt to use a brush that's not declaring a solid color, the value is ignored at run time and replaced with a [SolidColorBrush](../windows.ui.xaml.media/solidcolorbrush.md) that is white or black, depending on the current theme.

Foreground replaces the color information from a [BitmapIcon.UriSource](bitmapicon_urisource.md) source file. Any non-transparent pixel in the source image is replaced with the Foreground color.

## -examples
This example shows an [AppBarButton](appbarbutton.md) that uses a [SymbolIcon](symbolicon.md) with its Foreground set to "Green".

```xaml
<AppBarButton Label="Accept">
    <AppBarButton.Icon>
        <SymbolIcon Symbol="Accept" Foreground="Green"/>
    </AppBarButton.Icon>
</AppBarButton>
```



## -see-also
[BitmapIcon.UriSource](bitmapicon_urisource.md), [SymbolIcon](symbolicon.md), [Adding app bars](/previous-versions/windows/apps/hh781230(v=win.10)), [Use brushes](/windows/uwp/graphics/using-brushes)
