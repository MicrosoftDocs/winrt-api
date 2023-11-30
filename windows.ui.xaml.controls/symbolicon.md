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

The most common way to specify the icon for an app bar button is to use one of the standard glyphs provided by the Segoe MDL2 Assets font, as specified in the [Symbol](symbol.md) enumeration. You can use a SymbolIcon by setting the [Icon](appbarbutton_icon.md) property of an [AppBarButton](appbarbutton.md) directly to a value of the [Symbol](symbol.md) enumeration.

> [!NOTE]
> You can set the **Foreground** property on the [AppBarButton](appbarbutton.md) or on the SymbolIcon. If you set the [Foreground](control_foreground.md) on the [AppBarButton](appbarbutton.md), it's applied only to the default visual state. It's not applied to the other visual states defined in the [AppBarButton](appbarbutton.md) template, like `MouseOver`. If you set the [Foreground](iconelement_foreground.md) on the SymbolIcon, the color is applied to all visual states.

### Notes for previous versions

> **Windows 8.x**
> On Windows 8, the standard glyphs are provided by the Segoe UI Symbol font.

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [Command bar](/windows/uwp/controls-and-patterns/app-bars).
>
> If you have the **WinUI 2 Gallery** app installed, click here to [open the app and see the SymbolIcon in action](winui2gallery:/item/AppBarButton).
> + [Get the WinUI 2 Gallery app (Microsoft Store)](https://www.microsoft.com/store/productId/9MSVH128X2ZT)
> + [Get the source code (GitHub)](https://github.com/Microsoft/WinUI-Gallery)

This example shows two ways to use a SymbolIcon an [AppBarButton](appbarbutton.md). The second button icon has its [Foreground](iconelement_foreground.md) set to "Green".

```xaml

<AppBarButton Icon="Like" Label="Like"/>

<AppBarButton Label="Accept">
    <AppBarButton.Icon>
        <SymbolIcon Symbol="Accept" Foreground="Green"/>
    </AppBarButton.Icon>
</AppBarButton>
```

## -see-also
[IconElement](iconelement.md), [Symbol enumeration](symbol.md), [Quickstart: Adding app bar buttons](/previous-versions/windows/apps/jj662743(v=win.10)), [AppBarButton](appbarbutton.md), [AppBarToggleButton](appbartogglebutton.md), [BitmapIcon](bitmapicon.md), [FontIcon](fonticon.md), [PathIcon](pathicon.md), [Controls list](/windows/uwp/design/controls-and-patterns/), [Controls by function](/windows/uwp/controls-and-patterns/controls-by-function)
