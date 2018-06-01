---
-api-id: T:Windows.Globalization.Language
-api-type: winrt class
---

<!-- Class syntax.
public class Language : Windows.Globalization.ILanguage, Windows.Globalization.ILanguageExtensionSubtags
-->

# Windows.Globalization.Language

## -description

A class that provides information related to [BCP-47](http://go.microsoft.com/fwlink/p/?linkid=227302) language tags such as the language name and the script.

## -remarks

If your app passes language tags used in this class to any [National Language Support](http://msdn.microsoft.com/library/7a548074-0782-45e1-8051-80c3b9d81885) functions, it must first convert the tags by calling [ResolveLocaleName](http://msdn.microsoft.com/library/99264b22-3fb5-47e2-b0b9-42a6768e67c1).

Initialize this class with a [BCP-47](http://go.microsoft.com/fwlink/p/?linkid=227302) language tag. For example, to work with the best current user-preferred language, pass in the top value from [Windows.System.UserProfile.GlobalizationPreferences](../windows.system.userprofile/globalizationpreferences.md):

**Starting in :** Language tags support the Unicode extensions "ca-" and "nu-". (See [Unicode Key/Type Definitions](http://go.microsoft.com/fwlink/p/?LinkId=308919).) Note that these extensions can affect the numeral system or calendar used by globalization objects.

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

[OCR sample (Windows 10)](http://go.microsoft.com/fwlink/p/?LinkId=620579), [Globalization preferences sample (Windows 10)](http://go.microsoft.com/fwlink/p/?LinkId=624045)