---
-api-id: T:Windows.Web.Http.Headers.HttpRequestHeaderCollection
-api-type: winrt class
---

<!-- Class syntax.
public class HttpRequestHeaderCollection : Windows.Foundation.Collections.IIterable<Windows.Foundation.Collections.IKeyValuePair<System.String, System.String>>, Windows.Foundation.Collections.IMap<System.String, System.String>, Windows.Foundation.IStringable, Windows.Web.Http.Headers.IHttpRequestHeaderCollection
-->

# Windows.Web.Http.Headers.HttpRequestHeaderCollection

## -description
Provides a collection of the HTTP headers associated with an HTTP request.

## -remarks
The HttpRequestHeaderCollection is a collection of the HTTP headers associated with an HTTP request. The HttpRequestHeaderCollection object can be used to get or set the specific headers on an HTTP request. Most of the properties on the HttpRequestHeaderCollection object provide access to the value of a specific HTTP header.

The [Headers](../windows.web.http/httprequestmessage_headers.md) property on [HttpRequestMessage](../windows.web.http/httprequestmessage.md) returns an HttpRequestHeaderCollection object. The [DefaultRequestHeaders](../windows.web.http/httpclient_defaultrequestheaders.md) property on [HttpClient](../windows.web.http/httpclient.md) also returns an HttpRequestHeaderCollection object. These are the two methods to construct an HttpRequestHeaderCollection object.

The HttpRequestHeaderCollection represents HTTP headers on an HTTP request that an app developer can set, not all of the headers that may eventually be sent with the request. The [HttpBaseProtocolFilter](../windows.web.http.filters/httpbaseprotocolfilter.md) will add some additional headers.

Headers on an HTTP request can be changed by the underlying stack. This would be why an app might want to get a header value from the HttpRequestHeaderCollection after the request has completed.


<!--Begin NET note for IEnumerable support-->
### Enumerating the collection in C# or Microsoft Visual Basic

You can iterate through an HttpRequestHeaderCollection object in C# or Microsoft Visual Basic. In many cases, such as using **foreach** syntax, the compiler does this casting for you and you won't need to cast to `IEnumerable` explicitly. If you do need to cast explicitly, for example if you want to call [GetEnumerator](/dotnet/api/system.collections.ienumerable.getenumerator?view=dotnet-uwp-10.0&preserve-view=true), cast the collection object to [IEnumerable&lt;T&gt;](/dotnet/api/system.collections.generic.ienumerable-1?view=dotnet-uwp-10.0&preserve-view=true) with a [KeyValuePair](/dotnet/api/system.collections.generic.keyvaluepair-2?view=dotnet-uwp-10.0&preserve-view=true) of [String](/dotnet/api/system.string?view=dotnet-uwp-10.0&preserve-view=true) and [String](/dotnet/api/system.string?view=dotnet-uwp-10.0&preserve-view=true) as the constraint.


<!--End NET note for IEnumerable support-->

## -examples
The following sample code shows a method to get and set request headers on an [HttpRequestMessage](../windows.web.http/httprequestmessage.md) object using the properties on the HttpRequestHeaderCollection object. The [Windows.Web.Http.Headers](windows_web_http_headers.md) namespace also has a number of strongly-typed header collection and value classes for specific HTTP headers that can be used to get and set headers with validation.

```csharp

using System;
using System.Collections.Generic;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Web.Http;
using Windows.Web.Http.Headers;

        public void DemonstrateHeaderRequest()
        {
            DemonstrateHeaderRequestAccept();
            DemonstrateHeaderRequestAcceptEncoding();
            DemonstrateHeaderRequestAcceptLanguage();
            DemonstrateHeaderRequestAuthorization();
            DemonstrateHeaderRequestCacheControl();
            DemonstrateHeaderRequestConnection();
            DemonstrateHeaderRequestCookie();
            DemonstrateHeaderRequestDate();
            DemonstrateHeaderRequestFrom();
            DemonstrateHeaderRequestHost();
            DemonstrateHeaderRequestIfModifiedSince();
            DemonstrateHeaderRequestIfUnmodifiedSince();
            DemonstrateHeaderRequestMaxForwards();
            DemonstrateHeaderRequestProxyAuthorization();
            DemonstrateHeaderRequestReferer();
            DemonstrateHeaderRequestUserAgent();
        }

        public void DemonstrateHeaderRequestAccept()
        {
            var request = new HttpRequestMessage();
            bool parsedOk = false;

            // Set the header with a string.
            parsedOk = request.Headers.Accept.TryParseAdd ("audio/*");
            parsedOk = request.Headers.Accept.TryParseAdd ("audio/*; q=0.2");
            parsedOk = request.Headers.Accept.TryParseAdd ("audio/*; q=0.4; mysetting=myvalue");

            // Set the header with a strong type.
            request.Headers.Accept.Add(new HttpMediaTypeWithQualityHeaderValue("audio/*", .6));

            // Get the strong type out
            foreach (var value in request.Headers.Accept)
            {
                System.Diagnostics.Debug.WriteLine("One of the Accept values: {0}={1}", value.MediaType, value.Quality);
            }

            // The ToString() is useful for diagnostics, too.
            System.Diagnostics.Debug.WriteLine("The Accept ToString() results: {0}", request.Headers.Accept.ToString());
        }

        public void DemonstrateHeaderRequestAcceptEncoding()
        {
            var request = new HttpRequestMessage();
            bool parsedOk = false;

            // Set the header with a string.
            parsedOk = request.Headers.AcceptEncoding.TryParseAdd("compress");
            parsedOk = request.Headers.AcceptEncoding.TryParseAdd("gzip;q=1.0");

            // Set the header with a strong type.
            request.Headers.AcceptEncoding.Add(new HttpContentCodingWithQualityHeaderValue("*", 0));

            // Get the strong type out
            foreach (var value in request.Headers.AcceptEncoding)
            {
                System.Diagnostics.Debug.WriteLine("One of the AcceptEncoding values: {0}={1}", value.ContentCoding, value.Quality);
            }

            // The ToString() is useful for diagnostics, too.
            System.Diagnostics.Debug.WriteLine("The AcceptEncoding ToString() results: {0}", request.Headers.AcceptEncoding.ToString());
        }

        public void DemonstrateHeaderRequestAcceptLanguage()
        {
            var request = new HttpRequestMessage();
            bool parsedOk = false;

            // Set the header with a string.
            parsedOk = request.Headers.AcceptLanguage.TryParseAdd("da");
            parsedOk = request.Headers.AcceptLanguage.TryParseAdd("en-gb;q=0.8");

            // Set the header with a strong type.
            request.Headers.AcceptLanguage.Add(new HttpLanguageRangeWithQualityHeaderValue("en", .7));

            // Get the strong type out
            foreach (var value in request.Headers.AcceptLanguage)
            {
                System.Diagnostics.Debug.WriteLine("One of the AcceptLanguage values: {0}={1}", value.LanguageRange, value.Quality);
            }

            // The ToString() is useful for diagnostics, too.
            System.Diagnostics.Debug.WriteLine("The AcceptLanguage ToString() results: {0}", request.Headers.AcceptLanguage.ToString());
        }

        public void DemonstrateHeaderRequestAuthorization()
        {
            var request = new HttpRequestMessage();

            // Set the header with a strong type.
            string username = "user";
            string password = "password";
            var buffer = Windows.Security.Cryptography.CryptographicBuffer.ConvertStringToBinary (username + ":" + password, Windows.Security.Cryptography.BinaryStringEncoding.Utf8);
            string base64token = Windows.Security.Cryptography.CryptographicBuffer.EncodeToBase64String(buffer);
            request.Headers.Authorization = new HttpCredentialsHeaderValue("Basic", base64token);


            // Get the strong type out
            System.Diagnostics.Debug.WriteLine("One of the Authorization values: {0}={1}", 
                request.Headers.Authorization.Scheme,
                request.Headers.Authorization.Token);

            // The ToString() is useful for diagnostics, too.
            System.Diagnostics.Debug.WriteLine("The Authorization ToString() results: {0}", request.Headers.Authorization.ToString());
        }

        public void DemonstrateHeaderRequestCacheControl()
        {
            var request = new HttpRequestMessage();
            bool parsedOk = false;

            // Set the header with a string.
            parsedOk = request.Headers.CacheControl.TryParseAdd("no-store");

            // Set the header with a strong type.
            request.Headers.CacheControl.Add(new HttpNameValueHeaderValue("max-age", "10"));

            // Get the strong type out
            foreach (var value in request.Headers.CacheControl)
            {
                System.Diagnostics.Debug.WriteLine("One of the CacheControl values: {0}={1}", value.Name, value.Value);
            }

            // The ToString() is useful for diagnostics, too.
            System.Diagnostics.Debug.WriteLine("The CacheControl ToString() results: {0}", request.Headers.CacheControl.ToString());
        }


        public void DemonstrateHeaderRequestConnection()
        {
            var request = new HttpRequestMessage();
            bool parsedOk = false;

            // Set the header with a string.
            parsedOk = request.Headers.Connection.TryParseAdd("close");

            // Set the header with a strong type.
            request.Headers.Connection.Add(new HttpConnectionOptionHeaderValue("cache-control"));

            // Get the strong type out
            foreach (var value in request.Headers.Connection)
            {
                System.Diagnostics.Debug.WriteLine("One of the Connection values: {0}", value.Token);
            }

            // The ToString() is useful for diagnostics, too.
            System.Diagnostics.Debug.WriteLine("The Connection ToString() results: {0}", request.Headers.Connection.ToString());
        }

        public void DemonstrateHeaderRequestCookie()
        {
            var request = new HttpRequestMessage();
            bool parsedOk = false;

            // Set the header with a string.
            parsedOk = request.Headers.Cookie.TryParseAdd("cookieName=cookieValue");

            // Set the header with a strong type.
            request.Headers.Cookie.Add(new HttpCookiePairHeaderValue("cookie2", "value2"));

            // Get the strong type out
            foreach (var value in request.Headers.Cookie)
            {
                System.Diagnostics.Debug.WriteLine("One of the Cookie values: {0}={1}", value.Name, value.Value);
            }

            // The ToString() is useful for diagnostics, too.
            System.Diagnostics.Debug.WriteLine("The Cookie ToString() results: {0}", request.Headers.Cookie.ToString());
        }


        public void DemonstrateHeaderRequestDate()
        {
            var request = new HttpRequestMessage();

            // This is not typically set with a string.

            // Set the header with a strong type.
            DateTimeOffset value = DateTimeOffset.UtcNow;
            request.Headers.Date = value;

            // Get the strong type out
            System.Diagnostics.Debug.WriteLine("Date value in ticks: {0}", request.Headers.Date.Value.Ticks);

            // The ToString() is useful for diagnostics, too.
            System.Diagnostics.Debug.WriteLine("The Date ToString() results: {0}", request.Headers.Date.ToString());
        }

        public void DemonstrateHeaderRequestFrom()
        {
            var request = new HttpRequestMessage();

            // Set the header with a string.
            request.Headers.From = "person@example.com";

            // Get the strong type out
            System.Diagnostics.Debug.WriteLine("From value: {0}", request.Headers.From);
        }

        public void DemonstrateHeaderRequestHost()
        {
            var request = new HttpRequestMessage();

            // This is not typically set with a string.

            // Set the header with a strong type.
            // HostName is in the Windows.Networking namespace.
            var value = new Windows.Networking.HostName("example.com");
            request.Headers.Host = value;

            // Get the strong type out
            System.Diagnostics.Debug.WriteLine("Canonical Host name: {0}", request.Headers.Host.CanonicalName);

            // The ToString() is useful for diagnostics, too.
            System.Diagnostics.Debug.WriteLine("The Host ToString() results: {0}", request.Headers.Host.ToString());
        }

        public void DemonstrateHeaderRequestIfModifiedSince()
        {
            var request = new HttpRequestMessage();

            // This is not typically set with a string.

            // Set the header with a strong type.
            var value = DateTimeOffset.Now.AddDays(-1); // Since yesterday.
            request.Headers.IfModifiedSince = value;

            // Get the strong type out
            System.Diagnostics.Debug.WriteLine("IfModifiedSince value in ticks: {0}", request.Headers.IfModifiedSince.Value.Ticks);

            // The ToString() is useful for diagnostics, too.
            System.Diagnostics.Debug.WriteLine("The IfModifiedSince ToString() results: {0}", request.Headers.IfModifiedSince.ToString());
        }

        public void DemonstrateHeaderRequestIfUnmodifiedSince()
        {
            var request = new HttpRequestMessage();

            // This is not typically set with a string.

            // Set the header with a strong type.
            var value = DateTimeOffset.Now.AddDays(-1); // Since yesterday.
            request.Headers.IfUnmodifiedSince = value;

            // Get the strong type out
            System.Diagnostics.Debug.WriteLine("IfUnmodifiedSince value in ticks: {0}", request.Headers.IfUnmodifiedSince.Value.Ticks);

            // The ToString() is useful for diagnostics, too.
            System.Diagnostics.Debug.WriteLine("The IfUnmodfiedSince ToString() results: {0}", request.Headers.IfUnmodifiedSince.ToString());
        }

        public void DemonstrateHeaderRequestMaxForwards()
        {
            var request = new HttpRequestMessage();

            // Set the header with an integer.
            request.Headers.MaxForwards= 2;

            // Get the strong type out
            System.Diagnostics.Debug.WriteLine("MaxForwards value: {0}", request.Headers.MaxForwards);
        }

        public void DemonstrateHeaderRequestProxyAuthorization()
        {
            var request = new HttpRequestMessage();

            // Set the header with a strong type.
            string username = "user";
            string password = "password";
            var buffer = Windows.Security.Cryptography.CryptographicBuffer.ConvertStringToBinary(username + ":" + password, Windows.Security.Cryptography.BinaryStringEncoding.Utf16LE);
            string base64token = Windows.Security.Cryptography.CryptographicBuffer.EncodeToBase64String(buffer);
            request.Headers.ProxyAuthorization = new HttpCredentialsHeaderValue("Basic", base64token);


            // Get the strong type out
            System.Diagnostics.Debug.WriteLine("One of the ProxyAuthorixation values: {0}={1}",
                request.Headers.ProxyAuthorization.Scheme,
                request.Headers.ProxyAuthorization.Token);

            // The ToString() is useful for diagnostics, too.
            System.Diagnostics.Debug.WriteLine("The ProxyAuthorization ToString() results: {0}", request.Headers.ProxyAuthorization.ToString());
        }


        public void DemonstrateHeaderRequestReferer()
        {
            var request = new HttpRequestMessage();

            // This is not typically set with a string.

            // Set the header with a strong type.
            // Uri is either in the Windows.Foundation namespace (JavaScript and C++)
            // or in the System.Net namespace (C#).
            var value = new Uri("http://example.com/");
            request.Headers.Referer = value;

            // Get the strong type out
            System.Diagnostics.Debug.WriteLine("Referer absolute uri: {0}", request.Headers.Referer.AbsoluteUri);

            // The ToString() is useful for diagnostics, too.
            System.Diagnostics.Debug.WriteLine("The Host ToString() results: {0}", request.Headers.Referer.ToString());
        }

        public void DemonstrateHeaderRequestUserAgent()
        {
            var request = new HttpRequestMessage();
            bool parsedOk = false;

            // Set the header with a string.
            parsedOk = request.Headers.UserAgent.TryParseAdd("testprogram/1.0");

            // Set the header with a strong type.
            request.Headers.UserAgent.Add(new HttpProductInfoHeaderValue("myprogram", "2.2"));

            // Get the strong type out
            foreach (var value in request.Headers.UserAgent)
            {
                System.Diagnostics.Debug.WriteLine("One of the UserAgent values: {0} / {1}", value.Product.Name, value.Product.Version);
            }

            // The ToString() is useful for diagnostics, too.
            System.Diagnostics.Debug.WriteLine("The UserAgent ToString() results: {0}", request.Headers.UserAgent.ToString());
        }


```



## -see-also
[DefaultRequestHeaders](../windows.web.http/httpclient_defaultrequestheaders.md), [Headers](../windows.web.http/httprequestmessage_headers.md), [HttpBaseProtocolFilter](../windows.web.http.filters/httpbaseprotocolfilter.md), [HttpClient](../windows.web.http/httpclient.md), [HttpRequestMessage](../windows.web.http/httprequestmessage.md), [IMap(String, String)](../windows.foundation.collections/imap_2.md), [IIterable(IKeyValuePair)](../windows.foundation.collections/iiterable_1.md), [IStringable](../windows.foundation/istringable.md)
