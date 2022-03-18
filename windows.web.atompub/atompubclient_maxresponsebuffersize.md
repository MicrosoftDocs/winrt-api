---
-api-id: P:Windows.Web.AtomPub.AtomPubClient.MaxResponseBufferSize
-api-type: winrt property
---

<!-- Property syntax
public uint MaxResponseBufferSize { get;  set; }
-->

# Windows.Web.AtomPub.AtomPubClient.MaxResponseBufferSize

## -description

Gets or sets the maximum number of bytes to buffer when receiving a response from a server.

## -property-value

Maximum size and default is **UInt32.MaxValue**.

## -remarks

Applications can protect themselves against a malicious server which sends an excessively large response body to DoS the client by setting the property to a smaller number.

If the response from the server contains a **Content-Length** header with a value greater than the value of this property, the request will be aborted immediately and the operation will immediately fail with an error indicating that the response body was too large. If no **Content-Length** header is present in the response, the response body will be buffered up to the point of this value. As soon as the response body grows to be larger than this value, the request will be aborted, the buffered response data will be released, and the operation will immediately fail with an error indicating that the response body was too large.

## -examples

## -see-also
