---
-api-id: T:Windows.Web.Http.Headers.HttpChallengeHeaderValueCollection
-api-type: winrt class
---

<!-- Class syntax.
public class HttpChallengeHeaderValueCollection : Windows.Foundation.Collections.IIterable<Windows.Web.Http.Headers.HttpChallengeHeaderValue>, Windows.Foundation.Collections.IVector<Windows.Web.Http.Headers.HttpChallengeHeaderValue>, Windows.Foundation.IStringable, Windows.Web.Http.Headers.IHttpChallengeHeaderValueCollection
-->

# Windows.Web.Http.Headers.HttpChallengeHeaderValueCollection

## -description
Represents the value of the **Proxy-Authenticate** or **WWW-Authenticate** HTTP header on an HTTP response.

## -remarks
The HttpChallengeHeaderValueCollection represents the value of the **Proxy-Authenticate** or **WWW-Authenticate** HTTP header on an HTTP response.

The HttpChallengeHeaderValueCollection provides a collection container for instances of the [HttpChallengeHeaderValue](httpchallengeheadervalue.md) class used for authentication information used in the **Authorization**, **ProxyAuthorization**, **WWW-Authenticate**, and **Proxy-Authenticate** HTTP header values.

The [ProxyAuthenticate](httpresponseheadercollection_proxyauthenticate.md) property on [HttpResponseHeaderCollection](httpresponseheadercollection.md) returns an HttpChallengeHeaderValueCollection object. The [WwwAuthenticate](httpresponseheadercollection_wwwauthenticate.md) property on [HttpResponseHeaderCollection](httpresponseheadercollection.md) also returns an HttpChallengeHeaderValueCollection object.

### Collection member lists

For JavaScript, HttpChallengeHeaderValueCollection has the members shown in the member lists. In addition, HttpChallengeHeaderValueCollection supports members of **Array.prototype** and using an index to access items.


<!--Begin NET note for IEnumerable support-->
### Enumerating the collection in C# or Microsoft Visual Basic

You can iterate through an HttpChallengeHeaderValueCollection object in C# or Microsoft Visual Basic. In many cases, such as using **foreach** syntax, the compiler does this casting for you and you won't need to cast to `IEnumerable<HttpChallengeHeaderValue>` explicitly. If you do need to cast explicitly, for example if you want to call [GetEnumerator](/dotnet/api/system.collections.ienumerable.getenumerator?view=dotnet-uwp-10.0&preserve-view=true), cast the collection object to [IEnumerable&lt;T&gt;](/dotnet/api/system.collections.generic.ienumerable-1?view=dotnet-uwp-10.0&preserve-view=true) with an [HttpChallengeHeaderValue](httpchallengeheadervalue.md) constraint.


<!--End NET note for IEnumerable support-->

## -examples
The following sample code shows a method to get and set the **Proxy-Authenticate** HTTP header on an [HttpResponseMessage](../windows.web.http/httpresponsemessage.md) object using the properties and methods on the HttpChallengeHeaderValueCollection and [HttpChallengeHeaderValue](httpchallengeheadervalue.md) classes.

```csharp
using System;
using Windows.Web.Http;
using Windows.Web.Http.Headers;

        public void DemonstrateHeaderResponseProxyAuthenticate() {
            var response = new HttpResponseMessage();

            // Set the header with a strong type.
            response.Headers.ProxyAuthenticate.TryParseAdd("Basic");
            response.Headers.ProxyAuthenticate.Add(new HttpChallengeHeaderValue("authScheme", "authToken"));

            // Get the strong type out
            foreach (var value in response.Headers.ProxyAuthenticate) {
                System.Diagnostics.Debug.WriteLine("Proxy authenticate scheme and token: {0} {1}", value.Scheme, value.Token);
            }

            // The ToString() is useful for diagnostics, too.
            System.Diagnostics.Debug.WriteLine("The ProxyAuthenticate ToString() results: {0}", response.Headers.ProxyAuthenticate.ToString());
        }

```



## -see-also
[HttpChallengeHeaderValue](httpchallengeheadervalue.md), [HttpResponseMessage](../windows.web.http/httpresponsemessage.md), [HttpResponseHeaderCollection](httpresponseheadercollection.md), [IIterable(HttpChallengeHeaderValue)](../windows.foundation.collections/iiterable_1.md), [IStringable](../windows.foundation/istringable.md), [IVector(HttpChallengeHeaderValue)](../windows.foundation.collections/ivector_1.md), [ProxyAuthenticate](httpresponseheadercollection_proxyauthenticate.md), [WwwAuthenticate](httpresponseheadercollection_wwwauthenticate.md)
