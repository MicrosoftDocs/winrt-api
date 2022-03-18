---
-api-id: T:Windows.Media.Core.MediaSourceAppServiceConnection
-api-type: winrt class
---

<!-- Class syntax.
public class MediaSourceAppServiceConnection 
-->

# Windows.Media.Core.MediaSourceAppServiceConnection

## -description
Enables the implementation of an app service that provides a custom media source that can be consumed by UWP apps. 

## -remarks
This feature must be implemented in a background task. When the background task is launched and the [Run](/uwp/api/Windows.ApplicationModel.Background.IBackgroundTask#Windows_ApplicationModel_Background_IBackgroundTask_Run_Windows_ApplicationModel_Background_IBackgroundTaskInstance_), the app should create a new instance of this class, register a handler for the [InitializeMediaStreamSourceRequested](/uwp/api/windows.media.core.mediasourceappserviceconnection.InitializeMediaStreamSourceRequested) event, and call [Start](/uwp/api/windows.media.core.mediasourceappserviceconnection.Start) to notify the system that the app service is ready to handle stream source requests.

The system passes an [IRandomAccessStream](/uwp/api/windows.storage.streams.irandomaccessstream) and an a uninitialized [MediaStreamSource](/uwp/api/windows.media.core.mediastreamsource) object into the **InitializeMediaStreamSourceRequested** event handler. The app service should parse the **IRandomAccessStream** to create an [IMediaStreamDescriptor](/uwp/api/windows.media.core.imediastreamdescriptor). If the requested stream format is supported, then the app service can initialize the **MediaStreamSource** and begin providing samples.

## -see-also

## -examples

