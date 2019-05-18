---
-api-id: M:Windows.Web.Http.HttpBufferContent.TryComputeLength(System.UInt64@)
-api-type: winrt method
---

<!-- Method syntax
public bool TryComputeLength(System.UInt64 length)
-->

# Windows.Web.Http.HttpBufferContent.TryComputeLength

## -description
Computes the [HttpBufferContent](httpbuffercontent.md) length in bytes.

## -parameters
### -param length
The length in bytes of the [HttpBufferContent](httpbuffercontent.md).

## -returns
**true** if *length* is a valid length; otherwise, **false**.

## -remarks
The TryComputeLength method calculates the content length for the [HttpBufferContent](httpbuffercontent.md). This is useful for content types that are easy to calculate the content length.

## -examples

## -see-also
