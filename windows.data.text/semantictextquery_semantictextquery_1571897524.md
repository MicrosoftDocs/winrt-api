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
An Advanced Query Syntax (AQS) string that contains the desired query. Learn more about Advanced Query Syntax (AQS) in [](http://msdn.microsoft.com/library/8e55bd40-c7cf-44a6-bc18-24bc7a267779).

### -param filterLanguage
The [BCP-47](http://go.microsoft.com/fwlink/p/?LinkId=227302) language tag to be employed in the query.

To see a list of the language tags specifically supported by the Microsoft Store, see [Choosing your languages](http://msdn.microsoft.com/library/fca66311-4145-46ac-8b20-1e736f940976).

## -remarks
*filterLanguage* permits queries to work with language differences. For example, if *aqsFilter* is "19,5" and *filterLanguage* is "pl" (Polish), a call to [Find](semantictextquery_find_1750099982.md) against text that includes "19.5" returns a text segment because it is understood that the comma is the decimal separator in Polish.

## -examples

## -see-also
[SemanticTextQuery(String)](semantictextquery_semantictextquery_290278668.md)