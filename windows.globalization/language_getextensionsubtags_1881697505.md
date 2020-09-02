---
-api-id: M:Windows.Globalization.Language.GetExtensionSubtags(System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.Collections.IVectorView<string> GetExtensionSubtags(System.String singleton)
-->

# Windows.Globalization.Language.GetExtensionSubtags

## -description
Retrieves a vector of extension subtags in the current language for the given extension identified by singleton.

## -parameters
### -param singleton
A single-character subtag for the [LanguageTag](language_languagetag.md) of the current language. See [BCP-47 language tags, Extensions and the Extensions Registry](https://tools.ietf.org/html/bcp47#section-3.7).

## -returns
The list of extension subtags identified by *singleton*.

## -remarks
If *singleton* does not exist for the current language, the returned vector is empty.

If *singleton* is a known system (such as "u", the Unicode extension), the returned subtags may be combined into logical units. For example, "de-DE-u-attr-co-phonebk" returns a vector with two items: "attr" and "co-phonebk". If *singleton* is unknown, each subtag is returned in a separate item.

## -examples

## -see-also
[LanguageTag](language_languagetag.md), [BCP-47 language tags, Extensions and the Extensions Registry](https://tools.ietf.org/html/bcp47#section-3.7), [BCP-47 language tags, Extension Subtags](https://go.microsoft.com/fwlink/p/?LinkId=282718)
