---
-api-id: P:Windows.UI.Xaml.Controls.TextBlock.FontFamily
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Media.FontFamily FontFamily { get;  set; }
-->

# Windows.UI.Xaml.Controls.TextBlock.FontFamily

## -description
Gets or sets the preferred top-level font family for the text content in this element.



## -xaml-syntax
```xaml
<TextBlock FontFamily="fontFamily" />
-or-
<TextBlock FontFamily="fontFamilyName[,fallbackFontFamilyName]" />
-or-
<TextBlock FontFamily="fontURI#fontFamily" />
```


## -xaml-values
<dl><dt>fontFamily</dt><dd>fontFamilyA single font family name, for example "Verdana".</dd>
<dt>fontFamilyName[,fallbackFontFamilyName]</dt><dd>fontFamilyName[,fallbackFontFamilyName]A primary font family choice then one or more fallback font family choices, for example "Arial Unicode MS, Arial".</dd>
<dt>fontURI#fontFamily</dt><dd>fontURI#fontFamilyUsed for non-default fonts. Specifies the resource location in the assembly for a font file, and a font family within that font. For information on this usage, see FontFamily.</dd>
</dl>
## -property-value
A [FontFamily](../windows.ui.xaml.media/fontfamily.md) object that specifies the preferred font family, or a primary preferred font family with one or more fallback font families. For information about defaults, see the [FontFamily](../windows.ui.xaml.media/fontfamily.md) class topic.

## -remarks

## -examples

## -see-also
