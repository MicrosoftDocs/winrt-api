---
-api-id: P:Windows.Globalization.Fonts.LanguageFontGroup.UINotificationHeadingFont
-api-type: winrt property
---

<!-- Property syntax
public Windows.Globalization.Fonts.LanguageFont UINotificationHeadingFont { get; }
-->

# Windows.Globalization.Fonts.LanguageFontGroup.UINotificationHeadingFont

## -description
Gets a font that is recommended for special UI elements, such as headings in notifications or other app messages, that are displayed at UI  body text size or only slightly larger yet need to be differentiated from UI body text.

## -property-value
The recommended [LanguageFont](languagefont.md).

## -remarks
The UINotificationHeadingFont property provides a font recommendation for special UI elements, such as headings in notifications or other app messages, that are displayed at UI body text size or only slightly larger yet need to be differentiated from UI body text.

The font recommended for this usage case may be differentiated from other UI usage cases in font weight, style or stretch values. Those attributes are significant aspects of the font recommendation being provided.

A UINotificationHeadingFont recommendation is available for every supported language or script.

## -examples

## -see-also
[Typography in Windows Apps](/windows/apps/design/style/typography)
