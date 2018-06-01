---
-api-id: T:Windows.Globalization.Fonts.LanguageFontGroup
-api-type: winrt class
---

<!-- Class syntax.
public class LanguageFontGroup : Windows.Globalization.Fonts.ILanguageFontGroup
-->

# Windows.Globalization.Fonts.LanguageFontGroup

## -description

Supplies a set of font recommendations for a given language or script for various usage cases.

## -remarks

A [LanguageFontGroup](languagefontgroup.md) provides a set of font recommendations for a particular language or script. The different fonts recommended by a given [LanguageFontGroup](languagefontgroup.md), exposed as separate [LanguageFontGroup](languagefontgroup.md) properties, correspond to different usage cases.

Each [LanguageFontGroup](languagefontgroup.md) property returns a [LanguageFont](languagefont.md) object, which provides the details for that particular font recommendation. Those details include a font family as well as font weight, style and stretch attributes.

The weight/style/stretch attributes are significant for some usage cases but not others. For instance, the font recommendations for the various UI usage categories may use fonts from the same font family but differ in weight (for example, Segoe UI Semilight for [UITextFont](languagefontgroup_uitextfont.md), but Segoe UI Regular for [UICaptionFont](languagefontgroup_uicaptionfont.md)). But for some usage cases, the weight/style/stretch attributes might always indicate a "regular" font (regular weight, normal style, normal stretch). In those cases, apps might want to apply other weight/style/stretch formatting as may be appropriate for the app scenario. See the remarks for each [LanguageFontGroup](languagefontgroup.md) property for additional information.

For some languages and scripts, the [LanguageFontGroup](languagefontgroup.md) may not provide a font recommendation for every usage case. For instance, fixed-width fonts are not provided in Windows for every script. See the remarks for each [LanguageFontGroup](languagefontgroup.md) property for additional information.

> [!NOTE]
> If your app passes language tags used in this class to any [National Language Support](http://msdn.microsoft.com/library/7a548074-0782-45e1-8051-80c3b9d81885) functions, it must first convert the tags by calling [ResolveLocaleName](http://msdn.microsoft.com/library/99264b22-3fb5-47e2-b0b9-42a6768e67c1).

**Beginning in :** The [LanguageFontGroup](languagefontgroup.md) class returns font group data to match the target operating system for which an app was developed. Therefore, if you update your Windows 8 app to Windows 8.1, the fonts used in your app may change, and you may need to make adjustments to your UI layout.

## -examples

```javascript
// Get the recommended Japanese fonts for traditional documents and modern documents.
var fonts = new Windows.Globalization.Fonts.LanguageFontGroup('ja-JP');
var traditionalDocumentFont = fonts.traditionalDocumentFont;
var modernDocumentFont = fonts.modernDocumentFont;

// Obtain two properties of the traditional document font.
var traditionalDocumentFontFontFamily = traditionalDocumentFont.fontFamily;   // "MS Mincho"
var traditionalDocumentFontScaleFactor = traditionalDocumentFont.scaleFactor; // 100

// Obtain two properties of the modern document font.
var modernDocumentFontFontFamily = modernDocumentFont.fontFamily;             // "Meiryo"
var modernDocumentFontScaleFactor = modernDocumentFont.scaleFactor;           // 90
```

```csharp
// Get the recommended Japanese fonts for traditional documents and modern documents.
var fonts = new Windows.Globalization.Fonts.LanguageFontGroup("ja-JP");
var traditionalDocumentFont = fonts.TraditionalDocumentFont;
var modernDocumentFont = fonts.ModernDocumentFont;

// Obtain two properties of the traditional document font.
var traditionalDocumentFontFontFamily = traditionalDocumentFont.FontFamily;   // "MS Mincho"
var traditionalDocumentFontScaleFactor = traditionalDocumentFont.ScaleFactor; // 100

// Obtain two properties of the modern document font.
var modernDocumentFontFontFamily = modernDocumentFont.FontFamily;             // "Meiryo"
var modernDocumentFontScaleFactor = modernDocumentFont.ScaleFactor;           // 90
```

## -see-also

[Language font mapping sample](http://go.microsoft.com/fwlink/p/?linkid=231603), [Language font mapping sample (Windows 10)](http://go.microsoft.com/fwlink/p/?LinkId=620559)