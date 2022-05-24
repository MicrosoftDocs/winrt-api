---
-api-id: T:Windows.Web.Http.Headers.HttpConnectionOptionHeaderValueCollection
-api-type: winrt class
---

<!-- Class syntax.
public class HttpConnectionOptionHeaderValueCollection : Windows.Foundation.Collections.IIterable<Windows.Web.Http.Headers.HttpConnectionOptionHeaderValue>, Windows.Foundation.Collections.IVector<Windows.Web.Http.Headers.HttpConnectionOptionHeaderValue>, Windows.Foundation.IStringable, Windows.Web.Http.Headers.IHttpConnectionOptionHeaderValueCollection
-->

# Windows.Web.Http.Headers.HttpConnectionOptionHeaderValueCollection

## -description
Represents the value of the **Connection** HTTP header on an HTTP request.

## -remarks
The HttpConnectionOptionHeaderValueCollection represents the value of the **Connection** HTTP header on an HTTP request.

The HttpConnectionOptionHeaderValueCollection is a collection of [HttpConnectionOptionHeaderValue](httpconnectionoptionheadervalue.md) objects used for connection information on the HTTP **Connection** header.

The [Connection](httprequestheadercollection_connection.md) property on the [HttpRequestHeaderCollection](httprequestheadercollection.md) returns an HttpConnectionOptionHeaderValueCollection object.

### Collection member lists

For JavaScript, HttpConnectionOptionHeaderValueCollection has the members shown in the member lists. In addition, HttpConnectionOptionHeaderValueCollection supports members of **Array.prototype** and using an index to access items.


<!--Begin NET note for IEnumerable support-->
### Enumerating the collection in C# or Microsoft Visual Basic

You can iterate through an HttpConnectionOptionHeaderValueCollection object in C# or Microsoft Visual Basic. In many cases, such as using **foreach** syntax, the compiler does this casting for you and you won't need to cast to `IEnumerable<HttpConnectionOptionHeaderValue>` explicitly. If you do need to cast explicitly, for example if you want to call [GetEnumerator](/dotnet/api/system.collections.ienumerable.getenumerator?view=dotnet-uwp-10.0&preserve-view=true), cast the collection object to [IEnumerable&lt;T&gt;](/dotnet/api/system.collections.generic.ienumerable-1?view=dotnet-uwp-10.0&preserve-view=true) with an [HttpConnectionOptionHeaderValue](httpconnectionoptionheadervalue.md) constraint.

## -examples
The following sample code shows a method to get and set the **Connection** HTTP header on an [HttpRequestMessage](../windows.web.http/httprequestmessage.md) object using the properties and methods on the HttpConnectionOptionHeaderValueCollection and [HttpConnectionOptionHeaderValue](httpconnectionoptionheadervalue.md) classes.

```csharp
using System;
using Windows.Web.Http;
using Windows.Web.Http.Headers;

        public void DemonstrateHeaderRequestConnection() {
            var request = new HttpRequestMessage();
            bool parsedOk = false;

            // Set the header with a string.
            parsedOk = request.Headers.Connection.TryParseAdd("close");

            // Set the header with a strong type.
            request.Headers.Connection.Add(new HttpConnectionOptionHeaderValue("cache-control"));

            // Get the strong type out
            foreach (var value in request.Headers.Connection) {
                System.Diagnostics.Debug.WriteLine("One of the Connection values: {0}", value.Token);
            }

            // The ToString() is useful for diagnostics, too.
            System.Diagnostics.Debug.WriteLine("The Connection ToString() results: {0}", request.Headers.Connection.ToString());
        }

```



## -see-also
[Connection](httprequestheadercollection_connection.md), [HttpConnectionOptionHeaderValue](httpconnectionoptionheadervalue.md), [HttpRequestHeaderCollection](httprequestheadercollection.md), [HttpRequestMessage](../windows.web.http/httprequestmessage.md), [IIterable(HttpConnectionOptionHeaderValue)](../windows.foundation.collections/iiterable_1.md), [IStringable](../windows.foundation/istringable.md), [IVector(HttpConnectionOptionHeaderValue)](../windows.foundation.collections/ivector_1.md)
