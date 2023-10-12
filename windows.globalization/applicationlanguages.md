---
-api-id: T:Windows.Globalization.ApplicationLanguages
-api-type: winrt class
---

<!-- Class syntax.
public class ApplicationLanguages 
-->

# Windows.Globalization.ApplicationLanguages

## -description
Specifies the language-related preferences that the app can use and maintain.

## -remarks
The languages referenced in this class are represented by [BCP-47 language tags](https://tools.ietf.org/html/bcp47). Each of these is a language identifier and not a locale name, although the two structurally can be the same. As a language tag, "en-US" means American English (or the dialect of English spoken in the United States). It makes no claims about the actual location of the speakers (though many of them do reside in the US) and no other claims about conventions that are used in the US such as the measurement system or currency.

Example:

```javascript
Windows.Globalization.ApplicationLanguages.PrimaryLanguageOverride = "en-US"
```

> [!NOTE]
> If your app passes language tags from this class to any [National Language Support](/windows/desktop/Intl/national-language-support) functions, it must first convert the tags by calling [ResolveLocaleName](/windows/desktop/api/winnls/nf-winnls-resolvelocalename).

Language tags support the Unicode extensions "ca-" and "nu-". (See [Unicode Key/Type Definitions](https://www.unicode.org/reports/tr35/#Key_Type_Definitions).) Note that these extensions can affect the numeral system or calendar used by globalization objects.

UWP apps can be deployed using resource packages. When language resource packages are used, the packages that are installed and registered for a given user are determined by the languages in the user's language profile. As a result, not all of the languages included in the app bundle that was submitted to the Microsoft Store will necessarily be available for use at runtime. The [PrimaryLanguageOverride](applicationlanguages_primarylanguageoverride.md) property should only be set to languages that are available for the user.

The languages available for the app to use as an ApplicationLanguages object at runtime are limited to those languages included in the main app package manifest and the languages corresponding to language resource packages that are applicable for the user (determined by matching languages in the user's preferences), and that are installed and registered for the user. The [ApplicationLanguages.ManifestLanguages](applicationlanguages_manifestlanguages.md) property reflects language resource packages that are available for the user, and returns an appropriate set of languages that can be used for setting the [PrimaryLanguageOverride](applicationlanguages_primarylanguageoverride.md) property.

The [ApplicationLanguages.Languages](applicationlanguages_languages.md) property will return a very similar list to the [ManifestLanguages](applicationlanguages_manifestlanguages.md) property. It may differ in including regional language variations not listed in any package manifest; for example, "en-CA" (English (Canada)) can be returned by the [Languages](applicationlanguages_languages.md) property if the user has "en-CA" in their profile and the app supports any regional variety of English. Such user-derived regional language variations can be preferable for setting the [PrimaryLanguageOverride](applicationlanguages_primarylanguageoverride.md) property since the app will then provide globalization behaviors more appropriate for the user.

If a language is in the main app package but is not a match for any language in the user's preference, it is returned by the [ManifestLanguages](applicationlanguages_manifestlanguages.md) property but not the [Languages](applicationlanguages_languages.md) property. These can also be used for setting the [PrimaryLanguageOverride](applicationlanguages_primarylanguageoverride.md) property. However, since these languages are not reflected in the user's preferences, the user might not understand those languages. Such settings should be used only when chosen directly by the user.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1803 | 17134 | GetLanguagesForUser |

## -examples

## -see-also

[BCP-47 language tags](https://tools.ietf.org/html/bcp47), [Unicode Key/Type Definitions](https://www.unicode.org/reports/tr35/#Key_Type_Definitions)
