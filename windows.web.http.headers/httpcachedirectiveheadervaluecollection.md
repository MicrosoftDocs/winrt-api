---
-api-id: T:Windows.Web.Http.Headers.HttpCacheDirectiveHeaderValueCollection
-api-type: winrt class
---

<!-- Class syntax.
public class HttpCacheDirectiveHeaderValueCollection : Windows.Foundation.Collections.IIterable<Windows.Web.Http.Headers.HttpNameValueHeaderValue>, Windows.Foundation.Collections.IVector<Windows.Web.Http.Headers.HttpNameValueHeaderValue>, Windows.Foundation.IStringable, Windows.Web.Http.Headers.IHttpCacheDirectiveHeaderValueCollection
-->

# Windows.Web.Http.Headers.HttpCacheDirectiveHeaderValueCollection

## -description
Represents the value of the **Cache-Control** HTTP header on HTTP content associated with an HTTP request or response.

## -remarks
The HttpCacheDirectiveHeaderValueCollection class represents the value of the **Cache-Control** HTTP header on HTTP content associated with an HTTP request or an HTTP response.

The [CacheControl](httprequestheadercollection_cachecontrol.md) property on the [HttpRequestHeaderCollection](httprequestheadercollection.md) returns an HttpCacheDirectiveHeaderValueCollection. The [CacheControl](httpresponseheadercollection_cachecontrol.md) property on the [HttpResponseHeaderCollection](httpresponseheadercollection.md) returns an HttpCacheDirectiveHeaderValueCollection.

### Collection member lists

For JavaScript, HttpCacheDirectiveHeaderValueCollection has the members shown in the member lists. In addition, HttpCacheDirectiveHeaderValueCollection supports members of **Array.prototype** and using an index to access items.


<!--Begin NET note for IEnumerable support-->
### Enumerating the collection in C# or Microsoft Visual Basic

You can iterate through an HttpCacheDirectiveHeaderValueCollection object in C# or Microsoft Visual Basic. In many cases, such as using **foreach** syntax, the compiler does this casting for you and you won't need to cast to `IEnumerable<HttpNameValueHeaderValue>` explicitly. If you do need to cast explicitly, for example if you want to call [GetEnumerator](/dotnet/api/system.collections.ienumerable.getenumerator?view=dotnet-uwp-10.0&preserve-view=true), cast the collection object to [IEnumerable&lt;T&gt;](/dotnet/api/system.collections.generic.ienumerable-1?view=dotnet-uwp-10.0&preserve-view=true) with an [HttpNameValueHeaderValue](httpnamevalueheadervalue.md) constraint.


<!--End NET note for IEnumerable support-->

## -examples
The following sample code shows a method to get and set the **Cache-Control** HTTP header on an [HttpRequestMessage](../windows.web.http/httprequestmessage.md) object using the properties and methods on the HttpCacheDirectiveHeaderValueCollection class.

```csharp
using System;
using Windows.Web.Http;
using Windows.Web.Http.Headers;

        public void DemonstrateHeaderRequestCacheControl() {
            var request = new HttpRequestMessage();
            bool parsedOk = false;

            // Set the header with a string.
            parsedOk = request.Headers.CacheControl.TryParseAdd("no-store");

            // Set the header with a strong type.
            request.Headers.CacheControl.Add(new HttpNameValueHeaderValue("max-age", "10"));

            // Get the strong type out
            foreach (var value in request.Headers.CacheControl) {
                System.Diagnostics.Debug.WriteLine("One of the CacheControl values: {0}={1}", value.Name, value.Value);
            }

            // The ToString() is useful for diagnostics, too.
            System.Diagnostics.Debug.WriteLine("The CacheControl ToString() results: {0}", request.Headers.CacheControl.ToString());
        }

```

The following sample code shows a method to get and set the **Cache-Control** HTTP header on an [HttpResponseMessage](../windows.web.http/httpresponsemessage.md) object using the properties and methods on the HttpCacheDirectiveHeaderValueCollection class.

```csharp
using System;
using Windows.Web.Http;
using Windows.Web.Http.Headers;

        public void DemonstrateHeaderResponseCacheControl() {
            var response = new HttpResponseMessage();

            // Set the header with a string
            response.Headers.CacheControl.TryParseAdd("public");

            // Set the header with a strong type
            response.Headers.CacheControl.Add(new HttpNameValueHeaderValue("max-age", "30"));

            // Get the strong type out
            foreach (var value in response.Headers.CacheControl) {
                System.Diagnostics.Debug.WriteLine("CacheControl {0}={1}", value.Name, value.Value);
            }

            // The ToString() is useful for diagnostics, too.
            System.Diagnostics.Debug.WriteLine("The CacheControl ToString() results: {0}", response.Headers.CacheControl.ToString());
        }

```



## -see-also
[HttpResponseHeaderCollection](httpresponseheadercollection.md), [HttpResponseHeaderCollection.CacheControl](httpresponseheadercollection_cachecontrol.md), [HttpRequestHeaderCollection](httprequestheadercollection.md), [HttpRequestHeaderCollection.CacheControl](httprequestheadercollection_cachecontrol.md), [HttpResponseMessage](../windows.web.http/httpresponsemessage.md), [IIterable(HttpNameValueHeaderValue)](../windows.foundation.collections/iiterable_1.md), [IStringable](../windows.foundation/istringable.md), [IVector(HttpNameValueHeaderValue)](../windows.foundation.collections/ivector_1.md)
