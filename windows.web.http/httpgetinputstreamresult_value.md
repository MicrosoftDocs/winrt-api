---
-api-id: P:Windows.Web.Http.HttpGetInputStreamResult.Value
-api-type: winrt property
ms.custom: 19H1
---

<!-- Property syntax.
public IInputStream Value { get; }
-->

# Windows.Web.Http.HttpGetInputStreamResult.Value

## -description
The returned data from an HTTP request as an [IInputStream](../windows.storage.streams/iinputstream.md).

## -property-value
**IInputStream** value of the HTTP response.

## -remarks
The **IInputStream** will only be available if the HTTP server returned a valid HTTP response and the body of the response could be read.

## -see-also
[IInputStream](../windows.storage.streams/iinputstream.md)

## -examples

