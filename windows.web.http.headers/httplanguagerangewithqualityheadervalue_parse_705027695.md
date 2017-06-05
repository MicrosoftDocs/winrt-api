---
-api-id: M:Windows.Web.Http.Headers.HttpLanguageRangeWithQualityHeaderValue.Parse(System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Web.Http.Headers.HttpLanguageRangeWithQualityHeaderValue Parse(System.String input)
-->

# Windows.Web.Http.Headers.HttpLanguageRangeWithQualityHeaderValue.Parse

## -description
Converts a string to an [HttpLanguageRangeWithQualityHeaderValue](httplanguagerangewithqualityheadervalue.md) instance.

## -parameters
### -param input
A string that represents the language-range and quality factor information used in the **Accept-Encoding** HTTP header.

## -returns
An [HttpLanguageRangeWithQualityHeaderValue](httplanguagerangewithqualityheadervalue.md) instance.

## -remarks
Below is the exception that this function throws.

### E_INVALIDARG

The *input* parameter is **null** (**Nothing** in Visual Basic).

The *input* parameter is not valid language-range and quality factor information.

## -examples

## -see-also
