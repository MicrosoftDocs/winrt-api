---
-api-id: T:Windows.Web.Http.Headers.HttpContentCodingHeaderValueCollection
-api-type: winrt class
---

<!-- Class syntax.
public class HttpContentCodingHeaderValueCollection : Windows.Foundation.Collections.IIterable<Windows.Web.Http.Headers.HttpContentCodingHeaderValue>, Windows.Foundation.Collections.IVector<Windows.Web.Http.Headers.HttpContentCodingHeaderValue>, Windows.Foundation.IStringable, Windows.Web.Http.Headers.IHttpContentCodingHeaderValueCollection
-->

# Windows.Web.Http.Headers.HttpContentCodingHeaderValueCollection

## -description
Represents the value of the **Content-Encoding** HTTP header on HTTP content in a request or a response.

## -remarks
The HttpContentCodingHeaderValueCollection class represents the value of the **Content-Encoding** HTTP header on HTTP content sent in an HTTP request or received in an HTTP response.

The HttpContentCodingHeaderValueCollection provides a collection container for instances of the [HttpConnectionOptionHeaderValue](httpconnectionoptionheadervalue.md) class objects used for content encoding information in the **Content-Encoding** HTTP header.

The [ContentEncoding](httpcontentheadercollection_contentencoding.md) property on the [HttpContentHeaderCollection](httpcontentheadercollection.md) returns an HttpContentCodingHeaderValueCollection.

### Collection member lists

For JavaScript, HttpContentCodingHeaderValueCollection has the members shown in the member lists. In addition, HttpContentCodingHeaderValueCollection supports members of **Array.prototype** and using an index to access items.


<!--Begin NET note for IEnumerable support-->
### Enumerating the collection in C# or Microsoft Visual Basic

You can iterate through an HttpContentCodingHeaderValueCollection object in C# or Microsoft Visual Basic. In many cases, such as using **foreach** syntax, the compiler does this casting for you and you won't need to cast to `IEnumerable<HttpContentCodingHeaderValue>` explicitly. If you do need to cast explicitly, for example if you want to call [GetEnumerator](/dotnet/api/system.collections.ienumerable.getenumerator?view=dotnet-uwp-10.0&preserve-view=true), cast the collection object to [IEnumerable&lt;T&gt;](/dotnet/api/system.collections.generic.ienumerable-1?view=dotnet-uwp-10.0&preserve-view=true) with an [HttpContentCodingHeaderValue](httpcontentcodingheadervalue.md) constraint.

## -examples

## -see-also
[ContentEncoding](httpcontentheadercollection_contentencoding.md), [HttpContentCodingHeaderValue](httpcontentcodingheadervalue.md), [HttpContentHeaderCollection](httpcontentheadercollection.md), [IIterable(HttpContentCodingHeaderValue)](../windows.foundation.collections/iiterable_1.md), [IStringable](../windows.foundation/istringable.md), [IVector(HttpContentCodingHeaderValue)](../windows.foundation.collections/ivector_1.md)
