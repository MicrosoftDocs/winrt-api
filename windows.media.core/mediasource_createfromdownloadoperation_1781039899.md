---
-api-id: M:Windows.Media.Core.MediaSource.CreateFromDownloadOperation(Windows.Networking.BackgroundTransfer.DownloadOperation)
-api-type: winrt method
---

<!-- Method syntax.
public MediaSource MediaSource.CreateFromDownloadOperation(DownloadOperation downloadOperation)
-->

# Windows.Media.Core.MediaSource.CreateFromDownloadOperation

## -description
Creates an instance of [MediaSource](mediasource.md) from the provided [DownloadOperation](../windows.networking.backgroundtransfer/downloadoperation.md).

## -parameters
### -param downloadOperation
The [DownloadOperation](../windows.networking.backgroundtransfer/downloadoperation.md) from which the [MediaSource](mediasource.md) is created.

## -returns
The new media source.

## -remarks
Use the [BackgroundDownloader](../windows.networking.backgroundtransfer/backgrounddownloader.md) class to create a [DownloadOperation](../windows.networking.backgroundtransfer/downloadoperation.md).

Use the [MediaSource.DownloadOperation](../windows.networking.backgroundtransfer/downloadoperation.md) property to get a reference to the download operation set with this method from the **MediaSource**. 

You can use the [MediaBinder](mediabinder.md) class to defer associating the **DownloadOperation** with the **MediaSource** until the system preparing to play the item. For more information on late binding media content, see [Media items, playlists, and tracks](/windows/uwp/audio-video-camera/media-playback-with-mediasource).

## -see-also
[BackgroundDownloader](../windows.networking.backgroundtransfer/backgrounddownloader.md),[MediaBinder](mediabinder.md),
[Media items, playlists, and tracks](/windows/uwp/audio-video-camera/media-playback-with-mediasource)

## -examples

