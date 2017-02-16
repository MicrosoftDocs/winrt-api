---
-api-id: M:Windows.Globalization.Fonts.LanguageFontGroup.#ctor(System.String)
-api-type: winrt method
---

<!-- Method syntax
public LanguageFontGroup(System.String languageTag)
-->

# Windows.Globalization.Fonts.LanguageFontGroup.LanguageFontGroup

## -description
Creates a [LanguageFontGroup](languagefontgroup.md) object for a given language or script.

## -parameters
### -param languageTag
A [BCP-47](http://go.microsoft.com/fwlink/p/?linkid=227302) language tag, or an [ISO 15924](http://www.unicode.org/iso15924/) script identifier.

## -remarks
The *languageTag* parameter can be any valid [BCP-47](http://go.microsoft.com/fwlink/p/?linkid=227302) language tag, such as "en", "de-CH", or "zh-Hans". The only limitations are that the language tag must include an explicit script subtag or be for a language for which the script is implicitly known. (For instance, "en" is assumed to imply Latin script.) Moreover, the script must be one that Windows supports.

The *languageTag* parameter can also be a valid ISO 15924 script identifier, such as "Latn", "Cyrl", or "Deva". The only limitation is that the script must be one that Windows supports.

> [!NOTE]
> If your app passes language tags used in this class to any [National Language Support](http://msdn.microsoft.com/library/7a548074-0782-45e1-8051-80c3b9d81885) functions, it must first convert the tags by calling [ResolveLocaleName](http://msdn.microsoft.com/library/99264b22-3fb5-47e2-b0b9-42a6768e67c1).

## -examples

## -see-also
[BCP-47 language tags](http://go.microsoft.com/fwlink/p/?linkid=227302)