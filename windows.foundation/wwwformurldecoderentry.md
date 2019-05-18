---
-api-id: T:Windows.Foundation.WwwFormUrlDecoderEntry
-api-type: winrt class
---

<!-- Class syntax.
public class WwwFormUrlDecoderEntry : Windows.Foundation.IWwwFormUrlDecoderEntry
-->

# Windows.Foundation.WwwFormUrlDecoderEntry

## -description
Represents a name-value pair in a URL query string. Use the [IWwwFormUrlDecoderEntry](iwwwformurldecoderentry.md) interface instead; see Remarks.

## -remarks
The [WwwFormUrlDecoder](wwwformurldecoder.md) class represents a Uniform Resource Identifier (URI) query string as a sequence of name-value pairs. Each name-value pair is represented by a WwwFormUrlDecoderEntry object. The collection type of [WwwFormUrlDecoder](wwwformurldecoder.md) is [IWwwFormUrlDecoderEntry](iwwwformurldecoderentry.md), and WwwFormUrlDecoderEntry provides the practical implementation (as an implementation detail).

Use [IWwwFormUrlDecoderEntry](iwwwformurldecoderentry.md) the interface rather than [WwwFormUrlDecoder](wwwformurldecoder.md) the class when possible. The WwwFormUrlDecoderEntry class isn't present as a runtime class for all languages or for all platforms. C# and Visual Basic code can use the [WwwFormUrlDecoder](wwwformurldecoder.md) class, but can't use WwwFormUrlDecoderEntry. Windows Phone for all languages, all versions can't use WwwFormUrlDecoderEntry. In all Windows Runtime APIs that reference the entries, they are passed as objects implementing the [IWwwFormUrlDecoderEntry](iwwwformurldecoderentry.md) interface, so you shouldn't need to recast to WwwFormUrlDecoderEntry for any scenario.

## -examples

## -see-also
[WwwFormUrlDecoder](wwwformurldecoder.md), [IWwwFormUrlDecoderEntry](iwwwformurldecoderentry.md), [Uri](uri.md)
