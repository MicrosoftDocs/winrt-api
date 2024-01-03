---
-api-id: M:Windows.Data.Text.SemanticTextQuery.#ctor(System.String,System.String)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public SemanticTextQuery(System.String aqsFilter, System.String filterLanguage)
-->

# Windows.Data.Text.SemanticTextQuery.SemanticTextQuery

## -description
Creates a [SemanticTextQuery](semantictextquery.md) from an Advanced Query Syntax (AQS) query string and a language tag.

## -parameters
### -param aqsFilter
An Advanced Query Syntax (AQS) string that contains the desired query. Learn more in [Advanced Query Syntax](/windows/win32/lwef/-search-2x-wds-aqsreference).

### -param filterLanguage
The [BCP-47](https://tools.ietf.org/html/bcp47) language tag to be employed in the query.

To see a list of the language tags specifically supported by the Microsoft Store, see [Choosing your languages](/windows/uwp/publish/supported-languages).

## -remarks
*filterLanguage* permits queries to work with language differences. For example, if *aqsFilter* is "19,5" and *filterLanguage* is "pl" (Polish), a call to [Find](semantictextquery_find_1750099982.md) against text that includes "19.5" returns a text segment because it is understood that the comma is the decimal separator in Polish.

## -examples

## -see-also
[SemanticTextQuery(String)](semantictextquery_semantictextquery_290278668.md)
