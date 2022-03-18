---
-api-id: T:Windows.Web.Http.HttpStatusCode
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Web.Http.HttpStatusCode : int
-->

# HttpStatusCode

## -description
Contains the values of status codes defined for HTTP in the response to an HTTP request.

## -enum-fields
### -field None:0
The client request wasn't successful.

### -field Continue:100
The client should continue with its request.

### -field SwitchingProtocols:101
The HTTP protocol version or protocol is being changed.

### -field Processing:102
The server has received a Web Distributed Authoring and Versioning (WebDAV) request and is processing the request.

This status code is an HTTP extension used with WebDAV. It can only be returned if the client HTTP request included the DAV header in the request. This status code is documented in IETF [RFC 2518](https://tools.ietf.org/html/rfc2518).

### -field Ok:200
The request succeeded and that the requested information is in the response. This is the most common status code to receive.

### -field Created:201
The request resulted in a new resource created before the response was sent.

### -field Accepted:202
The request has been accepted for further processing.

### -field NonAuthoritativeInformation:203
The returned meta-information is from a cached copy instead of the origin server and therefore may be incorrect.

### -field NoContent:204
The request has been successfully processed and that the response is intentionally blank.

### -field ResetContent:205
The client should reset (not reload) the current resource.

### -field PartialContent:206
The response is a partial response as requested by a **GET** request that includes a byte range.

### -field MultiStatus:207
The response provides status for multiple independent operations. Specific error messages appear in the body of the multi- status response.

This status code is an HTTP extension used with Web Distributed Authoring and Versioning (WebDAV). This status code is documented in IETF [RFC 4918](https://tools.ietf.org/html/rfc4918).

### -field AlreadyReported:208
Some of the results of the requested operation were already reported.

This status code is an HTTP extension used with Web Distributed Authoring and Versioning (WebDAV). It can only be returned if the client HTTP request included the DAV header in the request. This status code is documented in IETF [RFC 5842](https://tools.ietf.org/html/rfc5842).

### -field IMUsed:226
The server has fulfilled a **GET** request for the resource and the response is the result of one or more actions applied to the current instance.

This status code is documented in IETF [RFC 3229](https://tools.ietf.org/html/rfc3229).

### -field MultipleChoices:300
The requested information has multiple representations. The default action is to treat this status as a redirect and follow the contents of the **Location** header associated with this response.

### -field MovedPermanently:301
The requested information has been moved to the URI specified in the **Location** header. The default action when this status is received is to follow the **Location** header associated with the response.

### -field Found:302
The requested information is located at the URI specified in the **Location** header. The default action when this status is received is to follow the **Location** header associated with the response. When the original request method was **POST**, the redirected request will use the **GET** method.

### -field SeeOther:303
Automatically redirects the client to the URI specified in the **Location** header as the result of a **POST**. The request to the resource specified by the **Location** header will be made with the **GET** method.

### -field NotModified:304
The client's cached copy is up to date. The contents of the resource are not transferred.

### -field UseProxy:305
The request should use the proxy server at the URI specified in the **Location** header.

### -field TemporaryRedirect:307
The request information is located at the URI specified in the **Location** header. The default action when this status is received is to follow the **Location** header associated with the response. When the original request method was **POST**, the redirected request will also use the **POST** method.

### -field PermanentRedirect:308
The target resource has been assigned a new permanent URI and any future references to this resource should use one of the returned URIs specified in the **Location** header.

This status code is documented in IETF draft [draft-reschke-http-status-308](https://tools.ietf.org/html/draft-reschke-http-status-308-07).

### -field BadRequest:400
The request could not be understood by the server. This status code is sent when no other error is applicable, or if the exact error is unknown or does not have its own error code.

### -field Unauthorized:401
The requested resource requires authentication. The **WWW-Authenticate** header contains the details of how to perform the authentication.

### -field PaymentRequired:402
This code is reserved for future use.

### -field Forbidden:403
The server refuses to fulfill the request.

### -field NotFound:404
The requested resource does not exist on the server.

### -field MethodNotAllowed:405
The HTTP method in the request is not allowed on the requested resource.

### -field NotAcceptable:406
The client has indicated with **Accept** headers that it will not accept any of the available representations of the resource.

### -field ProxyAuthenticationRequired:407
The requested proxy requires authentication. The **Proxy-Authenticate** header contains the details of how to perform the authentication.

### -field RequestTimeout:408
The client did not send a request within the time the server was expecting the request.

### -field Conflict:409
The request could not be carried out because of a conflict on the server.

### -field Gone:410
The requested resource is no longer available.

### -field LengthRequired:411
The required **Content-Length** header is missing.

### -field PreconditionFailed:412
A condition set for this request failed, and the request cannot be carried out. Conditions are set with conditional request headers like **If-Match**, **If-None-Match**, or **If-Unmodified-Since**.

### -field RequestEntityTooLarge:413
The request is too large for the server to process.

### -field RequestUriTooLong:414
The URI is too long.

### -field UnsupportedMediaType:415
The request is an unsupported type.

### -field RequestedRangeNotSatisfiable:416
The range of data requested from the resource cannot be returned, either because the beginning of the range is before the beginning of the resource, or the end of the range is after the end of the resource.

### -field ExpectationFailed:417
An expectation given in an **Expect** header could not be met by the server.

### -field UnprocessableEntity:422
The server understands the content type of the request entity and the syntax of the request entity is correct, but the server was unable to process the contained instructions.

This status code is an HTTP extension used with Web Distributed Authoring and Versioning (WebDAV). This status code is documented in IETF [RFC 4918](https://tools.ietf.org/html/rfc4918).

### -field Locked:423
The source or destination resource of a method is locked. This response should contain an appropriate precondition or post-condition code.

This status code is an HTTP extension used with Web Distributed Authoring and Versioning (WebDAV). This status code is documented in IETF [RFC 4918](https://tools.ietf.org/html/rfc4918).

### -field FailedDependency:424
The method could not be performed on the resource because the requested action depended on another action and that action failed.

This status code is an HTTP extension used with Web Distributed Authoring and Versioning (WebDAV). This status code is documented in IETF [RFC 4918](https://tools.ietf.org/html/rfc4918).

### -field UpgradeRequired:426
The client should switch to a different protocol such as TLS/1.0.

This status code is documented in IETF [RFC 2917](https://tools.ietf.org/html/rfc2817).

### -field PreconditionRequired:428
The origin server requires the request to be conditional.

This status code is documented in IETF [RFC 6585](https://tools.ietf.org/html/rfc6585).

### -field TooManyRequests:429
The user has sent too many requests in a given amount of time. The response should include details explaining the condition, and may include a **Retry-After** header indicating how long to wait before making a new request.

This status code is documented in IETF [RFC 6585](https://tools.ietf.org/html/rfc6585).

### -field RequestHeaderFieldsTooLarge:431
The server is unwilling to process the request because its header fields are too large. The request may be resubmitted after reducing the size of the request header fields.

This status code is documented in IETF [RFC 6585](https://tools.ietf.org/html/rfc6585).

### -field InternalServerError:500
A generic error has occurred on the server.

### -field NotImplemented:501
The server does not support the requested function.

### -field BadGateway:502
An intermediate proxy server received a bad response from another proxy or the origin server.

### -field ServiceUnavailable:503
The server is temporarily unavailable, usually due to high load or maintenance.

### -field GatewayTimeout:504
An intermediate proxy server timed out while waiting for a response from another proxy or the origin server.

### -field HttpVersionNotSupported:505
The requested HTTP version is not supported by the server.

### -field VariantAlsoNegotiates:506
The server has an internal configuration error. The chosen variant resource is configured to engage in transparent content negotiation itself, and is therefore not a proper end point in the negotiation process.

This status code is documented in IETF [RFC 2295](https://tools.ietf.org/html/rfc2295).

### -field InsufficientStorage:507
The method could not be performed on the resource because the server is unable to store the representation needed to successfully complete the request. This condition is considered to be temporary.

This status code is an HTTP extension used with Web Distributed Authoring and Versioning (WebDAV). This status code is documented in IETF [RFC 4918](https://tools.ietf.org/html/rfc4918).

### -field LoopDetected:508
The server terminated an operation because it encountered an infinite loop while processing a request. This status indicates that the entire operation failed.

This status code is an HTTP extension used with Web Distributed Authoring and Versioning (WebDAV). It can only be returned if the client HTTP request included the DAV header in the request. This status code is documented in IETF [RFC 5842](https://tools.ietf.org/html/rfc5842).

### -field NotExtended:510
The policy for accessing the resource has not been met in the request.

This status code is documented in IETF [RFC 2774](https://tools.ietf.org/html/rfc2774).

### -field NetworkAuthenticationRequired:511
The server indicates that the client needs to authenticate to gain network access. The response should contain a link to a resource that allows the user to submit credentials.

This status code is documented in IETF [RFC 6585](https://tools.ietf.org/html/rfc6585).


## -remarks
The HttpStatusCode enumeration contains the values of the status codes defined by the IETF in [RFC 2616](https://tools.ietf.org/html/rfc2616) for HTTP 1.1 and related RFCs.

The status of an HTTP request is contained in the [StatusCode](httpresponsemessage_statuscode.md) property on the [HttpResponseMessage](httpresponsemessage.md) object.

## -examples

## -see-also
[HttpResponseMessage](httpresponsemessage.md), [HttpResponseMessage.StatusCode](httpresponsemessage_statuscode.md)
