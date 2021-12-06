---
-api-id: T:Windows.Web.Http.Headers.HttpContentCodingWithQualityHeaderValueCollection
-api-type: winrt class
---

<!-- Class syntax.
public class HttpContentCodingWithQualityHeaderValueCollection : Windows.Foundation.Collections.IIterable<Windows.Web.Http.Headers.HttpContentCodingWithQualityHeaderValue>, Windows.Foundation.Collections.IVector<Windows.Web.Http.Headers.HttpContentCodingWithQualityHeaderValue>, Windows.Foundation.IStringable, Windows.Web.Http.Headers.IHttpContentCodingWithQualityHeaderValueCollection
-->

# Windows.Web.Http.Headers.HttpContentCodingWithQualityHeaderValueCollection

## -description
Represents the value of the **Accept-Encoding** HTTP header on an HTTP request.

## -remarks
The HttpContentCodingWithQualityHeaderValueCollection class represents the value of the **Accept-Encoding** HTTP header on an HTTP request.

The HttpContentCodingWithQualityHeaderValueCollection provides a collection container for instances of the [HttpContentCodingWithQualityHeaderValue](httpcontentcodingwithqualityheadervalue.md) class used for accept encoding information in the **Accept-Encoding** HTTP header.

The [AcceptEncoding](httprequestheadercollection_acceptencoding.md) property on the [HttpRequestHeaderCollection](httprequestheadercollection.md) returns an HttpContentCodingWithQualityHeaderValueCollection object. This is the method used to construct an HttpContentCodingWithQualityHeaderValueCollection object.

### Collection member lists

For JavaScript, HttpContentCodingWithQualityHeaderValueCollection has the members shown in the member lists. In addition, HttpContentCodingWithQualityHeaderValueCollection supports members of **Array.prototype** and using an index to access items.


<!--Begin NET note for IEnumerable support-->
### Enumerating the collection in C# or Microsoft Visual Basic

You can iterate through an HttpContentCodingWithQualityHeaderValueCollection object in C# or Microsoft Visual Basic. In many cases, such as using **foreach** syntax, the compiler does this casting for you and you won't need to cast to `IEnumerable<HttpContentCodingWithQualityHeaderValue>` explicitly. If you do need to cast explicitly, for example if you want to call [GetEnumerator](/dotnet/api/system.collections.ienumerable.getenumerator?view=dotnet-uwp-10.0&preserve-view=true), cast the collection object to [IEnumerable&lt;T&gt;](/dotnet/api/system.collections.generic.ienumerable-1?view=dotnet-uwp-10.0&preserve-view=true) with an [HttpContentCodingWithQualityHeaderValue](httpcontentcodingwithqualityheadervalue.md) constraint.

## -examples
The following sample code shows a method to get and set the **Accept-Encoding** HTTP header on an [HttpRequestMessage](../windows.web.http/httprequestmessage.md) object using the properties and methods on the HttpContentCodingWithQualityHeaderValueCollection and [HttpContentCodingWithQualityHeaderValue](httpcontentcodingwithqualityheadervalue.md) classes.

```csharp
using Windows.Web.Http;
using Windows.Web.Http.Headers;

        public void DemonstrateHeaderRequestAcceptEncoding()
        {
            var request = new HttpRequestMessage();
            bool parsedOk = false;

            // Set the header with a string.
            parsedOk = request.Headers.AcceptEncoding.TryParseAdd("compress");
            parsedOk = request.Headers.AcceptEncoding.TryParseAdd("gzip;q=1.0");

            // Set the header with a strong type.
            request.Headers.AcceptEncoding.Add(new HttpContentCodingWithQualityHeaderValue("*", 0));

            // Get the strong type out
            foreach (var value in request.Headers.AcceptEncoding)
            {
                System.Diagnostics.Debug.WriteLine("One of the AcceptEncoding values: {0}={1}", value.ContentCoding, value.Quality);
            }

            // The ToString() is useful for diagnostics, too.
            System.Diagnostics.Debug.WriteLine("The AcceptEncoding ToString() results: {0}", request.Headers.AcceptEncoding.ToString());
        }


```



## -see-also
[AcceptEncoding](httprequestheadercollection_acceptencoding.md), [HttpContentCodingWithQualityHeaderValue](httpcontentcodingwithqualityheadervalue.md), [HttpRequestHeaderCollection](httprequestheadercollection.md), [HttpRequestMessage](../windows.web.http/httprequestmessage.md), [IIterable(HttpContentCodingWithQualityHeaderValue)](../windows.foundation.collections/iiterable_1.md), [IStringable](../windows.foundation/istringable.md), [IVector(HttpContentCodingWithQualityHeaderValue)](../windows.foundation.collections/ivector_1.md)
