---
-api-id: M:Windows.Web.Http.HttpMultipartFormDataContent.#ctor(System.String)
-api-type: winrt method
---

<!-- Method syntax
public HttpMultipartFormDataContent(System.String boundary)
-->

# Windows.Web.Http.HttpMultipartFormDataContent.HttpMultipartFormDataContent

## -description
Initializes a new instance of the [HttpMultipartFormDataContent](httpmultipartformdatacontent.md) class with the specified boundary string.

## -parameters
### -param boundary
The boundary string for the multipart content.

## -remarks
Below are the exceptions that this function throws.

### E_INVALIDARG

The *boundary* parameter is **null** (**Nothing** in Visual Basic) or contains only white space characters or the boundary ends with a space character.

The length of the *boundary* parameter is greater than 70.

## -examples

## -see-also
