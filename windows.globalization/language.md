---
-api-id: T:Windows.Globalization.Language
-api-type: winrt class
---

<!-- Class syntax.
public class Language : Windows.Globalization.ILanguage, Windows.Globalization.ILanguageExtensionSubtags
-->

# Windows.Globalization.Language

## -description

A class that provides information related to [BCP-47](https://go.microsoft.com/fwlink/p/?linkid=227302) language tags such as the language name and the script.

## -remarks

If your app passes language tags used in this class to any [National Language Support](https://docs.microsoft.com/windows/desktop/Intl/national-language-support) functions, it must first convert the tags by calling [ResolveLocaleName](https://docs.microsoft.com/windows/desktop/api/winnls/nf-winnls-resolvelocalename).

Initialize this class with a [BCP-47](https://go.microsoft.com/fwlink/p/?linkid=227302) language tag. For example, to work with the best current user-preferred language, pass in the top value from [Windows.System.UserProfile.GlobalizationPreferences](../windows.system.userprofile/globalizationpreferences.md):

**Starting in :** Language tags support the Unicode extensions "ca-" and "nu-". (See [Unicode Key/Type Definitions](https://go.microsoft.com/fwlink/p/?LinkId=308919).) Note that these extensions can affect the numeral system or calendar used by globalization objects.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1803 | 17134 | LayoutDirection |

## -examples

```javascript
// Get the top user-preferred language and its display name.
var topUserLanguage = Windows.System.UserProfile.GlobalizationPreferences.languages[0];
var language = new Windows.Globalization.Language(topUserLanguage);
var displayName = language.displayName;
```

```csharp
// Get the top user-preferred language and its display name.
var topUserLanguage = Windows.System.UserProfile.GlobalizationPreferences.Languages[0];
var language = new Windows.Globalization.Language(topUserLanguage);
var displayName = language.DisplayName;
```

## -see-also

[OCR sample (Windows 10)](https://go.microsoft.com/fwlink/p/?LinkId=620579), [Globalization preferences sample (Windows 10)](https://go.microsoft.com/fwlink/p/?LinkId=624045)
