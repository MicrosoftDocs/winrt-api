---
-api-id: P:Windows.Globalization.NumberFormatting.PermilleFormatter.Languages
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Collections.IVectorView<string> Languages { get; }
-->

# Windows.Globalization.NumberFormatting.PermilleFormatter.Languages

## -description
Gets the priority list of language identifiers that is used when formatting and parsing permille values.

## -property-value
The priority list of language identifiers.

**Starting in :** Language tags can support Unicode extensions. See the Remarks for the [PermilleFormatter(IIterable(String), String)](permilleformatter_permilleformatter_177128098.md) constructor.

## -remarks
If your app passes language tags from this class to any [National Language Support](/windows/desktop/Intl/national-language-support) functions, it must first convert the tags by calling [ResolveLocaleName](/windows/desktop/api/winnls/nf-winnls-resolvelocalename).

## -examples

## -see-also
