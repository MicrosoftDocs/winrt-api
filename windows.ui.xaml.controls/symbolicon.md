---
-api-id: T:Windows.UI.Xaml.Controls.SymbolIcon
-api-type: winrt class
---

<!-- Class syntax.
public class SymbolIcon : Windows.UI.Xaml.Controls.IconElement, Windows.UI.Xaml.Controls.ISymbolIcon
-->

# Windows.UI.Xaml.Controls.SymbolIcon

## -description
Represents an icon that uses a glyph from the Segoe MDL2 Assets font as its content.

## -xaml-syntax
```xaml
<SymbolIcon .../>
```


## -remarks
The most common way to specify the icon for an app bar button is to use one of the standard glyphs provided by the Segoe MDL2 Assets font, as specified in the [Symbol](symbol.md) enumeration. You can use a [SymbolIcon](symbolicon.md) by setting the [Icon](appbarbutton_icon.md) property of an [AppBarButton](appbarbutton.md) directly to a value of the [Symbol](symbol.md) enumeration.

> [!NOTE]
> You can set the **Foreground** property on the [AppBarButton](appbarbutton.md) or on the [SymbolIcon](symbolicon.md). If you set the [Foreground](control_foreground.md) on the [AppBarButton](appbarbutton.md), it's applied only to the default visual state. It's not applied to the other visual states defined in the [AppBarButton](appbarbutton.md) template, like `MouseOver`. If you set the [Foreground](iconelement_foreground.md) on the [SymbolIcon](symbolicon.md), the color is applied to all visual states.

> **Windows 8/8.1**
> On Windows 8, the standard glyphs are provided by the Segoe UI Symbol font.

## -examples
This example shows two ways to use a [SymbolIcon](symbolicon.md) an [AppBarButton](appbarbutton.md). The second button icon has its [Foreground](iconelement_foreground.md) set to "Green".

```xaml

<AppBarButton Icon="Like" Label="Like"/>

<AppBarButton Label="Accept">
    <AppBarButton.Icon>
        <SymbolIcon Symbol="Accept" Foreground="Green"/>
    </AppBarButton.Icon>
</AppBarButton>
```



## -see-also
[IconElement](iconelement.md), [Symbol enumeration](symbol.md), [Quickstart: Adding app bar buttons](https://msdn.microsoft.com/library/743b852c-f4fe-4b4f-814e-77155ccfdefe), [AppBarButton](appbarbutton.md), [AppBarToggleButton](appbartogglebutton.md), [BitmapIcon](bitmapicon.md), [FontIcon](fonticon.md), [PathIcon](pathicon.md), [Controls list](https://msdn.microsoft.com/library/11172840-a63d-4f48-9db4-7baca06308ee), [Controls by function](https://msdn.microsoft.com/library/8db4347b-91d6-4659-91f2-80ecf7bbb596)
