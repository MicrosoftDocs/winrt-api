---
-api-id: T:Windows.Web.Http.Headers.HttpContentHeaderCollection
-api-type: winrt class
---

<!-- Class syntax.
public class HttpContentHeaderCollection : Windows.Foundation.Collections.IIterable<Windows.Foundation.Collections.IKeyValuePair<System.String, System.String>>, Windows.Foundation.Collections.IMap<System.String, System.String>, Windows.Foundation.IStringable, Windows.Web.Http.Headers.IHttpContentHeaderCollection
-->

# Windows.Web.Http.Headers.HttpContentHeaderCollection

## -description
Provides a collection of the HTTP headers associated with content on an HTTP request or response.

## -remarks
The **HttpContentHeaderCollection** is a collection of the HTTP headers associated with the HTTP content on an HTTP request or an HTTP response message. The **HttpContentHeaderCollection** object can be used to get or set the specific headers on the HTTP content. Most of the properties on the **HttpContentHeaderCollection** object provide access to a container collection for a specific HTTP header.

The **HttpContentHeaderCollection** has a constructor and also is returned by the  property on [HttpBufferContent](../windows.web.http/httpbuffercontent.md), [HttpFormUrlEncodedContent](../windows.web.http/httpformurlencodedcontent.md), [HttpMultipartContent](../windows.web.http/httpmultipartcontent.md), [HttpMultipartFormDataContent](../windows.web.http/httpmultipartformdatacontent.md), [HttpStreamContent](../windows.web.http/httpstreamcontent.md), and [HttpStringContent](../windows.web.http/httpstringcontent.md), classes and the [IHttpContent](../windows.web.http/ihttpcontent.md) interface.


<!--Begin NET note for IEnumerable support-->
### Enumerating the collection in C# or Microsoft Visual Basic

You can iterate through an **HttpContentHeaderCollection** object in C# or Microsoft Visual Basic. In many cases, such as using **foreach** syntax, the compiler does this casting for you and you won't need to cast to `IEnumerable` explicitly. If you do need to cast explicitly, for example if you want to call [GetEnumerator](/dotnet/api/system.collections.ienumerable.getenumerator?view=dotnet-uwp-10.0&preserve-view=true), cast the collection object to [IEnumerable&lt;T&gt;](/dotnet/api/system.collections.generic.ienumerable-1?view=dotnet-uwp-10.0&preserve-view=true) with a [KeyValuePair](/dotnet/api/system.collections.generic.keyvaluepair-2?view=dotnet-uwp-10.0&preserve-view=true) of [String](/dotnet/api/system.string?view=dotnet-uwp-10.0&preserve-view=true) and [String](/dotnet/api/system.string?view=dotnet-uwp-10.0&preserve-view=true) as the constraint.


<!--End NET note for IEnumerable support-->

## -examples
The following sample code shows a method to get and set headers on HTTP content using the properties on the **HttpContentHeaderCollection** object. The [Windows.Web.Http.Headers](windows_web_http_headers.md) namespace has a number of strongly-typed header collection and value classes for specific HTTP headers that can be used to get and set headers with validation.

```csharp
using System;
using Windows.Web.Http;
using Windows.Web.Http.Headers;

public void DemonstrateContentHeader()
{
    DemonstrateHeaderContentContentDisposition();
}

public void DemonstrateHeaderContentContentDisposition()
{
    var content = new HttpStringContent("");
    bool parsedOk = false;

    // Set the header with a string.
    HttpContentDispositionHeaderValue value;
    parsedOk = HttpContentDispositionHeaderValue.TryParse("attachment; filename=\"fname.ext\"", out value);
    content.Headers.ContentDisposition = value;

    // Set the header with a strong type.

    content.Headers.ContentDisposition = new HttpContentDispositionHeaderValue("attachment");
    content.Headers.ContentDisposition.FileName = "myfile.exe";


    // Get the strong type out
    System.Diagnostics.Debug.WriteLine("ContentDisposition filename: {0}={1}",
        content.Headers.ContentDisposition.DispositionType,
        content.Headers.ContentDisposition.FileName);

    // The ToString() is useful for diagnostics, too.
    System.Diagnostics.Debug.WriteLine("The ContentDisposition ToString() results: {0}", content.Headers.ContentDisposition.ToString());
}
```

## -see-also
[HttpBufferContent](../windows.web.http/httpbuffercontent.md), [HttpFormUrlEncodedContent](../windows.web.http/httpformurlencodedcontent.md), [HttpMultipartContent](../windows.web.http/httpmultipartcontent.md), [HttpMultipartFormDataContent](../windows.web.http/httpmultipartformdatacontent.md), [HttpRequestMessage](../windows.web.http/httprequestmessage.md), [HttpResponseMessage](../windows.web.http/httpresponsemessage.md), [HttpStreamContent](../windows.web.http/httpstreamcontent.md), [HttpStringContent](../windows.web.http/httpstringcontent.md), [IMap(String, String)](../windows.foundation.collections/imap_2.md), [IIterable(IKeyValuePair)](../windows.foundation.collections/iiterable_1.md), [IStringable](../windows.foundation/istringable.md)