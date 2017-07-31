---
-api-id: M:Windows.Web.Http.Headers.HttpMediaTypeWithQualityHeaderValue.Parse(System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Web.Http.Headers.HttpMediaTypeWithQualityHeaderValue Parse(System.String input)
-->

# Windows.Web.Http.Headers.HttpMediaTypeWithQualityHeaderValue.Parse

## -description
Converts a string to an [HttpMediaTypeWithQualityHeaderValue](httpmediatypewithqualityheadervalue.md) instance.

## -parameters
### -param input
A string that represents the media-type, character set, and quality information used in the **Accept** HTTP header.

## -returns
An [HttpMediaTypeWithQualityHeaderValue](httpmediatypewithqualityheadervalue.md) instance.

## -remarks
Below are the exceptions that this function throws.

### E_INVALIDARG

The *input* parameter is **null** (**Nothing** in Visual Basic).

The *input* parameter is not valid media-type, character set , and quality information.

## -examples

## -see-also
