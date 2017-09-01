---
-api-id: T:Windows.Web.Http.HttpCookieCollection
-api-type: winrt class
---

<!-- Class syntax.
public class HttpCookieCollection : Windows.Foundation.Collections.IIterable<Windows.Web.Http.HttpCookie>, Windows.Foundation.Collections.IVectorView<Windows.Web.Http.HttpCookie>
-->

# Windows.Web.Http.HttpCookieCollection

## -description
Provides a collection container for instances of the [HttpCookie](httpcookie.md) class.

## -remarks
The [GetCookies](httpcookiemanager_getcookies.md) method on [HttpCookieManager](httpcookiemanager.md) returns an [HttpCookieCollection](httpcookiecollection.md) object. This is the method that an [HttpCookieCollection](httpcookiecollection.md) is constructed.


<!--Begin NET note for IEnumerable support-->
### Enumerating the collection in C# or Microsoft Visual Basic

[HttpCookieCollection](httpcookiecollection.md) is enumerable, so you can use language-specific syntax such as **foreach** in C# to enumerate the items in the collection. The compiler does the type-casting for you and you won't need to cast to `IEnumerable<HttpCookie>` explicitly. If you do need to cast explicitly, for example if you want to call [GetEnumerator](https://docs.microsoft.com/en-us/dotnet/api/system.collections.ienumerable.getenumerator), cast to [IEnumerable<T>](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1) with an [HttpCookie](httpcookie.md) constraint.


<!--End NET note for IEnumerable support-->

## -examples

## -see-also
[GetCookies](httpcookiemanager_getcookies.md), [HttpCookie](httpcookie.md), [HttpCookieManager](httpcookiemanager.md), [IVectorView(HttpCookie)](../windows.foundation.collections/ivectorview_1.md), [IIterable(HttpCookie)](../windows.foundation.collections/iiterable_1.md)