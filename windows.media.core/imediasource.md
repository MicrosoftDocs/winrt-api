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
The IMediaSource interface is implemented by the [MediaStreamSource](mediastreamsource.md) runtime class and can also be implemented by other runtime classes.

Runtime classes that implement this interface must also implement the [IMFGetService](/windows/desktop/api/mfidl/nn-mfidl-imfgetservice) interface and must support returning an [IMFMediaSource](/windows/desktop/api/mfidl/nn-mfidl-imfmediasource) or an [IMFMediaSourceExtension](/windows/desktop/api/mfmediaengine/nn-mfmediaengine-imfmediasourceextension) interface when [IMFGetService.GetService](/windows/desktop/api/mfidl/nf-mfidl-imfgetservice-getservice) method is invoked for the MF_MEDIASOURCE_SERVICE service.

## -examples

## -see-also
