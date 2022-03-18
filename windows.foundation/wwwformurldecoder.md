---
-api-id: T:Windows.Foundation.WwwFormUrlDecoder
-api-type: winrt class
---

<!-- Class syntax.
public class WwwFormUrlDecoder : Windows.Foundation.Collections.IIterable<Windows.Foundation.IWwwFormUrlDecoderEntry>, Windows.Foundation.Collections.IVectorView<Windows.Foundation.IWwwFormUrlDecoderEntry>, Windows.Foundation.IWwwFormUrlDecoderRuntimeClass
-->

# Windows.Foundation.WwwFormUrlDecoder

## -description
Parses a URL query string, and exposes the results as a read-only vector (list) of name-value pairs from the query string.

## -remarks
Use the WwwFormUrlDecoder class to parse a query string into name-value pairs, based on the number and placement of "&" and "=" symbols. Each name-value pair is represented by an [IWwwFormUrlDecoderEntry](iwwwformurldecoderentry.md) object, which has a [Name](wwwformurldecoderentry_name.md) property and a [Value](ireferencearray_1_value.md) property (both strings).

Use [GetFirstValueByName](wwwformurldecoder_getfirstvaluebyname_186006860.md) to find a specific named query string parameter. All languages can use this method. You'd typically use [GetFirstValueByName](wwwformurldecoder_getfirstvaluebyname_186006860.md) rather than [GetAt](wwwformurldecoder_getat_496709656.md) because the order of items in a query string usually isn't important, whereas the parameter name is the important identifier of the parts of a query. Or, if you're not sure what names exist in the query string, you might enumerate over the complete WwwFormUrlDecoder collection.

The [Uri.QueryParsed](uri_queryparsed.md) property returns a complete WwwFormUrlDecoder based on a [Uri](uri.md) instance. So if you're using Visual C++ component extensions (C++/CX) or JavaScript code, and you already have a [Uri](uri.md) instance, you won't need to construct a new WwwFormUrlDecoder object, the [Uri](uri.md) instance already has one. You might construct a WwwFormUrlDecoder if you have a string representing a URL or its query string component from other sources, such as from a [Windows.Web.Http](../windows.web.http/windows_web_http.md) API.

> [!NOTE]
> This collection is a vector rather than a map in case the original order has any meaning to an implementation, and also because it's legal for the same name to appear in the query string twice, whereas it's not legal for maps to have duplicate keys.

### Collection member lists

For .NET usage, WwwFormUrlDecoder has the projected APIs of a generic [IReadOnlyList](/dotnet/api/system.collections.generic.ireadonlylist-1?view=dotnet-uwp-10.0&preserve-view=true) with a [IWwwFormUrlDecoderEntry](iwwwformurldecoderentry.md) constraint. The APIs that are available for each language are indicated in the member lists.

For JavaScript, WwwFormUrlDecoder has the members shown in the member lists. In addition, WwwFormUrlDecoder supports a **length** property, members of **Array.prototype**, and using an index to access items.

### .NET usage

.NET code can't use the [Windows.Foundation.Uri](uri.md) class (you use [System.Uri](/dotnet/api/system.uri?view=dotnet-uwp-10.0&preserve-view=true) instead). But .NET code can and should use WwwFormUrlDecoder. Using WwwFormUrlDecoder is simpler and less error-prone than string-splitting on "&amp;" and "=" characters. That gets complicated because of encoding. To use WwwFormUrlDecoder, call the [WwwFormUrlDecoder](wwwformurldecoder_wwwformurldecoder_290278668.md) constructor, passing in the [Query](/dotnet/api/system.uri.query?view=dotnet-uwp-10.0&preserve-view=true) value from your [System.Uri](/dotnet/api/system.uri?view=dotnet-uwp-10.0&preserve-view=true). This initializes a new WwwFormUrlDecoder object. Then use [GetFirstValueByName](wwwformurldecoder_getfirstvaluebyname_186006860.md) to find a specific named query string parameter. Or, if you don't know what's going to be in the query string, enumerate over the collection to determine the query string parameters that are available.

Use the [IWwwFormUrlDecoderEntry](iwwwformurldecoderentry.md) interface for the type of the items in the collection (this is how the items are typed by [IndexOf](wwwformurldecoder_indexof_927506301.md)). Don't use the [WwwFormUrlDecoderEntry](wwwformurldecoderentry.md) class, it isn't available for .NET usage.

WwwFormUrlDecoder also has the projected APIs of a generic [IReadOnlyList](/dotnet/api/system.collections.generic.ireadonlylist-1?view=dotnet-uwp-10.0&preserve-view=true) with a [IWwwFormUrlDecoderEntry](iwwwformurldecoderentry.md) constraint, but these APIs aren't commonly used.

> [!NOTE]
> `System.Web.HttpUtility.ParseQueryString` isn't available for .NET for Windows Runtime app. WwwFormUrlDecoder is the recommended replacement for it.


<!--Begin NET note for IEnumerable support-->
### Enumerating the collection in C# or Microsoft Visual Basic

WwwFormUrlDecoder is enumerable, so you can use language-specific syntax such as **foreach** in C# to enumerate the items in the collection. The compiler does the type-casting for you and you won't need to cast to `IEnumerable<IWwwFormUrlDecoderEntry>` explicitly. If you do need to cast explicitly, for example if you want to call [GetEnumerator](/dotnet/api/system.collections.ienumerable.getenumerator?view=dotnet-uwp-10.0&preserve-view=true), cast to [IEnumerable&lt;T&gt;](/dotnet/api/system.collections.ienumerable?view=dotnet-uwp-10.0&preserve-view=true) with an [IWwwFormUrlDecoderEntry](iwwwformurldecoderentry.md) constraint.


<!--End NET note for IEnumerable support-->

## -examples

## -see-also
[IWwwFormUrlDecoderEntry](iwwwformurldecoderentry.md), [Uri.QueryParsed](uri_queryparsed.md)
