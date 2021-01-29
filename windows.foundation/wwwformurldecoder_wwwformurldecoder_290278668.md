---
-api-id: M:Windows.Foundation.WwwFormUrlDecoder.#ctor(System.String)
-api-type: winrt method
---

<!-- Method syntax
public WwwFormUrlDecoder(System.String query)
-->

# Windows.Foundation.WwwFormUrlDecoder.WwwFormUrlDecoder

## -description

Creates and initializes a new instance of the [WwwFormUrlDecoder](wwwformurldecoder.md) class.

## -parameters

### -param query

The URL to parse.

## -remarks

The query string must start with a '?' character.

Any '&amp;' character encountered represents a new name-value pair. If there is a '=' character present in the string, the substring to the left of the '=' character is the name and the right substring is the value.

The constructor doesn't do much validation on the string beyond verifying that it isn't **null** or the wrong type. If your input doesn't correctly represent a query string that starts with '?' and contains name-value pairs separated by '&amp;', the collection contents are empty or invalid, and calls to [GetFirstValueByName](wwwformurldecoder_getfirstvaluebyname_186006860.md) won't have the expected result.

URL-encoded characters are automatically decoded before the value is added to a name-value pair.

## -examples

## -see-also

[IWwwFormUrlDecoderEntry](iwwwformurldecoderentry.md)