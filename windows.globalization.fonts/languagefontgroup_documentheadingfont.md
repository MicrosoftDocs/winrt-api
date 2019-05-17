---
-api-id: P:Windows.Globalization.Fonts.LanguageFontGroup.DocumentHeadingFont
-api-type: winrt property
---

<!-- Property syntax
public Windows.Globalization.Fonts.LanguageFont DocumentHeadingFont { get; }
-->

# Windows.Globalization.Fonts.LanguageFontGroup.DocumentHeadingFont

## -description
Gets a font that is recommended for use in document headings.

## -property-value
The recommended [LanguageFont](languagefont.md).

## -remarks
The DocumentHeadingFont property provides a font recommendation for document text elements such as headings. These fonts could also be used in body text, but use for long runs of body text is not generally recommended. The recommended font may be a display face that is significantly different from the [ModernDocumentFont](languagefontgroup_moderndocumentfont.md) and [TraditionalDocumentFont](languagefontgroup_traditionaldocumentfont.md) recommendations.

The font recommended for this usage case will always be a "regular" font (regular weight, normal style, normal stretch). Apps might want to apply other weight/style/stretch formatting, as may be appropriate for the app scenario.

A DocumentHeadingFont recommendation is available for every supported language or script.

## -examples

## -see-also
