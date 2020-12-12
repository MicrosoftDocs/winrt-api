---
-api-id: T:Windows.Web.WebErrorStatus
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Web.WebErrorStatus : int
-->

# WebErrorStatus

## -description
Defines errors encountered during operations involving web services, such as authentication, proxy configuration, and destination URIs.

## -enum-fields
### -field Unknown:0
An unknown error has occurred.

### -field CertificateCommonNameIsIncorrect:1
The SSL certificate common name does not match the web address.

### -field CertificateExpired:2
The SSL certificate has expired.

### -field CertificateContainsErrors:3
The SSL certificate contains errors.

### -field CertificateRevoked:4
The SSL certificate has been revoked.

### -field CertificateIsInvalid:5
The SSL certificate is invalid.

### -field ServerUnreachable:6
The server is not responding.

### -field Timeout:7
The connection has timed out.

### -field ErrorHttpInvalidServerResponse:8
The server returned an invalid or unrecognized response.

### -field ConnectionAborted:9
The connection was aborted.

### -field ConnectionReset:10
The connection was reset.

### -field Disconnected:11
The connection was ended.

### -field HttpToHttpsOnRedirection:12
Redirected from a location to a secure location.

### -field HttpsToHttpOnRedirection:13
Redirected from a secure location to an unsecure location.

### -field CannotConnect:14
Cannot connect to destination.

### -field HostNameNotResolved:15
Could not resolve provided host name.

### -field OperationCanceled:16
The operation was canceled.

### -field RedirectFailed:17
The request redirect failed.

### -field UnexpectedStatusCode:18
An unexpected status code indicating a failure was received.

### -field UnexpectedRedirection:19
A request was unexpectedly redirected.

### -field UnexpectedClientError:20
An unexpected client-side error has occurred.

### -field UnexpectedServerError:21
An unexpected server-side error has occurred.

### -field MultipleChoices:300
The requested URL represents a high level grouping of which lower level selections need to be made.

### -field MovedPermanently:301
This and all future requests should be directed to the given URI.

### -field Found:302
The resource was found but is available in a location different from the one included in the request.

### -field SeeOther:303
The response to the request can be found under another URI using a GET method.

### -field NotModified:304
Indicates the resource has not been modified since last requested.

### -field UseProxy:305
The requested resource must be accessed through the proxy given by the Location field.

### -field TemporaryRedirect:307
The requested resource resides temporarily under a different URI.

### -field BadRequest:400
The request cannot be fulfilled due to bad syntax.

### -field Unauthorized:401
Authentication has failed or credentials have not yet been provided.

### -field PaymentRequired:402
Reserved.

### -field Forbidden:403
The server has refused the request.

### -field NotFound:404
The requested resource could not be found but may be available again in the future.

### -field MethodNotAllowed:405
A request was made of a resource using a request method not supported by that resource.

### -field NotAcceptable:406
The requested resource is only capable of generating content not acceptable according to the Accept headers sent in the request.

### -field ProxyAuthenticationRequired:407
The client must first authenticate itself with the proxy.

### -field RequestTimeout:408
The server timed out waiting for the request.

### -field Conflict:409
Indicates that the request could not be processed because of conflict in the request.

### -field Gone:410
Indicates that the resource requested is no longer available and will not be available again.

### -field LengthRequired:411
The request did not specify the length of its content, which is required by the requested resource.

### -field PreconditionFailed:412
The server does not meet one of the preconditions that the requester put on the request.

### -field RequestEntityTooLarge:413
The request is larger than the server is willing or able to process.

### -field RequestUriTooLong:414
Provided URI length exceeds the maximum length the server can process.

### -field UnsupportedMediaType:415
The request entity has a media type which the server or resource does not support.

### -field RequestedRangeNotSatisfiable:416
The client has asked for a portion of the file, but the server cannot supply that portion.

### -field ExpectationFailed:417
The server cannot meet the requirements of the Expect request-header field.

### -field InternalServerError:500
A generic error message, given when no more specific message is suitable.

### -field NotImplemented:501
The server either does not recognize the request method, or it lacks the ability to fulfill the request.

### -field BadGateway:502
The server was acting as a gateway or proxy and received an invalid response from the upstream server.

### -field ServiceUnavailable:503
The server is currently unavailable.

### -field GatewayTimeout:504
The server was acting as a gateway or proxy and did not receive a timely response from the upstream server.

### -field HttpVersionNotSupported:505
The server does not support the HTTP protocol version used in the request.

### -field InsufficientRangeSupport:22
The request does not support the range. 

### -field MissingContentLengthSupport:23
The request is mising the file size.

## -remarks
A WebErrorStatus value is returned by [Windows.Web.WebError.GetStatus](weberror_getstatus_1856274933.md), [Windows.Networking.WebSocketError.GetStatus](../windows.networking.sockets/websocketerror_getstatus_1856274933.md), and [Windows.Networking.BackgroundTransfer.GetStatus](../windows.networking.backgroundtransfer/backgroundtransfererror_getstatus_1856274933.md).

This example demonstrates how to use WebErrorStatus to display a different error message depending on the type of error. In this example, the WebErrorStatus value is returned by [Windows.Networking.WebSocketError.GetStatus](../windows.networking.sockets/websocketerror_getstatus_1856274933.md).

```csharp
using Windows.Web;
using Windows.Networking.Sockets;

// Pointer back to the main page. Needed to call methods in MainPage such as NotifyUser()
MainPage rootPage = MainPage.Current;

WebErrorStatus status = WebSocketError.GetStatus(ex.GetBaseException().HResult);

if (status == WebErrorStatus.CannotConnect ||
    status == WebErrorStatus.NotFound || 
    status == WebErrorStatus.RequestTimeout)
{
    rootPage.NotifyUser("Cannot connect to the server", NotifyType.ErrorMessage);
}
else
{
    rootPage.NotifyUser("Error: " + status, NotifyType.ErrorMessage);
}
```

```cppwinrt
// Pointer back to the main page. Needed to call methods in MainPage such as NotifyUser().
m_rootPage = MainPage::Current();

Windows::Web::WebErrorStatus status{ Windows::Networking::Sockets::WebSocketError::GetStatus(exception.to_abi()) };

if (status == Windows::Web::WebErrorStatus::CannotConnect ||
    status == Windows::Web::WebErrorStatus::NotFound ||
    status == Windows::Web::WebErrorStatus::RequestTimeout)
{
    m_rootPage.NotifyUser(L"Cannot connect to the server", NotifyType::ErrorMessage);
}
else
{
    m_rootPage.NotifyUser(std::wstring(L"Error: ") + exception.message().c_str(), NotifyType::ErrorMessage);
}
```

```cppcx
using namespace Windows::Web;
using namespace Windows::Networking::Sockets;

// Pointer back to the main page. Needed to call methods in MainPage such as NotifyUser()
rootPage = MainPage::Current;

WebErrorStatus status = WebSocketError::GetStatus(exception->HResult);

if (status == WebErrorStatus::CannotConnect || 
    status == WebErrorStatus::NotFound || 
    status == WebErrorStatus::RequestTimeout)
{
    rootPage->NotifyUser("Cannot connect to the server", NotifyType::ErrorMessage);
}
else
{
    rootPage->NotifyUser("Error: " + status.ToString(), NotifyType::ErrorMessage);
}
```

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1709 | 16299 | InsufficientRangeSupport |
| 1709 | 16299 | MissingContentLengthSupport |

## -examples

## -see-also
[Windows.Web.WebError.GetStatus](weberror_getstatus_1856274933.md),
[Windows.Networking.WebSocketError.GetStatus](../windows.networking.sockets/websocketerror_getstatus_1856274933.md),
[Windows.Networking.BackgroundTransfer.GetStatus](../windows.networking.backgroundtransfer/backgroundtransfererror_getstatus_1856274933.md),
[Background Transfer Download sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Background%20Transfer%20sample)
