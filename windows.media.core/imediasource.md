---
-api-id: T:Windows.Media.Core.IMediaSource
-api-type: winrt interface
---

<!-- Interface syntax.
public interface IMediaSource : 
-->

# Windows.Media.Core.IMediaSource

## -description
Represents a media source that delivers media samples to a media pipeline.

## -remarks
The [IMediaSource](imediasource.md) interface is implemented by the [MediaStreamSource](mediastreamsource.md) runtime class and can also be implemented by other runtime classes.

Runtime classes that implement this interface must also implement the [IMFGetService](XREF:TODO:mf.imfgetservice) interface and must support returning an [IMFMediaSource](XREF:TODO:mf.imfmediasource) or an [IMFMediaSourceExtension](XREF:TODO:mf.imfmediasourceextension) interface when [IMFGetService.GetService](XREF:TODO:mf.imfgetservice_getservice) method is invoked for the MF_MEDIASOURCE_SERVICE service.

## -examples

## -see-also