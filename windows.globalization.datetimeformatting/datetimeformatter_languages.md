---
-api-id: P:Windows.Globalization.DateTimeFormatting.DateTimeFormatter.Languages
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Collections.IVectorView<string> Languages { get; }
-->

# Windows.Globalization.DateTimeFormatting.DateTimeFormatter.Languages

## -description

Gets the priority list of language identifiers that is used when formatting dates and times.

## -property-value

The list of languages that is used.

## -remarks

Initialize this class with a [BCP-47](https://tools.ietf.org/html/bcp47) language tag. For example, to work with the best current user-preferred language, pass in the top value from [Windows.System.UserProfile.GlobalizationPreferences](../windows.system.userprofile/globalizationpreferences.md).

Language tags support the Unicode extensions "ca-" and "nu-". (See [Unicode Key/Type Definitions](https://www.unicode.org/reports/tr35/#Key_Type_Definitions).) Note that these extensions can affect the calendar used by Calendar objects.

> [!NOTE]
> If your app passes language tags from this class to any [National Language Support](/windows/desktop/Intl/national-language-support) functions, it must first convert the tags by calling [ResolveLocaleName](/windows/desktop/api/winnls/nf-winnls-resolvelocalename).

## -examples

## -see-also
