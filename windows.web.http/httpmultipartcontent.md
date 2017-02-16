---
-api-id: T:Windows.Web.Http.HttpMultipartContent
-api-type: winrt class
---

<!-- Class syntax.
public class HttpMultipartContent : Windows.Foundation.Collections.IIterable<Windows.Web.Http.IHttpContent>, Windows.Foundation.IClosable, Windows.Foundation.IStringable, Windows.Web.Http.IHttpContent, Windows.Web.Http.IHttpMultipartContent
-->

# Windows.Web.Http.HttpMultipartContent

## -description
Provides HTTP content that uses the **multipart/*** MIME type.

## -remarks
<!--Begin NET note for IEnumerable support-->
### Enumerating the collection in C# or Microsoft Visual Basic

You can iterate through an [HttpMultipartContent](httpmultipartcontent.md) object in C# or Microsoft Visual Basic. In many cases, such as using **foreach** syntax, the compiler does this casting for you and you won't need to cast to `IEnumerable<IHttpContent>` explicitly. If you do need to cast explicitly, for example if you want to call [GetEnumerator](XREF:TODO:M:System.Collections.Generic.IEnumerable`1.GetEnumerator), cast to [IEnumerable&lt;T&gt;](XREF:TODO:T:System.Collections.Generic.IEnumerable`1) with an [IHttpContent](ihttpcontent.md) constraint.


<!--End NET note for IEnumerable support-->

## -examples

## -see-also
[IClosable](../windows.foundation/iclosable.md), [IHttpContent](ihttpcontent.md), [IIterable(IHttpContent)](../windows.foundation.collections/iiterable_1.md), [IStringable](../windows.foundation/istringable.md)