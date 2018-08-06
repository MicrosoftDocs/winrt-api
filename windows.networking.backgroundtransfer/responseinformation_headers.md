---
-api-id: P:Windows.Networking.BackgroundTransfer.ResponseInformation.Headers
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Collections.IMapView<string, string> Headers { get; }
-->

# Windows.Networking.BackgroundTransfer.ResponseInformation.Headers

## -description
Gets all response headers sent by the server.

## -property-value
Contains all response headers sent by the server.

## -remarks
The dictionary returned by the **Headers** property stores header names (as its keys) in lower case, and it performs key lookups case-sensitively. If the server sends the header name `Content-Length`, then the dictionary stores that as `content-length`. If the original `Content-Length` is used as a lookup key, then it won't be found. It would be necessary in that example to use `content-length` as the lookup key. Header *values* are stored exactly as they come over the wire.

## -examples

## -see-also
[RFC 2616](https://www.w3.org/Protocols/rfc2616/rfc2616.html)