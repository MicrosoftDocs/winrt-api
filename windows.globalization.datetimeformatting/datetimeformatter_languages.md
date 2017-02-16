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
Initialize this class with a [BCP-47](http://go.microsoft.com/fwlink/p/?linkid=227302) language tag. For example, to work with the best current user-preferred language, pass in the top value from [Windows.System.UserProfile.GlobalizationPreferences](../windows.system.userprofile/globalizationpreferences.md).

> [!NOTE]
> If your app passes language tags from this class to any [National Language Support](http://msdn.microsoft.com/library/7a548074-0782-45e1-8051-80c3b9d81885) functions, it must first convert the tags by calling [ResolveLocaleName](http://msdn.microsoft.com/library/99264b22-3fb5-47e2-b0b9-42a6768e67c1).

## -examples

## -see-also
