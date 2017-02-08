---
-api-id: T:Windows.Web.Http.Headers.HttpCredentialsHeaderValue
-api-type: winrt class
---

<!-- Class syntax.
public class HttpCredentialsHeaderValue : Windows.Foundation.IStringable, Windows.Web.Http.Headers.IHttpCredentialsHeaderValue
-->

# Windows.Web.Http.Headers.HttpCredentialsHeaderValue

## -description
Represents the value of the **Authorization** or **Proxy-Authorization** HTTP header on an HTTP request.

## -remarks
The [HttpCredentialsHeaderValue](httpcredentialsheadervalue.md) class represents the **Authorization** or **Proxy-Authorization** HTTP header on an HTTP request.

The [Authorization](httprequestheadercollection_authorization.md) property on the [HttpRequestHeaderCollection](httprequestheadercollection.md) returns an [HttpCredentialsHeaderValue](httpcredentialsheadervalue.md) object that represents the **Authorization** HTTP header. The [ProxyAuthorization](httprequestheadercollection_proxyauthorization.md) property on the [HttpRequestHeaderCollection](httprequestheadercollection.md) returns an [HttpCredentialsHeaderValue](httpcredentialsheadervalue.md) object that represents the **Proxy-Authorization** HTTP header.

## -examples
The following sample code shows a method to get and set the **Authorization** HTTP header on an [HttpRequestMessage](../windows.web.http/httprequestmessage.md) object using the properties and methods on the [HttpCredentialsHeaderValue](httpcredentialsheadervalue.md) class.

```csharp
using System;
using Windows.Web.Http;
using Windows.Web.Http.Headers;

        public void DemonstrateHeaderRequestAuthorization() {
            var request = new HttpRequestMessage();

            // Set the header with a strong type.
            string username = "user";
            string password = "password";
            var buffer = Windows.Security.Cryptography.CryptographicBuffer.ConvertStringToBinary (username + ":" + password, Windows.Security.Cryptography.BinaryStringEncoding.Utf16LE);
            string base64token = Windows.Security.Cryptography.CryptographicBuffer.EncodeToBase64String(buffer);
            request.Headers.Authorization = new HttpCredentialsHeaderValue("Basic", base64token);


            // Get the strong type out
            System.Diagnostics.Debug.WriteLine("One of the Authorization values: {0}={1}", 
                request.Headers.Authorization.Scheme,
                request.Headers.Authorization.Token);

            // The ToString() is useful for diagnostics, too.
            System.Diagnostics.Debug.WriteLine("The Authorization ToString() results: {0}", request.Headers.Authorization.ToString());
        }

```

The following sample code shows a method to get and set the **Proxy-Authorization** HTTP header on an [HttpRequestMessage](../windows.web.http/httprequestmessage.md) object using the properties and methods on the [HttpCredentialsHeaderValue](httpcredentialsheadervalue.md) class.

```csharp
using System;
using Windows.Web.Http;
using Windows.Web.Http.Headers;

        public void DemonstrateHeaderRequestProxyAuthorization() {
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

```



## -see-also
[Authorization](httprequestheadercollection_authorization.md), [HttpRequestHeaderCollection](httprequestheadercollection.md), [IStringable](../windows.foundation/istringable.md), [ProxyAuthorization](httprequestheadercollection_proxyauthorization.md)