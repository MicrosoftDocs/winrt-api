---
-api-id: M:Windows.Web.Http.HttpMultipartFormDataContent.Add(Windows.Web.Http.IHttpContent,System.String,System.String)
-api-type: winrt method
---

<!-- Method syntax
public void Add(Windows.Web.Http.IHttpContent content, System.String name, System.String fileName)
-->

# Windows.Web.Http.HttpMultipartFormDataContent.Add

## -description
Add HTTP content with a specified name from a file to the [HttpMultipartFormDataContent](httpmultipartformdatacontent.md) instance.

## -parameters
### -param content
The HTTP content to add to [HttpMultipartFormDataContent](httpmultipartformdatacontent.md).

### -param name
The name for the HTTP content to add to [HttpMultipartFormDataContent](httpmultipartformdatacontent.md).

### -param fileName
The file name for the HTTP content to add to [HttpMultipartFormDataContent](httpmultipartformdatacontent.md).

## -exceptions
### E_INVALIDARG

The *content* parameter is **null** (**Nothing** in Visual Basic).

The *name* parameter is **null** (**Nothing** in Visual Basic) or contains only white space characters.

The *filename* parameter is **null** (**Nothing** in Visual Basic) or contains only white space characters.

## -remarks

## -examples

## -see-also
[Add(IHttpContent)](httpmultipartformdatacontent_add_1716566618.md), [Add(IHttpContent, String)](httpmultipartformdatacontent_add_715962342.md)