---
-api-id: T:Windows.Web.Http.Headers.HttpTransferCodingHeaderValueCollection
-api-type: winrt class
---

<!-- Class syntax.
public class HttpTransferCodingHeaderValueCollection : Windows.Foundation.Collections.IIterable<Windows.Web.Http.Headers.HttpTransferCodingHeaderValue>, Windows.Foundation.Collections.IVector<Windows.Web.Http.Headers.HttpTransferCodingHeaderValue>, Windows.Foundation.IStringable, Windows.Web.Http.Headers.IHttpTransferCodingHeaderValueCollection
-->

# Windows.Web.Http.Headers.HttpTransferCodingHeaderValueCollection

## -description
Represents the value of the **Transfer-Encoding** HTTP header on an HTTP request.

## -remarks
The [HttpTransferCodingHeaderValueCollection](httptransfercodingheadervaluecollection.md) represents the value of the **Transfer-Encoding** HTTP header on an HTTP request.

The [HttpTransferCodingHeaderValueCollection](httptransfercodingheadervaluecollection.md) is a collection of [HttpTransferCodingHeaderValue](httptransfercodingheadervalue.md) objects used for transfer coding information in the HTTP **Transfer-Encoding** header.

The [TransferEncoding](httprequestheadercollection_transferencoding.md) property on the [HttpRequestHeaderCollection](httprequestheadercollection.md) returns an [HttpTransferCodingHeaderValueCollection](httptransfercodingheadervaluecollection.md) object.

## -examples

## -see-also
[HttpRequestHeaderCollection](httprequestheadercollection.md), [HttpTransferCodingHeaderValue](httptransfercodingheadervalue.md), [IIterable(HttpTransferCodingHeaderValue)](../windows.foundation.collections/iiterable_1.md), [IStringable](../windows.foundation/istringable.md), [IVector(HttpTransferCodingHeaderValue)](../windows.foundation.collections/ivector_1.md), [TransferEncoding](httprequestheadercollection_transferencoding.md)