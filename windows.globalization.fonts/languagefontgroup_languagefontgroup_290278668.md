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
A [BCP-47](https://tools.ietf.org/html/bcp47) language tag, or an [ISO 15924](https://www.unicode.org/iso15924/) script identifier.

## -remarks
The *languageTag* parameter can be any valid [BCP-47](https://tools.ietf.org/html/bcp47) language tag, such as "en", "de-CH", or "zh-Hans". The only limitations are that the language tag must include an explicit script subtag or be for a language for which the script is implicitly known. (For instance, "en" is assumed to imply Latin script.) Moreover, the script must be one that Windows supports.

The *languageTag* parameter can also be a valid ISO 15924 script identifier, such as "Latn", "Cyrl", or "Deva". The only limitation is that the script must be one that Windows supports.

> [!NOTE]
> If your app passes language tags used in this class to any [National Language Support](/windows/desktop/Intl/national-language-support) functions, it must first convert the tags by calling [ResolveLocaleName](/windows/desktop/api/winnls/nf-winnls-resolvelocalename).

## -examples

## -see-also
[BCP-47 language tags](https://tools.ietf.org/html/bcp47)
