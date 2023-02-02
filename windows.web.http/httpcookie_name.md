---
-api-id: P:Windows.Web.Http.HttpCookie.Name
-api-type: winrt property
---

<!-- Property syntax
public string Name { get; }
-->

# Windows.Web.Http.HttpCookie.Name

## -description
Get the token that represents the [HttpCookie](httpcookie.md) name.

## -property-value
The token that represents the [HttpCookie](httpcookie.md) name.

## -remarks
The Name property must be set when [HttpCookie](httpcookie.md) is initialized by the constructor.

The Name of the [HttpCookie](httpcookie.md) can't be **null** (**Nothing** in Visual Basic).

The property should be a token as defined in [RFC 2616](https://tools.ietf.org/html/rfc2616) and [RFC 6265](https://tools.ietf.org/html/rfc6265).

The following characters are used as separators and can't be used in the cookie name: 
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


## -examples

## -see-also
