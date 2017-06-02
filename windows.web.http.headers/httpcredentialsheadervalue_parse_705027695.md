---
-api-id: M:Windows.Web.Http.Headers.HttpCredentialsHeaderValue.Parse(System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Web.Http.Headers.HttpCredentialsHeaderValue Parse(System.String input)
-->

# Windows.Web.Http.Headers.HttpCredentialsHeaderValue.Parse

## -description
Converts a string to an [HttpCredentialsHeaderValue](httpcredentialsheadervalue.md) instance.

## -parameters
### -param input
A string that represents the credential information in the **Authorization** or **Proxy-Authorization** HTTP header.

## -returns
An [HttpCredentialsHeaderValue](httpcredentialsheadervalue.md) instance.

## -remarks
Below are the exceptions that this function throws.

### E_INVALIDARG

The *input* parameter is **null** (**Nothing** in Visual Basic).

The *input* parameter is not valid credential information.

## -examples

## -see-also
