---
-api-id: T:Windows.Web.Http.Headers.HttpProductInfoHeaderValue
-api-type: winrt class
---

<!-- Class syntax.
public class HttpProductInfoHeaderValue : Windows.Foundation.IStringable, Windows.Web.Http.Headers.IHttpProductInfoHeaderValue
-->

# Windows.Web.Http.Headers.HttpProductInfoHeaderValue

## -description
Represents product information used in the **User-Agent** HTTP header on an HTTP request.

## -remarks
The [HttpProductInfoHeaderValue](httpproductinfoheadervalue.md) class represents product information used in the **User-Agent** HTTP header on an HTTP request.

The **User-Agent** header contains information about the user agent originating the request. The **User-Agent** header can contain multiple product tokens, each followed by optional comments which together identify the user agent and any sub-products. By convention, the product identifiers are listed in decreasing order of their significance for identifying the user agent software. Each product identifier consists of a name and optional version.

Each instance of the [HttpProductInfoHeaderValue](httpproductinfoheadervalue.md) contains either a value for the [Product](httpproductinfoheadervalue_product.md) or [Comment](httpproductinfoheadervalue_comment.md) property, but not both simultaneously.

The [UserAgent](httprequestheadercollection_useragent.md) property on the [HttpRequestHeaderCollection](httprequestheadercollection.md) returns an [HttpProductInfoHeaderValueCollection](httpproductinfoheadervaluecollection.md) that contains [HttpProductInfoHeaderValue](httpproductinfoheadervalue.md) objects.

## -examples

## -see-also
[HttpProductInfoHeaderValueCollection](httpproductinfoheadervaluecollection.md), [HttpRequestHeaderCollection](httprequestheadercollection.md), [IStringable](../windows.foundation/istringable.md), [UserAgent](httprequestheadercollection_useragent.md)