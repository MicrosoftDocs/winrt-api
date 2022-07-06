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
Setting an image source by calling the asynchronous SetSourceAsync method rather than the similar [SetSource](bitmapsource_setsource_548578678.md) method avoids blocking the UI thread. The SetSourceAsync behavior is similar to what the system does internally when you set an image source as a URI in markup: the system doesn't wait to retrieve and decode, but it does run layout again once the image source is available. The markup parsing equivalent doesn't expose the **async** infrastructure, but the SetSourceAsync method does. For more info on how to use **async**, **await**, or how to work with an [IAsyncAction](../windows.foundation/iasyncaction.md) value, see [Call asynchronous APIs in C# or Visual Basic](/windows/uwp/threading-async/call-asynchronous-apis-in-csharp-or-visual-basic).

If the app changes the image source again via SetSourceAsync, [SetSource](bitmapsource_setsource_548578678.md) or [UriSource](bitmapimage_urisource.md) while a SetSourceAsync call is already in progress, the pending SetSourceAsync action will throw a [TaskCanceledException](/dotnet/api/system.threading.tasks.taskcanceledexception?view=dotnet-uwp-10.0&preserve-view=true) and set the [Status](/dotnet/api/system.threading.tasks.task.status?view=dotnet-uwp-10.0&preserve-view=true) to [Canceled](/dotnet/api/system.threading.tasks.taskstatus?view=dotnet-uwp-10.0&preserve-view=true).

If you have a Microsoft .NET stream that you want to use as a source, you can use the [AsRandomAccessStream](/dotnet/standard/cross-platform/windowsruntimestreamextensions-asrandomaccessstream-method) extension method to convert it to the [IRandomAccessStream](../windows.storage.streams/irandomaccessstream.md) type that's needed as input for SetSourceAsync.

In low memory situations (most likely on lower-memory phones), it is possible for an exception to be raised with the message "The image is unrecognized" and an HRESULT of 0x88982F60. While this exception ordinarily indicates bad data, if your app is close to its memory limit then the cause of the exception is likely to be low memory. In that case, we recommend that you free memory and try again.

## -examples
This example shown here uses a file stream (obtained using a file picker, not shown) to load an image source by calling SetSourceAsync. The file picker, stream and call to SetSourceAsync are all asynchronous. The code shown here comes from a larger code sample, the SDK [XAML images sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/XAML%20images%20sample).

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
[Image](../windows.ui.xaml.controls/image.md), [Image.Source](../windows.ui.xaml.controls/image_source.md), [Call asynchronous APIs in C# or Visual Basic](/windows/uwp/threading-async/call-asynchronous-apis-in-csharp-or-visual-basic), [XAML images sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/XAML%20images%20sample)
