---
-api-id: T:Windows.Web.Http.Headers.HttpResponseHeaderCollection
-api-type: winrt class
---

<!-- Class syntax.
public class HttpResponseHeaderCollection : Windows.Foundation.Collections.IIterable<Windows.Foundation.Collections.IKeyValuePair<System.String, System.String>>, Windows.Foundation.Collections.IMap<System.String, System.String>, Windows.Foundation.IStringable, Windows.Web.Http.Headers.IHttpResponseHeaderCollection
-->

# Windows.Web.Http.Headers.HttpResponseHeaderCollection

## -description
Provides a collection of the HTTP headers associated with an HTTP response.

## -remarks
The HttpResponseHeaderCollection is a collection of the HTTP headers associated with an HTTP response to an HTTP request message. The HttpResponseHeaderCollection object can be used to get or set the specific headers on the HTTP response. Most of the properties on the HttpResponseHeaderCollection object provide access for the value of a specific HTTP header.

The [Headers](../windows.web.http/httpresponsemessage_headers.md) property on [HttpResponseMessage](../windows.web.http/httpresponsemessage.md) returns an HttpResponseHeaderCollection object. This is how an HttpResponseHeaderCollection is constructed.


<!--Begin NET note for IEnumerable support-->
### Enumerating the collection in C# or Microsoft Visual Basic

You can iterate through an HttpResponseHeaderCollection object in C# or Microsoft Visual Basic. In many cases, such as using **foreach** syntax, the compiler does this casting for you and you won't need to cast to `IEnumerable` explicitly. If you do need to cast explicitly, for example if you want to call [GetEnumerator](/dotnet/api/system.collections.ienumerable.getenumerator?view=dotnet-uwp-10.0&preserve-view=true), cast the collection object to [IEnumerable&lt;T&gt;](/dotnet/api/system.collections.generic.ienumerable-1?view=dotnet-uwp-10.0&preserve-view=true) with a [KeyValuePair](/dotnet/api/system.collections.generic.keyvaluepair-2?view=dotnet-uwp-10.0&preserve-view=true) of [String](/dotnet/api/system.string?view=dotnet-uwp-10.0&preserve-view=true) and [String](/dotnet/api/system.string?view=dotnet-uwp-10.0&preserve-view=true) as the constraint.


<!--End NET note for IEnumerable support-->

## -examples
The following sample code shows a method to get and set response headers on an [HttpResponseMessage](../windows.web.http/httpresponsemessage.md) object using the properties on the HttpResponseHeaderCollection object. The [Windows.Web.Http.Headers](windows_web_http_headers.md) namespace has a number of strongly-typed header collection and value classes for specific HTTP headers that can be used to get and set headers with validation.

```csharp

using System;
using System.Collections.Generic;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Web.Http;
using Windows.Web.Http.Headers;

        void DemonstrateResponseHeaders() {

            DemonstrateHeaderResponseAge();
            DemonstrateHeaderResponseAllow();
            DemonstrateHeaderResponseCacheControl();
            DemonstrateHeaderResponseDate();
            DemonstrateHeaderResponseLocation();
            DemonstrateHeaderResponseProxyAuthenticate();

        }


        public void DemonstrateHeaderResponseAge()
        {
            var response = new HttpResponseMessage();

            // Set the header with a strong type.
            DateTimeOffset value = DateTimeOffset.UtcNow;
            response.Headers.Age = new TimeSpan(1, 35, 55); // 1 hour, 35 minutes, 55 seconds.

            // Get the strong type out
            System.Diagnostics.Debug.WriteLine("Age value in minutes: {0}", response.Headers.Age.Value.TotalMinutes);

            // The ToString() is useful for diagnostics, too.
            System.Diagnostics.Debug.WriteLine("The Age ToString() results: {0}", response.Headers.Age.ToString());
        }


        public void DemonstrateHeaderResponseAllow()
        {
            var response = new HttpResponseMessage();

            // Set the header with a string
            response.Headers.Allow.TryParseAdd ("GET");

            // Set the header with a strong type
            response.Headers.Allow.Add(HttpMethod.Patch);

            // Get the strong type out
            foreach (var value in response.Headers.Allow)
            {
                System.Diagnostics.Debug.WriteLine("Allow value: {0}", value.Method);
            }

            // The ToString() is useful for diagnostics, too.
            System.Diagnostics.Debug.WriteLine("The Allow ToString() results: {0}", response.Headers.Allow.ToString());
        }

        public void DemonstrateHeaderResponseCacheControl()
        {
            var response = new HttpResponseMessage();

            // Set the header with a string
            response.Headers.CacheControl.TryParseAdd("public");

            // Set the header with a strong type
            response.Headers.CacheControl.Add(new HttpNameValueHeaderValue("max-age", "30"));

            // Get the strong type out
            foreach (var value in response.Headers.CacheControl)
            {
                System.Diagnostics.Debug.WriteLine("CacheControl {0}={1}", value.Name, value.Value);
            }

            // The ToString() is useful for diagnostics, too.
            System.Diagnostics.Debug.WriteLine("The CacheControl ToString() results: {0}", response.Headers.CacheControl.ToString());
        }

        public void DemonstrateHeaderResponseDate()
        {
            var response = new HttpResponseMessage();

            // Set the header with a strong type.
            response.Headers.Date = DateTimeOffset.UtcNow;

            // Get the strong type out
            System.Diagnostics.Debug.WriteLine("Date value in ticks: {0}", response.Headers.Date.Value.Ticks);

            // The ToString() is useful for diagnostics, too.
            System.Diagnostics.Debug.WriteLine("The Date ToString() results: {0}", response.Headers.Date.ToString());
        }

        public void DemonstrateHeaderResponseLocation()
        {
            var response = new HttpResponseMessage();

            // Set the header with a strong type.
            response.Headers.Location = new Uri("http://example.com/");

            // Get the strong type out
            System.Diagnostics.Debug.WriteLine("Location absolute uri: {0}", response.Headers.Location.AbsoluteUri);

            // The ToString() is useful for diagnostics, too.
            System.Diagnostics.Debug.WriteLine("The Location ToString() results: {0}", response.Headers.Location.ToString());
        }

        public void DemonstrateHeaderResponseProxyAuthenticate()
        {
            var response = new HttpResponseMessage();

            // Set the header with a strong type.
            response.Headers.ProxyAuthenticate.TryParseAdd("Basic");
            response.Headers.ProxyAuthenticate.Add(new HttpChallengeHeaderValue("authScheme", "authToken"));

            // Get the strong type out
            foreach (var value in response.Headers.ProxyAuthenticate)
            {
                System.Diagnostics.Debug.WriteLine("Proxy authenticate scheme and token: {0} {1}", value.Scheme, value.Token);
            }

            // The ToString() is useful for diagnostics, too.
            System.Diagnostics.Debug.WriteLine("The ProxyAuthenticate ToString() results: {0}", response.Headers.ProxyAuthenticate.ToString());
        }

        public void DemonstrateHeaderResponseRetryAfter()
        {
            var response = new HttpResponseMessage();

            // Set the header with a strong type.
            HttpDateOrDeltaHeaderValue newvalue;
            bool parseOk = HttpDateOrDeltaHeaderValue.TryParse("", out newvalue);
            if (parseOk)
            {
                response.Headers.RetryAfter = newvalue;
            }

            // Get the strong type out
            System.Diagnostics.Debug.WriteLine("Date value in ticks: {0}", response.Headers.Date.Value.Ticks);

            // The ToString() is useful for diagnostics, too.
            System.Diagnostics.Debug.WriteLine("The Date ToString() results: {0}", response.Headers.Date.ToString());
        }
        

```



## -see-also
[HttpResponseMessage](../windows.web.http/httpresponsemessage.md), [HttpResponseMessage.Headers](../windows.web.http/httpresponsemessage_headers.md), [IMap(String, String)](../windows.foundation.collections/imap_2.md), [IIterable(IKeyValuePair)](../windows.foundation.collections/iiterable_1.md), [IStringable](../windows.foundation/istringable.md)
