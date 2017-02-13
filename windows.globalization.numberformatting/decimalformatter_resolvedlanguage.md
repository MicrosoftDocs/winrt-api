---
-api-id: P:Windows.Globalization.NumberFormatting.DecimalFormatter.ResolvedLanguage
-api-type: winrt property
---

<!-- Property syntax
public string ResolvedLanguage { get; }
-->

# Windows.Globalization.NumberFormatting.DecimalFormatter.ResolvedLanguage

## -description
Gets the language that was most recently used to format or parse decimal values.

## -property-value
The language from the [priority list of language identifiers](decimalformatter_languages.md) that was most recently used to format or parse decimal values.

**Starting in :** Language tags can support Unicode extensions. See the Remarks for the [DecimalFormatter(IIterable(String), String)](decimalformatter_decimalformatter_177128098.md) constructor.

## -remarks
If your app passes language tags from this class to any [National Language Support](http://msdn.microsoft.com/library/7a548074-0782-45e1-8051-80c3b9d81885) functions, it must first convert the tags by calling [ResolveLocaleName](http://msdn.microsoft.com/library/99264b22-3fb5-47e2-b0b9-42a6768e67c1).

## -examples

## -see-also
