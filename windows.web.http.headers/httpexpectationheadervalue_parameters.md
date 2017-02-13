---
-api-id: P:Windows.Web.Http.Headers.HttpExpectationHeaderValue.Parameters
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Collections.IVector<Windows.Web.Http.Headers.HttpNameValueHeaderValue> Parameters { get; }
-->

# Windows.Web.Http.Headers.HttpExpectationHeaderValue.Parameters

## -description
Gets a set of parameters for a server behavior included in the **Expect** HTTP header.

## -property-value
A set of parameters for a server behavior.

## -remarks
A given server behavior might not allow parameters and the [Parameters](httpexpectationheadervalue_parameters.md) property would be an empty list. For example, **100-continue** is never used with parameters.

## -examples

## -see-also
