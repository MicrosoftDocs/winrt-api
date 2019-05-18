---
-api-id: P:Windows.Globalization.Fonts.LanguageFontGroup.DocumentAlternate2Font
-api-type: winrt property
---

<!-- Property syntax
public Windows.Globalization.Fonts.LanguageFont DocumentAlternate2Font { get; }
-->

# Windows.Globalization.Fonts.LanguageFontGroup.DocumentAlternate2Font

## -description
Gets a font that is recommended as an additional option for use in documents beyond the recommendations provided by [DocumentHeadingFont](languagefontgroup_documentheadingfont.md), [ModernDocumentFont](languagefontgroup_moderndocumentfont.md) and [TraditionalDocumentFont](languagefontgroup_traditionaldocumentfont.md).

## -property-value
The recommended [LanguageFont](languagefont.md), or **NULL** if no font recommendation is available.

## -remarks
The DocumentAlternate2Font property provides a font recommendation as an additional option for use in documents beyond the recommendations provided by [DocumentHeadingFont](languagefontgroup_documentheadingfont.md), [ModernDocumentFont](languagefontgroup_moderndocumentfont.md) and [TraditionalDocumentFont](languagefontgroup_traditionaldocumentfont.md). These fonts could be used in body text or other text elements. The app scenario for which this is most likely to be useful is in populating a font-picker list in an authoring tool with a set of fonts designed for a particular language or script.

The font recommended for this usage case will always be a "regular" font (regular weight, normal style, normal stretch). Apps might want to apply other weight/style/stretch formatting, as may be appropriate for the app scenario.

A DocumentAlternate2Font recommendation is available for certain languages and scripts only.

## -examples

## -see-also
