---
-api-id: P:Windows.Web.Http.Headers.HttpCredentialsHeaderValue.Parameters
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Collections.IVector<Windows.Web.Http.Headers.HttpNameValueHeaderValue> Parameters { get; }
-->

# Windows.Web.Http.Headers.HttpCredentialsHeaderValue.Parameters

## -description
Gets a set of name/value pairs included in the **Authorization** or **Proxy-Authorization** HTTP header.

## -property-value
A set of name/value pairs.

## -remarks
The [Parameters](httpcredentialsheadervalue_parameters.md) property gets a set of name/value pairs of the credentials containing the authentication information of the user agent for the resource being requested.

An [HttpCredentialsHeaderValue](httpcredentialsheadervalue.md) object has a [Scheme](httpcredentialsheadervalue_scheme.md) and either a [Token](httpcredentialsheadervalue_token.md) or a [Parameters](httpcredentialsheadervalue_parameters.md) list. So either the [Parameters](httpcredentialsheadervalue_parameters.md) property is an empty collection or the [Token](httpcredentialsheadervalue_token.md) property is an empty string.

## -examples

## -see-also
