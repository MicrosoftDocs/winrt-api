---
-api-id: T:Windows.Web.Http.HttpMultipartFormDataContent
-api-type: winrt class
ms.custom: 19H1
---

<!-- Class syntax.
public class HttpMultipartFormDataContent : Windows.Foundation.Collections.IIterable<Windows.Web.Http.IHttpContent>, Windows.Foundation.IClosable, Windows.Foundation.IStringable, Windows.Web.Http.IHttpContent, Windows.Web.Http.IHttpMultipartFormDataContent
-->

# Windows.Web.Http.HttpMultipartFormDataContent

## -description
Provides HTTP content that uses the **multipart/form-data** MIME type.

## -remarks
<!--Begin NET note for IEnumerable support-->
### Enumerating the collection in C# or Microsoft Visual Basic

You can iterate through an HttpMultipartFormDataContent object in C# or Microsoft Visual Basic. In many cases, such as using **foreach** syntax, the compiler does this casting for you and you won't need to cast to `IEnumerable<IHttpContent>` explicitly. If you do need to cast explicitly, for example if you want to call [GetEnumerator](/dotnet/api/system.collections.ienumerable.getenumerator?view=dotnet-uwp-10.0&preserve-view=true), cast to [IEnumerable&lt;T&gt;](/dotnet/api/system.collections.generic.ienumerable-1?view=dotnet-uwp-10.0&preserve-view=true with an [IHttpContent](ihttpcontent.md) constraint.


<!--End NET note for IEnumerable support-->

## -examples

## -see-also
[IClosable](../windows.foundation/iclosable.md), [IHttpContent](ihttpcontent.md), [IIterable(IHttpContent)](../windows.foundation.collections/iiterable_1.md), [IStringable](../windows.foundation/istringable.md)
