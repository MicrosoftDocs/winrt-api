---
-api-id: T:Windows.Globalization.Fonts.LanguageFont
-api-type: winrt class
---

<!-- Class syntax.
public class LanguageFont : Windows.Globalization.Fonts.ILanguageFont
-->

# Windows.Globalization.Fonts.LanguageFont

## -description
Provides data related to a particular font recommendation for a given language.

## -remarks
A [LanguageFont](languagefont.md) object provides data giving a font recommendation for a particular language and for particular usage cases. [LanguageFont](languagefont.md) objects are obtained from a [LanguageFontGroup](languagefontgroup.md) object, which is constructed for a particular language or script. Each [LanguageFontGroup](languagefontgroup.md) object provides different [LanguageFont](languagefont.md) objects for different usage cases.

Depending on the usage case, font weight/style/stretch attributes provided in the [LanguageFont](languagefont.md) may or may not be significant: for some usage cases, a "regular" font (regular weight, normal style, normal stretch) may always be returned. Applications may want to apply other weight/style/stretch formatting in those cases. See the remarks on the different usage cases for [LanguageFontGroup](languagefontgroup.md).

The [ScaleFactor](languagefont_scalefactor.md) property provides a multiplier that can be applied to a nominal font size. See the [ScaleFactor](languagefont_scalefactor.md) property topic for additional information.

The fonts referenced by a [LanguageFont](languagefont.md) are always fonts that ship as part of Windows. There is no way for an end user or developer to customize these values. It is safe to assume that the font will be present on every Windows 8 system.

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
[Language font mapping sample](https://go.microsoft.com/fwlink/p/?linkid=231603)
