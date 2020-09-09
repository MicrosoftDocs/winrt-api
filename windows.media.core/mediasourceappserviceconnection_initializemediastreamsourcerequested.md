---
-api-id: E:Windows.Media.Core.MediaSourceAppServiceConnection.InitializeMediaStreamSourceRequested
-api-type: winrt event
---

<!-- Event syntax.
public event TypedEventHandler InitializeMediaStreamSourceRequested<MediaSourceAppServiceConnection, InitializeMediaStreamSourceRequestedEventArgs>
-->

# Windows.Media.Core.MediaSourceAppServiceConnection.InitializeMediaStreamSourceRequested

## -description
Raised by the system to request the initialization of a new [MediaStreamSource](/uwp/api/windows.media.core.mediastreamsource).

## -remarks
After registering a handler for the **InitializeMediaStreamSourceRequestedEventArgs**, call [Start](/uwp/api/windows.media.core.mediasourceappserviceconnection.Start) to notify the system that the app service is ready to handle requests. 

With the [InitializeMediaStreamSourceRequestedEventArgs](/uwp/api/windows.media.core.initializemediastreamsourcerequestedeventargs) object, the system passes an [IRandomAccessStream](/uwp/api/windows.storage.streams.irandomaccessstream) and an a uninitialized [MediaStreamSource](/uwp/api/windows.media.core.mediastreamsource) object into the **InitializeMediaStreamSourceRequested** event handler. The app service should parse the **IRandomAccessStream** to create an [IMediaStreamDescriptor](/uwp/api/windows.media.core.imediastreamdescriptor). If the requested stream format is supported, then the app service can initialize the **MediaStreamSource** and begin providing samples.


## -see-also

## -examples

