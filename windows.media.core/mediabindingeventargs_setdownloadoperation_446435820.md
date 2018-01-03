---
-api-id: M:Windows.Media.Core.MediaBindingEventArgs.SetDownloadOperation(Windows.Networking.BackgroundTransfer.DownloadOperation)
-api-type: winrt method
---

<!-- Method syntax.
public void MediaBindingEventArgs.SetDownloadOperation(DownloadOperation downloadOperation)
-->

# Windows.Media.Core.MediaBindingEventArgs.SetDownloadOperation

## -description
Binds a [DownloadOperation](../windows.networking.backgroundtransfer/downloadoperation.md) to the [MediaSource](mediasource.md) associated with the event. 

## -parameters


### -param downloadOperation
The **DownloadOperation** to bind to the **MediaSource**.

## -remarks
Use the [BackgroundDownloader](../windows.networking.backgroundtransfer/backgrounddownloader.md) class to create a [DownloadOperation](../windows.networking.backgroundtransfer/downloadoperation.md).

You can create a **MediaSource** directly from a **DownloadOperation**, without using media binding by calling [CreateFromDownloadOperation](mediasource_createfromdownloadoperation_1781039899.md).

Use the [MediaSource.DownloadOperation](../windows.networking.backgroundtransfer/downloadoperation.md) property to get a reference to the download operation set with this method from the **MediaSource**. 

## -see-also

## -examples

