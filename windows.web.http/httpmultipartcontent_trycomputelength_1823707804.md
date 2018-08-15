---
-api-id: M:Windows.Web.Http.HttpMultipartContent.TryComputeLength(System.UInt64@)
-api-type: winrt method
---

<!-- Method syntax
public bool TryComputeLength(System.UInt64 length)
-->

# Windows.Web.Http.HttpMultipartContent.TryComputeLength

## -description
Determines whether the [HttpMultipartContent](httpmultipartcontent.md) has a valid length in bytes.

## -parameters
### -param length
The length in bytes of the [HttpMultipartContent](httpmultipartcontent.md).

## -returns
**true** if *length* is a valid length; otherwise, **false**.

## -remarks
The [TryComputeLength](httpmultipartcontent_trycomputelength_1823707804.md) method calculates the content length for HTTP content in [HttpMultipartContent](httpmultipartcontent.md). Headers set on the content are not included in the content length. This is useful for content types that are easy to calculate the content length.

If computing the content length is not possible or expensive (would require the system to buffer the whole content where the serialization would be expensive or require the system to allocate a lot of memory), this method can return **false**. If this method returns **false**, this implies that either chunked transfer is needed or the content must get buffered before being sent to the server.

## -examples

## -see-also
