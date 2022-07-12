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

Use FontIcon to specify an icon using a [Glyph](fonticon_glyph.md) value from a [FontFamily](fonticon_fontfamily.md). You must have the font available for the glyphs to show. Glyph values are assigned by font developers to private Unicode values that don’t map to existing code points. Windows 10 uses the **Segoe MDL2 Assets** FontFamily, and the glyphs are included in the [Symbol](symbol.md) enumeration. 

You can set the [MirroredWhenRightToLeft](fonticon_mirroredwhenrighttoleft.md) property to have the glyph appear mirrored when the [FlowDirection](../windows.ui.xaml/frameworkelement_flowdirection.md) is [RightToLeft](../windows.ui.xaml/flowdirection.md). You typically use this property when a FontIcon is used to display an icon as part of a control template and the icon needs to be mirrored along with the rest of the control.

> [!NOTE]
> You can set the **Foreground** property on the [AppBarButton](appbarbutton.md) or on the FontIcon. If you set the [Foreground](control_foreground.md) on the [AppBarButton](appbarbutton.md), it's applied only to the default visual state. It's not applied to the other visual states defined in the [AppBarButton](appbarbutton.md) template, like `MouseOver`. If you set the [Foreground](iconelement_foreground.md) on the FontIcon, the color is applied to all visual states.

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [Command bar](/windows/apps/design/controls/command-bar).

> [!div class="nextstepaction"]
> [Open the WinUI 2 Gallery app and see the FontIcon in action](winui2gallery:/item/AppBarButton)

> The **WinUI 2 Gallery** app includes interactive examples of most WinUI 2 controls, features, and functionality. Get the app from the [Microsoft Store](https://www.microsoft.com/store/productId/9MSVH128X2ZT) or get the source code on [GitHub](https://github.com/Microsoft/WinUI-Gallery/tree/winui2).

This example shows an [AppBarToggleButton](appbartogglebutton.md) with a FontIcon.

```xaml
<AppBarToggleButton Label="FontIcon" Click="AppBarButton_Click">
    <AppBarToggleButton.Icon>
        <FontIcon FontFamily="Segoe MDL2 Assets" Glyph="&#xE790;"/>
    </AppBarToggleButton.Icon>
</AppBarToggleButton>
```

```csharp
var newAppBarButton = new AppBarButton();
var fontIcon = new FontIcon();
fontIcon.FontFamily = new FontFamily("Segoe MDL2 Assets");
fontIcon.Glyph = "\xE790";
newAppBarButton.Icon = fontIcon;
```

```cppwinrt
using namespace winrt::Windows::UI::Xaml;
...

auto newAppBarButton = Controls::AppBarButton{};
auto fontIcon = Controls::FontIcon{};
fontIcon.FontFamily(Media::FontFamily{ L"Segoe MDL2 Assets" });
fontIcon.Glyph(L"\xE790");
newAppBarButton.Icon(fontIcon);
```


## -see-also
[IconElement](iconelement.md), [AppBarButton](appbarbutton.md), [Icons for UWP apps](/windows/uwp/style/icons)
