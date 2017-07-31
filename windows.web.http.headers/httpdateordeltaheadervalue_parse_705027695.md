---
-api-id: M:Windows.Web.Http.Headers.HttpDateOrDeltaHeaderValue.Parse(System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Web.Http.Headers.HttpDateOrDeltaHeaderValue Parse(System.String input)
-->

# Windows.Web.Http.Headers.HttpDateOrDeltaHeaderValue.Parse

## -description
Converts a string to an [HttpDateOrDeltaHeaderValue](httpdateordeltaheadervalue.md) instance.

## -parameters
### -param input
A string that represents the **HTTP-date** or **delta-seconds** information in the **Retry-After** HTTP header.

## -returns
An [HttpDateOrDeltaHeaderValue](httpdateordeltaheadervalue.md) instance.

## -remarks
Below are the exceptions that this function throws.

### E_INVALIDARG

The *input* parameter is **null** (**Nothing** in Visual Basic).

The *input* parameter is not valid **HTTP-date** or **delta-seconds** information.

## -examples

## -see-also
