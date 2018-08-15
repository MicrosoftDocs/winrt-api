---
-api-id: M:Windows.UI.Xaml.Media.Imaging.BitmapSource.SetSourceAsync(Windows.Storage.Streams.IRandomAccessStream)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction SetSourceAsync(Windows.Storage.Streams.IRandomAccessStream streamSource)
-->

# Windows.UI.Xaml.Media.Imaging.BitmapSource.SetSourceAsync

## -description
Sets the source image for a [BitmapSource](bitmapsource.md) by accessing a stream and processing the result asynchronously.

## -parameters
### -param streamSource
The stream source that sets the image source value.

## -returns
An asynchronous handler called when the operation is complete.

## -remarks
Setting an image source by calling the asynchronous [SetSourceAsync](bitmapsource_setsourceasync_1118221574.md) method rather than the similar [SetSource](bitmapsource_setsource_548578678.md) method avoids blocking the UI thread. The [SetSourceAsync](bitmapsource_setsourceasync_1118221574.md) behavior is similar to what the system does internally when you set an image source as a URI in markup: the system doesn't wait to retrieve and decode, but it does run layout again once the image source is available. The markup parsing equivalent doesn't expose the **async** infrastructure, but the [SetSourceAsync](bitmapsource_setsourceasync_1118221574.md) method does. For more info on how to use **async**, **await**, or how to work with an [IAsyncAction](../windows.foundation/iasyncaction.md) value, see [Call asynchronous APIs in C# or Visual Basic](http://msdn.microsoft.com/library/066711e0-d5c4-467e-8683-3cc64edbcc83).

If the app changes the image source again via [SetSourceAsync](bitmapsource_setsourceasync_1118221574.md), [SetSource](bitmapsource_setsource_548578678.md) or [UriSource](bitmapimage_urisource.md) while a [SetSourceAsync](bitmapsource_setsourceasync_1118221574.md) call is already in progress, the pending [SetSourceAsync](bitmapsource_setsourceasync_1118221574.md) action will throw a [TaskCanceledException](https://msdn.microsoft.com/library/system.threading.tasks.taskcanceledexception.aspx) and set the [Status](https://msdn.microsoft.com/library/system.threading.tasks.task.status.aspx) to [Canceled](https://msdn.microsoft.com/library/system.threading.tasks.taskstatus.aspx).

If you have a Microsoft .NET stream that you want to use as a source, you can use the [AsRandomAccessStream](XREF:TODO:dcc72283-caed-49ee-b45d-ccaf94e97129) extension method to convert it to the [IRandomAccessStream](../windows.storage.streams/irandomaccessstream.md) type that's needed as input for [SetSourceAsync](bitmapsource_setsourceasync_1118221574.md).

In low memory situations (most likely on lower-memory phones), it is possible for an exception to be raised with the message "The image is unrecognized" and an HRESULT of 0x88982F60. While this exception ordinarily indicates bad data, if your app is close to its memory limit then the cause of the exception is likely to be low memory. In that case, we recommend that you free memory and try again.

## -examples
This example shown here uses a file stream (obtained using a file picker, not shown) to load an image source by calling [SetSourceAsync](bitmapsource_setsourceasync_1118221574.md). The file picker, stream and call to [SetSourceAsync](bitmapsource_setsourceasync_1118221574.md) are all asynchronous. The code shown here comes from a larger code sample, the SDK [XAML images sample](http://go.microsoft.com/fwlink/p/?linkid=238575).

```csharp
// Ensure the stream is disposed once the image is loaded
using (IRandomAccessStream fileStream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read))
{
     // Set the image source to the selected bitmap
     BitmapImage bitmapImage = new BitmapImage();
     bitmapImage.DecodePixelHeight = decodePixelHeight;
     bitmapImage.DecodePixelWidth = decodePixelWidth;

     await bitmapImage.SetSourceAsync(fileStream);
     Scenario2Image.Source = bitmapImage;
}
```



## -see-also
[Image](../windows.ui.xaml.controls/image.md), [Image.Source](../windows.ui.xaml.controls/image_source.md), [Call asynchronous APIs in C# or Visual Basic](http://msdn.microsoft.com/library/066711e0-d5c4-467e-8683-3cc64edbcc83), [XAML images sample](http://go.microsoft.com/fwlink/p/?linkid=238575)