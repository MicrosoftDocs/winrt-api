---
-api-id: T:Windows.Web.Http.Headers.HttpLanguageRangeWithQualityHeaderValueCollection
-api-type: winrt class
---

<!-- Class syntax.
public class HttpLanguageRangeWithQualityHeaderValueCollection : Windows.Foundation.Collections.IIterable<Windows.Web.Http.Headers.HttpLanguageRangeWithQualityHeaderValue>, Windows.Foundation.Collections.IVector<Windows.Web.Http.Headers.HttpLanguageRangeWithQualityHeaderValue>, Windows.Foundation.IStringable, Windows.Web.Http.Headers.IHttpLanguageRangeWithQualityHeaderValueCollection
-->

# Windows.Web.Http.Headers.HttpLanguageRangeWithQualityHeaderValueCollection

## -description
Represents the value of the **Accept-Language** HTTP header on an HTTP request.

## -remarks
The [HttpLanguageRangeWithQualityHeaderValueCollection](httplanguagerangewithqualityheadervaluecollection.md) class represents the value of the **Accept-Language** HTTP header on an HTTP request.

The [HttpLanguageRangeWithQualityHeaderValueCollection](httplanguagerangewithqualityheadervaluecollection.md) provides a collection container for instances of the [HttpLanguageRangeWithQualityHeaderValue](httplanguagerangewithqualityheadervalue.md) class used for accept language information in the **Accept-Language** HTTP header.

The [AcceptLanguage](httprequestheadercollection_acceptlanguage.md) property on the [HttpRequestHeaderCollection](httprequestheadercollection.md) returns an [HttpLanguageRangeWithQualityHeaderValueCollection](httplanguagerangewithqualityheadervaluecollection.md) object.

## -examples
The following sample code shows a method to get and set the **Accept-Language** HTTP header on an [HttpRequestMessage](../windows.web.http/httprequestmessage.md) object using the properties and methods on the [HttpLanguageRangeWithQualityHeaderValueCollection](httplanguagerangewithqualityheadervaluecollection.md) and [HttpLanguageRangeWithQualityHeaderValue](httplanguagerangewithqualityheadervalue.md) classes.

```csharp
using System;
using Windows.Web.Http;
using Windows.Web.Http.Headers;

        public void DemonstrateHeaderRequestAcceptLanguage() {
            var request = new HttpRequestMessage();
            bool parsedOk = false;

            // Set the header with a string.
            parsedOk = request.Headers.AcceptLanguage.TryParseAdd("da");
            parsedOk = request.Headers.AcceptLanguage.TryParseAdd("en-gb;q=0.8");

            // Set the header with a strong type.
            request.Headers.AcceptLanguage.Add(new HttpLanguageRangeWithQualityHeaderValue("en", .7));

            // Get the strong type out
            foreach (var value in request.Headers.AcceptLanguage) {
                System.Diagnostics.Debug.WriteLine("One of the AcceptLanguage values: {0}={1}", value.LanguageRange, value.Quality);
            }

            // The ToString() is useful for diagnostics, too.
            System.Diagnostics.Debug.WriteLine("The AcceptLanguage ToString() results: {0}", request.Headers.AcceptLanguage.ToString());
        }

```



## -see-also
[AcceptLanguage](httprequestheadercollection_acceptlanguage.md), [HttpLanguageRangeWithQualityHeaderValue](httplanguagerangewithqualityheadervalue.md), [HttpRequestHeaderCollection](httprequestheadercollection.md), [IIterable(HttpLanguageRangeWithQualityHeaderValue)](../windows.foundation.collections/iiterable_1.md), [IStringable](../windows.foundation/istringable.md), [IVector(HttpLanguageRangeWithQualityHeaderValue)](../windows.foundation.collections/ivector_1.md)