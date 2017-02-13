---
-api-id: T:Windows.Web.Http.Headers.HttpMediaTypeWithQualityHeaderValueCollection
-api-type: winrt class
---

<!-- Class syntax.
public class HttpMediaTypeWithQualityHeaderValueCollection : Windows.Foundation.Collections.IIterable<Windows.Web.Http.Headers.HttpMediaTypeWithQualityHeaderValue>, Windows.Foundation.Collections.IVector<Windows.Web.Http.Headers.HttpMediaTypeWithQualityHeaderValue>, Windows.Foundation.IStringable, Windows.Web.Http.Headers.IHttpMediaTypeWithQualityHeaderValueCollection
-->

# Windows.Web.Http.Headers.HttpMediaTypeWithQualityHeaderValueCollection

## -description
Represents the value of the **Accept** HTTP header on an HTTP request.

## -remarks
The [HttpMediaTypeWithQualityHeaderValueCollection](httpmediatypewithqualityheadervaluecollection.md) represents the value of the **Accept** HTTP header on an HTTP request.

The [HttpMediaTypeWithQualityHeaderValueCollection](httpmediatypewithqualityheadervaluecollection.md) is a collection of [HttpMediaTypeWithQualityHeaderValue](httpmediatypewithqualityheadervalue.md) objects used for accept information in the HTTP **Accept** header.

The [Accept](httprequestheadercollection_accept.md) property on the [HttpRequestHeaderCollection](httprequestheadercollection.md) returns an [HttpMediaTypeWithQualityHeaderValueCollection](httpmediatypewithqualityheadervaluecollection.md) object.

## -examples
The following sample code shows a method to get and set the **Accept** HTTP header on an [HttpRequestMessage](../windows.web.http/httprequestmessage.md) object using the properties and methods on the [HttpMediaTypeWithQualityHeaderValueCollection](httpmediatypewithqualityheadervaluecollection.md) and [HttpMediaTypeWithQualityHeaderValue](httpmediatypewithqualityheadervalue.md) classes.

```csharp
using System;
using Windows.Web.Http;
using Windows.Web.Http.Headers;

        public void DemonstrateHeaderRequestAccept()
        {
            var request = new HttpRequestMessage();
            bool parsedOk = false;

            // Set the header with a string.
            parsedOk = request.Headers.Accept.TryParseAdd ("audio/*");
            parsedOk = request.Headers.Accept.TryParseAdd ("audio/*; q=0.2");
            parsedOk = request.Headers.Accept.TryParseAdd ("audio/*; q=0.4; mysetting=myvalue");

            // Set the header with a strong type.
            request.Headers.Accept.Add(new HttpMediaTypeWithQualityHeaderValue("audio/*", .6));

            // Get the strong type out
            foreach (var value in request.Headers.Accept)
            {
                System.Diagnostics.Debug.WriteLine("One of the Accept values: {0}={1}", value.MediaType, value.Quality);
            }

            // The ToString() is useful for diagnostics, too.
            System.Diagnostics.Debug.WriteLine("The Accept ToString() results: {0}", request.Headers.Accept.ToString());
        }

```



## -see-also
[Accept](httprequestheadercollection_accept.md), [HttpMediaTypeWithQualityHeaderValue](httpmediatypewithqualityheadervalue.md), [HttpRequestHeaderCollection](httprequestheadercollection.md), [IIterable(HttpMediaTypeWithQualityHeaderValue)](../windows.foundation.collections/iiterable_1.md), [IStringable](../windows.foundation/istringable.md), [IVector(HttpMediaTypeWithQualityHeaderValue)](../windows.foundation.collections/ivector_1.md)