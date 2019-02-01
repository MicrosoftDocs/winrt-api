---
-api-id: P:Windows.Web.Http.Headers.HttpCredentialsHeaderValue.Scheme
-api-type: winrt property
---

<!-- Property syntax
public string Scheme { get; }
-->

# Windows.Web.Http.Headers.HttpCredentialsHeaderValue.Scheme

## -description
Gets the scheme to use for authentication.

## -property-value
The scheme to use for authentication.

## -remarks
The [Scheme](httpcredentialsheadervalue_scheme.md) property scheme to use for authentication of the user agent for the resource being requested.

An [HttpCredentialsHeaderValue](httpcredentialsheadervalue.md) object has a [Scheme](httpcredentialsheadervalue_scheme.md) and either a [Token](httpcredentialsheadervalue_token.md) or a [Parameters](httpcredentialsheadervalue_parameters.md) list. So either the [Parameters](httpcredentialsheadervalue_parameters.md) property is an empty collection or the [Token](httpcredentialsheadervalue_token.md) property is an empty string.

Each authentication scheme defines the syntax to use for authentication. Basic authentication, for example, uses base64 encoding of the **userid** and **passwd** elements in the [Token](httpcredentialsheadervalue_token.md) property. Digest authentication would use a [Parameters](httpcredentialsheadervalue_parameters.md) list of name/value pairs. Basic authentication and digest authentication are defined in IETF [RFC 2617](https://tools.ietf.org/html/rfc2617). Other schemes for authentication can be supported by the [HttpCredentialsHeaderValue](httpcredentialsheadervalue.md) class.

## -examples

## -see-also
