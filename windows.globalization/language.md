---
-api-id: T:Windows.Globalization.Language
-api-type: winrt class
---

<!-- Class syntax.
public class Language : Windows.Globalization.ILanguage, Windows.Globalization.ILanguageExtensionSubtags
-->

# Windows.Globalization.Language

## -description

A class that provides information related to [BCP-47](https://tools.ietf.org/html/bcp47) language tags such as the language name and the script.

## -remarks

If your app passes language tags used in this class to any [National Language Support](/windows/desktop/Intl/national-language-support) functions, it must first convert the tags by calling [ResolveLocaleName](/windows/desktop/api/winnls/nf-winnls-resolvelocalename).

Initialize this class with a [BCP-47](https://tools.ietf.org/html/bcp47) language tag. For example, to work with the best current user-preferred language, pass in the top value from [Windows.System.UserProfile.GlobalizationPreferences](../windows.system.userprofile/globalizationpreferences.md):

Language tags support the Unicode extensions "ca-" and "nu-". (See [Unicode Key/Type Definitions](https://www.unicode.org/reports/tr35/#Key_Type_Definitions).) Note that these extensions can affect the calendar used by Calendar objects.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1803 | 17134 | LayoutDirection |
| 2004 | 19041 | AbbreviatedName |
| 2004 | 19041 | GetMuiCompatibleLanguageListFromLanguageTags |

## -examples

```csharp
// Get the top user-preferred language and its display name.
var topUserLanguage = Windows.System.UserProfile.GlobalizationPreferences.Languages[0];
var language = new Windows.Globalization.Language(topUserLanguage);
var displayName = language.DisplayName;
```

## -see-also

[OCR sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/OCR), [Globalization preferences sample (Windows 10)](https://go.microsoft.com/fwlink/p/?LinkId=624045)
