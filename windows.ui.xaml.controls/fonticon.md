---
-api-id: T:Windows.UI.Xaml.Controls.FontIcon
-api-type: winrt class
---

<!-- Class syntax.
public class FontIcon : Windows.UI.Xaml.Controls.IconElement, Windows.UI.Xaml.Controls.IFontIcon, Windows.UI.Xaml.Controls.IFontIcon2, Windows.UI.Xaml.Controls.IFontIcon3
-->

# Windows.UI.Xaml.Controls.FontIcon

## -description
Represents an icon that uses a glyph from the specified font.

## -xaml-syntax
```xaml
<FontIcon .../>
```


## -remarks
Use [FontIcon](fonticon.md) to specify an [AppBarButton](appbarbutton.md) icon using a font glyph that's not included in the [Symbol](symbol.md) enumeration. You must specify the [FontFamily](fonticon_fontfamily.md) and the [Glyph](fonticon_glyph.md) value.

You can set the [MirroredWhenRightToLeft](fonticon_mirroredwhenrighttoleft.md) property to have the glyph appear mirrored when the [FlowDirection](../windows.ui.xaml/frameworkelement_flowdirection.md) is [RightToLeft](../windows.ui.xaml/flowdirection.md). You typically use this property when a [FontIcon](fonticon.md) is used to display an icon as part of a control template and the icon needs to be mirrored along with the rest of the control.

> [!NOTE]
> You can set the **Foreground** property on the [AppBarButton](appbarbutton.md) or on the [FontIcon](fonticon.md). If you set the [Foreground](control_foreground.md) on the [AppBarButton](appbarbutton.md), it's applied only to the default visual state. It's not applied to the other visual states defined in the [AppBarButton](appbarbutton.md) template, like `MouseOver`. If you set the [Foreground](iconelement_foreground.md) on the [FontIcon](fonticon.md), the color is applied to all visual states.

## -examples
This example shows an [AppBarToggleButton](appbartogglebutton.md) with a [FontIcon](fonticon.md).

```xaml
<AppBarToggleButton Label="FontIcon" Click="AppBarButton_Click">
    <AppBarToggleButton.Icon>
        <FontIcon FontFamily="Candara" Glyph="&#x03A3;"/>
    </AppBarToggleButton.Icon>
</AppBarToggleButton>
```



## -see-also
[IconElement](iconelement.md), [AppBarButton](appbarbutton.md), [AppBarToggleButton](appbartogglebutton.md), [BitmapIcon](bitmapicon.md), [PathIcon](pathicon.md), [SymbolIcon](symbolicon.md), [Controls list](http://msdn.microsoft.com/library/11172840-a63d-4f48-9db4-7baca06308ee), [Controls by function](http://msdn.microsoft.com/library/8db4347b-91d6-4659-91f2-80ecf7bbb596)