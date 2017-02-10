---
-api-id: M:Windows.Web.Http.HttpMultipartContent.#ctor(System.String,System.String)
-api-type: winrt method
---

<!-- Method syntax
public HttpMultipartContent(System.String subtype, System.String boundary)
-->

# Windows.Web.Http.HttpMultipartContent.HttpMultipartContent

## -description
Initializes a new instance of the [HttpMultipartContent](httpmultipartcontent.md) class with the specified MIME subtype and boundary string.

## -parameters
### -param subtype
The MIME subtype of the multipart content.

### -param boundary
The boundary string for the multipart content.

## -exceptions
### E_INVALIDARG

The *subtype* parameter is **null** (**Nothing** in Visual Basic).

The *boundary* parameter is **null** (**Nothing** in Visual Basic) or contains only white space characters or the boundary ends with a space character.

The length of the *boundary* parameter is greater than 70.

## -remarks

## -examples

## -see-also
[HttpMultipartContent(String)](httpmultipartcontent_httpmultipartcontent_290278668.md)