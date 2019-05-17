---
-api-id: T:Windows.Web.Http.Headers.HttpProductInfoHeaderValueCollection
-api-type: winrt class
---

<!-- Class syntax.
public class HttpProductInfoHeaderValueCollection : Windows.Foundation.Collections.IIterable<Windows.Web.Http.Headers.HttpProductInfoHeaderValue>, Windows.Foundation.Collections.IVector<Windows.Web.Http.Headers.HttpProductInfoHeaderValue>, Windows.Foundation.IStringable, Windows.Web.Http.Headers.IHttpProductInfoHeaderValueCollection
-->

# Windows.Web.Http.Headers.HttpProductInfoHeaderValueCollection

## -description
Represents the value of the **User-Agent** HTTP header on an HTTP request.

## -remarks
The HttpProductInfoHeaderValueCollection represents the value of the **User-Agent** HTTP header on an HTTP request.

The HttpProductInfoHeaderValueCollection is a collection of [HttpProductInfoHeaderValue](httpproductinfoheadervalue.md) objects used for product information in the HTTP **User-Agent** header.

The **User-Agent** header contains information about the user agent originating the request. The **User-Agent** header can contain multiple product tokens and comments identifying the user agent and any sub-products.

The [UserAgent](httprequestheadercollection_useragent.md) property on the [HttpRequestHeaderCollection](httprequestheadercollection.md) returns an HttpProductInfoHeaderValueCollection object.

## -examples
The following sample code shows a method to get and set the **User-Agent** HTTP header on an [HttpRequestMessage](../windows.web.http/httprequestmessage.md) object using the properties and methods on the HttpProductInfoHeaderValueCollection and [HttpProductInfoHeaderValue](httpproductinfoheadervalue.md) classes.

```csharp

using System;
using Windows.Web.Http;
using Windows.Web.Http.Headers;

        public void DemonstrateHeaderRequestUserAgent() {
            var request = new HttpRequestMessage();
            bool parsedOk = false;

            // Set the header with a string.
            parsedOk = request.Headers.UserAgent.TryParseAdd("testprogram/1.0");

            // Set the header with a strong type.
            request.Headers.UserAgent.Add(new HttpProductInfoHeaderValue("myprogram", "2.2"));

            // Get the strong type out 
            foreach (var value in request.Headers.UserAgent) {
                System.Diagnostics.Debug.WriteLine("One of the UserAgent values: {0} / {1}", value.Product.Name, value.Product.Version);
            }

            // The ToString() is useful for diagnostics, too.
            System.Diagnostics.Debug.WriteLine("The UserAgent ToString() results: {0}", request.Headers.UserAgent.ToString());
        }

```



## -see-also
[HttpProductInfoHeaderValue](httpproductinfoheadervalue.md), [HttpRequestHeaderCollection](httprequestheadercollection.md), [IIterable(HttpProductInfoHeaderValue)](../windows.foundation.collections/iiterable_1.md), [IStringable](../windows.foundation/istringable.md), [IVector(HttpProductInfoHeaderValue)](../windows.foundation.collections/ivector_1.md), [UserAgent](httprequestheadercollection_useragent.md)
