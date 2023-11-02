---
-api-id: M:Windows.Web.Http.HttpCookie.#ctor(System.String,System.String,System.String)
-api-type: winrt method
---

<!-- Method syntax
public HttpCookie(System.String name, System.String domain, System.String path)
-->

# Windows.Web.Http.HttpCookie.HttpCookie

## -description
Initializes a new instance of the [HttpCookie](httpcookie.md) class with a specified name, domain, and path.

## -parameters
### -param name
The name for the [HttpCookie](httpcookie.md)

### -param domain
The domain for which the [HttpCookie](httpcookie.md) is valid.

### -param path
The URIs to which the [HttpCookie](httpcookie.md) applies.

## -remarks
The *name* parameter of the [HttpCookie](httpcookie.md) can't be set to **null** (**Nothing** in Visual Basic).

The property should be a token as defined in [RFC 2616](https://tools.ietf.org/html/rfc2616) and [RFC 6265](https://tools.ietf.org/html/rfc6265).

The following characters are used as separators and can't be used in the *name* parameter: 
+ left paren ('(')
+ right paren (')')
+ greater than ('&gt;')
+ less than ('&lt;')
+ at sign ('@')
+ comma (',')
+ semicolon (';')
+ colon (':')
+ backslash ('\\')
+ double quote ('"')
+ forward slash ('/')
+ left square bracket ('[')
+ right square bracket (']')
+ question mark ('?')
+ equal sign ('=')
+ left squiggly bracket ('{')
+ right squiggly bracket ('}')
+ new line ('\n')
+ return ('\r")
+ space (' ')
+ tab ('\t")


The *domain * parameter specifies those hosts to which the [HttpCookie](httpcookie.md) will be sent. A cookie with a *domain * parameter of `.contoso.com` will be sent to the `contoso.com` domain and all subdomains (`www.contoso.com` and `info.contoso.com`, for example).

A cookie with a *domain * parameter of `info.contoso.com` will not be sent to `contoso.com` or `www.contoso.com`, but will be sent to `info.contoso.com` and all subdomains (`uk.info.contoso.com` and `us.info.contoso.com`, for example).

If the *domain* parameter is not specified, then the [HttpCookie](httpcookie.md) will be sent only to the host and subdomains of the host that this cookie was received from.

The *path* parameter specifies the subset of paths on the origin server to which this [HttpCookie](httpcookie.md) applies. If this parameter is not specified, the default path matches any path and the [HttpCookie](httpcookie.md) will be sent on all HTTP requests to the *domain * parameter specified and all subdomains.

## -examples

## -see-also
