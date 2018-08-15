---
-api-id: M:Windows.Web.Http.HttpStreamContent.TryComputeLength(System.UInt64@)
-api-type: winrt method
---

<!-- Method syntax
public bool TryComputeLength(System.UInt64 length)
-->

# Windows.Web.Http.HttpStreamContent.TryComputeLength

## -description
Determines whether the [HttpStreamContent](httpstreamcontent.md) has a valid length in bytes.

## -parameters
### -param length
The length in bytes of the [HttpStreamContent](httpstreamcontent.md).

## -returns
**true** if *length* is a valid length; otherwise, **false**.

## -remarks
The [TryComputeLength](httpstreamcontent_trycomputelength_1823707804.md) method calculates the content length for HTTP content in [HttpStreamContent](httpstreamcontent.md). Headers set on the content are not included in the content length. This is useful for content types that are easy to calculate the content length.

If computing the content length is not possible or expensive (would require the system to buffer the whole content where the serialization would be expensive or require the system to allocate a lot of memory), this method can return **false**. If this method returns **false**, this implies that either chunked transfer is needed or the content must get buffered before being sent to the server.

## -examples

## -see-also
