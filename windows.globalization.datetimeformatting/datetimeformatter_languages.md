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

**Starting in :** Language tags can support Unicode extensions. See the Remarks for the [DateTimeFormatter(String, IIterable(String))](datetimeformatter_datetimeformatter_204585840.md) constructor.

## -remarks
Initialize this class with a [BCP-47](https://go.microsoft.com/fwlink/p/?linkid=227302) language tag. For example, to work with the best current user-preferred language, pass in the top value from [Windows.System.UserProfile.GlobalizationPreferences](../windows.system.userprofile/globalizationpreferences.md).

> [!NOTE]
> If your app passes language tags from this class to any [National Language Support](https://docs.microsoft.com/windows/desktop/Intl/national-language-support) functions, it must first convert the tags by calling [ResolveLocaleName](https://docs.microsoft.com/windows/desktop/api/winnls/nf-winnls-resolvelocalename).

## -examples

## -see-also
