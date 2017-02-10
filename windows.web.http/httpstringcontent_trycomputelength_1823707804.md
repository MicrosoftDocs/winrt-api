---
-api-id: M:Windows.Web.Http.HttpStringContent.TryComputeLength(System.UInt64@)
-api-type: winrt method
---

<!-- Method syntax
public bool TryComputeLength(System.UInt64 length)
-->

# Windows.Web.Http.HttpStringContent.TryComputeLength

## -description
Compute the [HttpStringContent](httpstringcontent.md) length in bytes.

## -parameters
### -param length
The length in bytes of the [HttpStringContent](httpstringcontent.md).

## -returns
**true** if *length* is a valid length; otherwise, **false**.

The return value should never be **false**.

## -remarks
The [TryComputeLength](httpstringcontent_trycomputelength.md) method calculates the content length for HTTP content in [HttpStringContent](httpstringcontent.md). Headers set on the content are not included in the content length. This is useful for content types that are easy to calculate the content length.

## -examples

## -see-also
