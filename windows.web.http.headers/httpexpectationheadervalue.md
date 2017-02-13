---
-api-id: T:Windows.Web.Http.Headers.HttpExpectationHeaderValue
-api-type: winrt class
---

<!-- Class syntax.
public class HttpExpectationHeaderValue : Windows.Foundation.IStringable, Windows.Web.Http.Headers.IHttpExpectationHeaderValue
-->

# Windows.Web.Http.Headers.HttpExpectationHeaderValue

## -description
Represents a token for a particular server behavior required by the client that is used in the **Expect** HTTP header on an HTTP request.

## -remarks
The [HttpExpectationHeaderValue](httpexpectationheadervalue.md) class is a token that represents a particular server behavior that is required by the client. The [HttpExpectationHeaderValue](httpexpectationheadervalue.md) is used in the **Expect** HTTP header on an HTTP request.

For example, **100-continue** is a server behavior that the client might depend on and set using the [HttpExpectationHeaderValue](httpexpectationheadervalue.md) class.

The [Expect](httprequestheadercollection_expect.md) property on the [HttpRequestHeaderCollection](httprequestheadercollection.md) returns an [HttpExpectationHeaderValueCollection](httpexpectationheadervaluecollection.md) that contains [HttpExpectationHeaderValue](httpexpectationheadervalue.md) objects.

## -examples

## -see-also
[Expect](httprequestheadercollection_expect.md), [HttpExpectationHeaderValueCollection](httpexpectationheadervaluecollection.md), [HttpRequestHeaderCollection](httprequestheadercollection.md), [IStringable](../windows.foundation/istringable.md)