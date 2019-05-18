---
-api-id: P:Windows.Globalization.Fonts.LanguageFont.ScaleFactor
-api-type: winrt property
---

<!-- Property syntax
public double ScaleFactor { get; }
-->

# Windows.Globalization.Fonts.LanguageFont.ScaleFactor

## -description
Gets a recommended font size scaling factor for the font.

The factor can be used to adjust relative sizes when two or more fonts are used for different runs within the same text element.

## -property-value
The recommended font size scaling factor.

## -remarks
The ScaleFactor property provides a multiplier that can be applied to a nominal font size. Scale factors are intended to be used within a single [LanguageFontGroup](languagefontgroup.md) usage case so that text in different languages and scripts (that is, using different recommended fonts) will appear at complementary sizes. Scale factors within a single [LanguageFontGroup](languagefontgroup.md) usage case may be compared, but it is not appropriate to compare scale factors between different [LanguageFontGroup](languagefontgroup.md) usage cases.

For example, suppose a user interface heading element is nominally set at 36 pt. Suppose further that instances of that element are displayed side-by-side in Korean and English. An application can construct [LanguageFontGroup](languagefontgroup.md) objects for Korean and for English, and then obtain the [UIHeadingFont](languagefontgroup_uiheadingfont.md) [LanguageFont ](languagefont.md) for each language. The [LanguageFont](languagefont.md) for English might have a scale factor of 1.0, while the [LanguageFont](languagefont.md) for Korean might have a scale factor of 0.96. If the English text is set at 36 pt and the Korean text is set at 34.56 pt (= 36 × 0.96), then the two text elements will appear better side-by-side than if both had been displayed at 36 pt.

For most [LanguageFontGroup](languagefontgroup.md) usage cases, the scale factor is chosen to make the size and weight of the different fonts more compatible with one another. For the [FixedWidthTextFont](languagefontgroup_fixedwidthtextfont.md) usage case, however, the scale factor is chosen to make the widths of characters in different fixed-width fonts more compatible with one another.

## -examples

## -see-also
