---
-api-id: T:Windows.Web.Http.HttpRequestMessage
-api-type: winrt class
---

<!-- Class syntax.
public class HttpRequestMessage : Windows.Foundation.IClosable, Windows.Foundation.IStringable, Windows.Web.Http.IHttpRequestMessage
-->

# Windows.Web.Http.HttpRequestMessage

## -description
Represents an HTTP request message including headers.

## -remarks
The [HttpRequestMessage](httprequestmessage.md) class contains headers, the HTTP verb, and potentially data. This class is commonly used by developers who need additional control over HTTP requests. Common examples include the following:
+ To examine the underlying SSL/TLS transport information.
+ To use a less-common HTTP method.
+ To explicitly set request properties on the [HttpRequestMessage](httprequestmessage.md).


In these cases, an app uses one of the [HttpRequestMessage](httpclient_httpclient_1221375020.md) constructors to create an [HttpRequestMessage](httprequestmessage.md) instance. The app sets various properties on the [HttpRequestMessage](httprequestmessage.md) as needed. Then the [HttpRequestMessage](httprequestmessage.md) is passed as a parameter to one of the [HttpClient.SendRequestAsync](httpclient_sendrequestasync_234300504.md) methods.

A number of convenience methods on the [HttpClient](httpclient.md) class automatically create an [HttpRequestMessage](httprequestmessage.md) object for the app. These methods include the following:
+ [DeleteAsync](httpclient_deleteasync_820543917.md).
+ The [GetAsync](httpclient_getasync_1105627628.md) methods.
+ [GetBufferAsync](httpclient_getbufferasync_894906839.md).
+ [GetInputStreamAsync](httpclient_getinputstreamasync_1910746187.md).
+ [GetStringAsync](httpclient_getstringasync_149346728.md).
+ [PostAsync](httpclient_postasync_1466488101.md).
+ [PutAsync](httpclient_putasync_552115331.md).


Any filters that you add to the filter pipeline will be passed the [HttpRequestMessage](httprequestmessage.md) object whether it was explicitly specified by the app or was automatically constructed for you.

## -examples

## -see-also
[HttpClient](httpclient.md), [IClosable](../windows.foundation/iclosable.md), [IStringable](../windows.foundation/istringable.md)