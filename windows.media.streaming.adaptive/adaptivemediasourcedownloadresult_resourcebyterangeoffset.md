---
-api-id: P:Windows.Media.Streaming.Adaptive.AdaptiveMediaSourceDownloadResult.ResourceByteRangeOffset
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.IReference<ulong> ResourceByteRangeOffset { get;  set; }
-->

# Windows.Media.Streaming.Adaptive.AdaptiveMediaSourceDownloadResult.ResourceByteRangeOffset

## -description
Gets or sets the requested byte range offset of the resource to be downloaded.

## -property-value
The requested byte range offset of the resource to be downloaded.

## -remarks
If a non-null, non-zero value is specified for the [ResourceByteRangeLength](adaptivemediasourcedownloadresult_resourcebyterangelength.md) property, the value of **ResourceByteRangeOffset** is used to issue a byte range request to the Http server hosting the resource.

## -examples

## -see-also
