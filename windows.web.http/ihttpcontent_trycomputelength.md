---
-api-id: M:Windows.Web.Http.IHttpContent.TryComputeLength(System.UInt64@)
-api-type: winrt method
---

<!-- Method syntax
public bool TryComputeLength(System.UInt64 length)
-->

# Windows.Web.Http.IHttpContent.TryComputeLength

## -description
Determines whether the HTTP content has a valid length in bytes.

## -parameters
### -param length
The length in bytes of the HTTP content.

## -returns
**true** if *length* is a valid length; otherwise, **false**.

## -remarks
The [TryComputeLength](ihttpcontent_trycomputelength.md) method calculates the content length for HTTP content in [IHttpContent](ihttpcontent.md). This is useful for content types that are easy to calculate the content length.

If computing the content length is not possible or expensive (would require the system to buffer the whole content where the serialization would be expensive or require the system to allocate a lot of memory), this method can return **false**. If this method returns **false**, this implies that either chunked transfer is needed or the content must get buffered before being sent to the server.

## -examples

## -see-also
