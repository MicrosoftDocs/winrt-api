---
-api-id: P:Windows.Media.Streaming.Adaptive.AdaptiveMediaSourceDownloadResult.ResourceByteRangeLength
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.IReference<ulong> ResourceByteRangeLength { get;  set; }
-->

# Windows.Media.Streaming.Adaptive.AdaptiveMediaSourceDownloadResult.ResourceByteRangeLength

## -description
Gets or sets the requested byte range of the resource to be downloaded.

## -property-value
The requested byte range of the resource to be downloaded.

## -remarks
If this value is set to null, no byte range request is issued and the entire resource will be downloaded. Setting the byte range length to zero is not allowed. If a non-null, non-zero value is specified, then the system will use the value, along with any value specified for the [ResourceByteRangeOffset](adaptivemediasourcedownloadresult_resourcebyterangeoffset.md) property, to issue a byte range request to the Http server hosting the resource.

## -examples

## -see-also
