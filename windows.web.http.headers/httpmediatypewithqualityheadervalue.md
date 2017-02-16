---
-api-id: T:Windows.Web.Http.Headers.HttpMediaTypeWithQualityHeaderValue
-api-type: winrt class
---

<!-- Class syntax.
public class HttpMediaTypeWithQualityHeaderValue : Windows.Foundation.IStringable, Windows.Web.Http.Headers.IHttpMediaTypeWithQualityHeaderValue
-->

# Windows.Web.Http.Headers.HttpMediaTypeWithQualityHeaderValue

## -description
Represents accept information used in the **Accept** HTTP header on an HTTP request.

## -remarks
The [HttpMediaTypeWithQualityHeaderValue](httpmediatypewithqualityheadervalue.md) class represents accept information used in the **Accept** HTTP header on an HTTP request.

The [Accept](httprequestheadercollection_accept.md) property on the [HttpRequestHeaderCollection](httprequestheadercollection.md) returns an [HttpMediaTypeWithQualityHeaderValueCollection](httpmediatypewithqualityheadervaluecollection.md) that contains [HttpMediaTypeWithQualityHeaderValue](httpmediatypewithqualityheadervalue.md) objects.

The [Quality](httpmediatypewithqualityheadervalue_quality.md) property represents the quality factor that allows the user agent to indicate the relative degree of preference for the media type in a header. [Quality](httpmediatypewithqualityheadervalue_quality.md) uses a scale from 0 to 1. The default value is q=1.

## -examples

## -see-also
[Accept](httprequestheadercollection_accept.md), [HttpMediaTypeWithQualityHeaderValueCollection](httpmediatypewithqualityheadervaluecollection.md), [HttpRequestHeaderCollection](httprequestheadercollection.md), [IStringable](../windows.foundation/istringable.md)