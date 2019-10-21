---
-api-id: P:Windows.Globalization.Fonts.LanguageFontGroup.UICaptionFont
-api-type: winrt property
---

<!-- Property syntax
public Windows.Globalization.Fonts.LanguageFont UICaptionFont { get; }
-->

# Windows.Globalization.Fonts.LanguageFontGroup.UICaptionFont

## -description
Gets a font that is recommended for special UI elements, such as captions, that are displayed at sizes smaller than typical UI body text.

## -property-value
The recommended [LanguageFont](languagefont.md).

## -remarks
The UICaptionFont property provides a font recommendation for special UI elements, such as captions, that are displayed at sizes smaller than typical UI body text.

The font recommended for this usage case may be differentiated from other UI usage cases in font weight, style or stretch values. Those attributes are significant aspects of the font recommendation being provided.

A UICaptionFont recommendation is available for every supported language or script.

## -examples

## -see-also
[Guidelines and checklist for text and typography](https://docs.microsoft.com/windows/uwp/controls-and-patterns/fonts), [Understanding the Windows 8 silhouette](https://docs.microsoft.com/previous-versions/windows/apps/hh872191(v=win.10))
