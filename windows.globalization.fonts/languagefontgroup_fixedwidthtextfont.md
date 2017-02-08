---
-api-id: P:Windows.Globalization.Fonts.LanguageFontGroup.FixedWidthTextFont
-api-type: winrt property
---

<!-- Property syntax
public Windows.Globalization.Fonts.LanguageFont FixedWidthTextFont { get; }
-->

# Windows.Globalization.Fonts.LanguageFontGroup.FixedWidthTextFont

## -description
Gets a font that is recommended for displaying fixed-width characters.

## -property-value
The recommended [LanguageFont](languagefont.md), or **NULL** if no font recommendation is available.

## -remarks
The [FixedWidthTextFont](languagefontgroup_fixedwidthtextfont.md) property provides a font recommendation for displaying fixed-width characters.

The font recommended for this usage case will always be a "regular" font (regular weight, normal style, normal stretch). Apps might want to apply other weight/style/stretch formatting, as may be appropriate for the app scenario.

A [FixedWidthTextFont](languagefontgroup_fixedwidthtextfont.md) recommendation is available for certain languages and scripts only.

## -examples

## -see-also
