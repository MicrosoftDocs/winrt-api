---
-api-id: T:Windows.UI.Xaml.Documents.Glyphs
-api-type: winrt class
---

<!-- Class syntax.
public class Glyphs : Windows.UI.Xaml.FrameworkElement, Windows.UI.Xaml.Documents.IGlyphs, Windows.UI.Xaml.Documents.IGlyphs2
-->

# Windows.UI.Xaml.Documents.Glyphs

## -description
Provides a visual representation of letters, characters, or symbols, in a specific font and style.



## -xaml-syntax
```xaml
<Glyphs><Fill>singleBrush</Fill></Glyphs>
```


## -remarks
The Glyphs class provides a light weight text element that you can use to display small amounts of text, such as icons. The Glyphs element can be faster than a [TextBlock](../windows.ui.xaml.controls/textblock.md) in some cases, so you should consider using Glyphs when performance is a concern. However, the Glyphs element doesn't have the same localization and stylistic properties as a [TextBlock](../windows.ui.xaml.controls/textblock.md) control. For example, Glyphs does not support [FontWeight](../windows.ui.xaml.controls/textblock_fontweight.md) or bidirectional text.

The Glyphs element can be used only with a font that is included in the app package as a resource. Only use fonts that you have the rights to ship with your app. Take this into consideration when choosing between [TextBlock](../windows.ui.xaml.controls/textblock.md) and Glyphs.

Starting in Windows 10, the Glyphs control supports the display of color fonts. (See [IsColorFontEnabled](glyphs_iscolorfontenabled.md) and [ColorFontPaletteIndex](glyphs_colorfontpaletteindex.md).)

### Usage

To use the Glyphs control, you must include the font file in your project as a resource with its **Build Action** set to **Content**.



(The examples here use the Segoe UI Emoji Regular font and assume that it's been added to the Assets folder of the project. This font is included by default with Windows 10 systems in the location C:\Windows\Fonts\seguiemj.ttf. To try this code yourself, you can copy the file from there into your project.)

With the font file added to your project, you can add a Glyphs element to display text. You must set 4 properties to make the Glyphs element show in your app.
+ [FontUri](glyphs_fonturi.md): set to the path of the font file that you add to the project.
+ [FontRenderingEmSize](glyphs_fontrenderingemsize.md): specify the Em size at which to render the font.
+ [Indices](glyphs_indices.md): specify the glyphs you want to use from the font.
+ [Fill](glyphs_fill.md): specify the color in which to render glyphs.


Here's how to use a Glyphs element in XAML and in code.

```xaml
<Glyphs FontUri="ms-appx:///Assets/seguiemj.ttf" 
        FontRenderingEmSize="30" 
        Indices="300;301;305;318;500;501;506" 
        Fill="Blue"/>
```

```csharp
// Requires using Windows.UI.Xaml.Documents 
Glyphs glyph = new Glyphs();
glyph.FontUri = new Uri("ms-appx:///Assets/seguiemj.ttf");
glyph.FontRenderingEmSize = 30;
glyph.Indices = "300;301;305;318;500;501;506";
glyph.Fill = new SolidColorBrush(Windows.UI.Colors.Blue);

// Add to the visual tree (assumes stackPanel is defined in XAML page).
stackPanel.Children.Add(glyph);
```

The results look like this.

<img src="images/Glyphs_ColorFont_Enabled.png" alt="Glyphs from a color font" />
Here, the glyphs aren't actually rendered in blue. This is because Segoe UI Emoji is a color font. This means that there is a color palette defined in the font file for each glyph, and this is used to render the font instead of the color you specify. (However, you are still required to specify a [Fill](glyphs_fill.md) color.)

### Color fonts

If a font has more than one color palette defined, you can set the [ColorFontPaletteIndex](glyphs_colorfontpaletteindex.md) property to the index of the color palette you want to use. You might want to use an alternate color palette to better match the colors of your app. If you set the property value to an index that doesn't exist in the font, the font is rendered in the color specified by the [Fill](glyphs_fill.md) property.

For example, the Segoe UI Emoji font has two color palettes defined. Index 0 is the default. If you set the index to 1, you can see the secondary color palette. The color differences in the glyphs below are subtle, but if you look at the color of the umbrella you will notice a difference in both the red top and the gray handle.

<img src="images/Glyphs_ColorPalette.png" alt="A glyph rendered in different color palettes" />
Here, the [ColorFontPaletteIndex](glyphs_colorfontpaletteindex.md) property is set to 1.

```xaml
<Glyphs FontUri="ms-appx:///Assets/seguiemj.ttf" 
        FontRenderingEmSize="30" 
        Indices="301" 
        Fill="Blue" 
        ColorFontPaletteIndex="1"/>
```

If you don’t want the glyphs to be shown as a color font, but instead as monochromatic, you can set the [IsColorFontEnabled](glyphs_iscolorfontenabled.md) property to **false** to turn off the color font functionality. You might do this to improve accessibility and support high contrast settings.

Here, the [IsColorFontEnabled](glyphs_iscolorfontenabled.md) property is set to **false**.

```xaml
<Glyphs FontUri="ms-appx:///Assets/seguiemj.ttf" 
        FontRenderingEmSize="30" 
        Indices="301" 
        Fill="Blue" 
        IsColorFontEnabled="False"/>
```

The rendered glyphs look like this.

<img src="images/Glyphs_ColorFont_Disabled.png" alt="Glyphs from a disabled color font" />

## -examples

## -see-also
[FrameworkElement](../windows.ui.xaml/frameworkelement.md), [TextBlock](../windows.ui.xaml.controls/textblock.md)
