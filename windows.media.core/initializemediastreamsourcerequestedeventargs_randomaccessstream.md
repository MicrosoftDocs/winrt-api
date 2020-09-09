---
-api-id: P:Windows.Media.Core.InitializeMediaStreamSourceRequestedEventArgs.RandomAccessStream
-api-type: winrt property
---

<!-- Property syntax.
public IRandomAccessStream RandomAccessStream { get; }
-->

# Windows.Media.Core.InitializeMediaStreamSourceRequestedEventArgs.RandomAccessStream

## -description
Gets the [IRandomAccessStream](/uwp/api/windows.storage.streams.irandomaccessstream) associated with the media stream source request.

## -property-value
The **IRandomAccessStream** associated with the media stream source request.

## -remarks
The app service should parse the **IRandomAccessStream** to create an [IMediaStreamDescriptor](/uwp/api/windows.media.core.imediastreamdescriptor). If the requested stream format is supported, then the app service can initialize the [MediaStreamSource](/uwp/api/windows.media.core.mediastreamsource) provided in the event args and begin providing samples.

## -see-also

## -examples

