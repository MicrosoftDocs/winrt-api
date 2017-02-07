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
The [WwwFormUrlDecoder](wwwformurldecoder.md) class represents a Uniform Resource Identifier (URI) query string as a sequence of name-value pairs. Each name-value pair is represented by a [WwwFormUrlDecoderEntry](wwwformurldecoderentry.md) object. The collection type of [WwwFormUrlDecoder](wwwformurldecoder.md) is [IWwwFormUrlDecoderEntry](iwwwformurldecoderentry.md), and [WwwFormUrlDecoderEntry](wwwformurldecoderentry.md) provides the practical implementation (as an implementation detail).

Use [IWwwFormUrlDecoderEntry](iwwwformurldecoderentry.md) the interface rather than [WwwFormUrlDecoder](wwwformurldecoder.md) the class when possible. The [WwwFormUrlDecoderEntry](wwwformurldecoderentry.md) class isn't present as a runtime class for all languages or for all platforms. C# and Visual Basic code can use the [WwwFormUrlDecoder](wwwformurldecoder.md) class, but can't use [WwwFormUrlDecoderEntry](wwwformurldecoderentry.md). Windows Phone for all languages, all versions can't use [WwwFormUrlDecoderEntry](wwwformurldecoderentry.md). In all Windows Runtime APIs that reference the entries, they are passed as objects implementing the [IWwwFormUrlDecoderEntry](iwwwformurldecoderentry.md) interface, so you shouldn't need to recast to [WwwFormUrlDecoderEntry](wwwformurldecoderentry.md) for any scenario.

<!--The APIs for C++ and JavaScript technically use the interface too, not the class, per the sigs and T type in WwwFormUrlDecoder. But the API is marked Dual, and it's possible that there is magic marshalling into this class, either because interfaces can't be dual or because of whatever crazy things JS does. Also, the class isn't supported for Phone, but the interface is. Makes me think that failing to remove the class from Windows 8.1 may have been a benign oversight that Phone has now corrected in its metadata.-->

## -examples

## -see-also
[WwwFormUrlDecoder](wwwformurldecoder.md), [IWwwFormUrlDecoderEntry](iwwwformurldecoderentry.md), [Uri](uri.md)