---
-api-id: P:Windows.Web.Http.Headers.HttpCredentialsHeaderValue.Token
-api-type: winrt property
---

<!-- Property syntax
public string Token { get; }
-->

# Windows.Web.Http.Headers.HttpCredentialsHeaderValue.Token

## -description
Gets the user token information used in the **Authorization** or **Proxy-Authorization** HTTP header.

## -property-value
The user token information in the **Authorization** or **Proxy-Authorization** HTTP header.

## -remarks
The [Token](httpcredentialsheadervalue_token.md) property gets a simple string with the credentials containing the authentication information of the user agent for the resource being requested.

An [HttpCredentialsHeaderValue](httpcredentialsheadervalue.md) object has a [Scheme](httpcredentialsheadervalue_scheme.md) and either a [Token](httpcredentialsheadervalue_token.md) or a [Parameters](httpcredentialsheadervalue_parameters.md) list. So either the [Parameters](httpcredentialsheadervalue_parameters.md) property is an empty collection or the [Token](httpcredentialsheadervalue_token.md) property is an empty string.

## -examples

## -see-also
