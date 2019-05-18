---
-api-id: T:Windows.Web.Http.Headers.HttpCookiePairHeaderValueCollection
-api-type: winrt class
---

<!-- Class syntax.
public class HttpCookiePairHeaderValueCollection : Windows.Foundation.Collections.IIterable<Windows.Web.Http.Headers.HttpCookiePairHeaderValue>, Windows.Foundation.Collections.IVector<Windows.Web.Http.Headers.HttpCookiePairHeaderValue>, Windows.Foundation.IStringable, Windows.Web.Http.Headers.IHttpCookiePairHeaderValueCollection
-->

# Windows.Web.Http.Headers.HttpCookiePairHeaderValueCollection

## -description
Represents the value of the **Cookie** HTTP header on an HTTP request.

## -remarks
The HttpCookiePairHeaderValueCollection class represents the value of the **Cookie** HTTP header on an HTTP request.

The HttpCookiePairHeaderValueCollection provides a collection container for instances of the [HttpCookiePairHeaderValue](httpcookiepairheadervalue.md) class used for cookie information in the **Cookie** HTTP header.

The [Cookie](httprequestheadercollection_cookie.md) property on the [HttpRequestHeaderCollection](httprequestheadercollection.md) returns an HttpCookiePairHeaderValueCollection object

## -examples
The following sample code shows a method to get and set the **Cookie** HTTP header on an [HttpRequestMessage](../windows.web.http/httprequestmessage.md) object using the properties and methods on the HttpCookiePairHeaderValueCollection and [HttpCookiePairHeaderValue](httpcookiepairheadervalue.md) classes.

```csharp
using System;
using Windows.Web.Http;
using Windows.Web.Http.Headers;

        public void DemonstrateHeaderRequestCookie() {
            var request = new HttpRequestMessage();
            bool parsedOk = false;

            // Set the header with a string.
            parsedOk = request.Headers.Cookie.TryParseAdd("cookieName=cookieValue");

            // Set the header with a strong type.
            request.Headers.Cookie.Add(new HttpCookiePairHeaderValue("cookie2", "value2"));

            // Get the strong type out
            foreach (var value in request.Headers.Cookie) {
                System.Diagnostics.Debug.WriteLine("One of the Cookie values: {0}={1}", value.Name, value.Value);
            }

```



## -see-also
[IVector(HttpCookiePairHeaderValue)](../windows.foundation.collections/ivector_1.md), [IIterable(HttpCookiePairHeaderValue)](../windows.foundation.collections/iiterable_1.md), [IStringable](../windows.foundation/istringable.md)
