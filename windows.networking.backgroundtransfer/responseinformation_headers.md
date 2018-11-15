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
The dictionary returned by the **Headers** property stores header names (as its keys) in the case that the server sends, which can vary between servers and/or HTTP versions. The dictionary also performs key lookups case-sensitively. If the server sends the header name `Content-Length`, then the dictionary stores it that way, and you'll need to use that same case as a lookup key. Header *values* are stored exactly as they come over the wire.

## -examples

## -see-also
[RFC 2616](https://www.w3.org/Protocols/rfc2616/rfc2616.html)