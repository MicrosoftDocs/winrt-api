---
-api-id: P:Windows.Web.Http.HttpGetBufferResult.Value
-api-type: winrt property
ms.custom: 19H1
---

<!-- Property syntax.
public IBuffer Value { get; }
-->

# Windows.Web.Http.HttpGetBufferResult.Value

## -description
The returned data from an HTTP request as an [IBuffer](../windows.storage.streams/ibuffer.md).

## -property-value
IBuffer value of the HTTP response.

## -remarks
The **IBuffer** will only be available if the HTTP server returned a valid HTTP response and the body of the response could be read.

## -see-also
[IBuffer](../windows.storage.streams/ibuffer.md)

## -examples
