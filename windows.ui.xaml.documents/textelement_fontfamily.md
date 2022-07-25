---
-api-id: P:Windows.UI.Xaml.Documents.TextElement.FontFamily
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Media.FontFamily FontFamily { get;  set; }
-->

# Windows.UI.Xaml.Documents.TextElement.FontFamily

## -description
Gets or sets the preferred top-level font family for the content of the element.



## -xaml-syntax
```xaml
<textElement FontFamily="fontFamily" />
-or-
<textElement FontFamily="fontFamilyName[,fallbackFontFamilyName]" />
-or-
<textElement FontFamily="fontURI#fontFamily" />
```


## -xaml-values
<dl><dt>fontFamily</dt><dd>fontFamilyA single font family name, for example "Verdana".</dd>
<dt>fontFamilyName[,fallbackFontFamilyName]</dt><dd>fontFamilyName[,fallbackFontFamilyName]A primary font family choice, then one or more fallback font family choices, for example "Arial Unicode MS, Arial".</dd>
<dt>fontURI#fontFamily</dt><dd>fontURI#fontFamilyUsed for non-default fonts. Specifies the resource location in the assembly for a font file, and a font family within that font. For information on this usage, see FontFamily.</dd>
</dl>
## -property-value
The preferred font family, or a primary preferred font family with one or more fallback font families. See [FontFamily](../windows.ui.xaml.media/fontfamily.md) for default information.

## -remarks

## -examples

## -see-also
