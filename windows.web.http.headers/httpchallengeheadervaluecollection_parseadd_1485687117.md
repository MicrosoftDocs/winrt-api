---
-api-id: M:Windows.Web.Http.Headers.HttpChallengeHeaderValueCollection.ParseAdd(System.String)
-api-type: winrt method
---

<!-- Method syntax
public void ParseAdd(System.String input)
-->

# Windows.Web.Http.Headers.HttpChallengeHeaderValueCollection.ParseAdd

## -description
Parses and adds an entry to the [HttpChallengeHeaderValueCollection](httpchallengeheadervaluecollection.md).

## -parameters
### -param input
The entry to add.

## -remarks
Below are exceptions that this function throws.

### E_INVALIDARG

The *input* parameter is **null** (**Nothing** in Visual Basic).

The *input* parameter is not a valid value for the **Proxy-Authenticate** or **WWW-Authenticate** HTTP header.

## -examples

## -see-also
[HttpChallengeHeaderValue](httpchallengeheadervalue.md)