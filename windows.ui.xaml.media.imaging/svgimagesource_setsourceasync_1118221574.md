---
-api-id: M:Windows.UI.Xaml.Media.Imaging.SvgImageSource.SetSourceAsync(Windows.Storage.Streams.IRandomAccessStream)
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<SvgImageSourceLoadStatus> SvgImageSource.SetSourceAsync(IRandomAccessStream streamSource)
-->

# Windows.UI.Xaml.Media.Imaging.SvgImageSource.SetSourceAsync

## -description
Sets the source SVG for a [SvgImageSource](svgimagesource.md) by accessing a stream and processing the result asynchronously.

## -parameters
### -param streamSource
The stream source that sets the SVG source value.

## -returns
A [SvgImageSourceLoadStatus](svgimagesourceloadstatus.md) value that indicates whether the operation was successful. If it failed, indicates the reason for the failure.  

## -remarks
Setting a SVG source by calling the asynchronous [SetSourceAsync(IRandomAccessStream)](svgimagesource_setsourceasync_1118221574.md) method avoids blocking the UI thread. For more info on how to use **async** or **await**, see [Call asynchronous APIs in C# or Visual Basic](http://msdn.microsoft.com/library/066711e0-d5c4-467e-8683-3cc64edbcc83).
If the app changes the SVG source again via [SetSourceAsync(IRandomAccessStream)](svgimagesource_setsourceasync_1118221574.md) or [UriSource](svgimagesource_urisource.md) while a [SetSourceAsync(IRandomAccessStream)](svgimagesource_setsourceasync_1118221574.md) call is already in progress, the pending [SetSourceAsync(IRandomAccessStream)](svgimagesource_setsourceasync_1118221574.md) action will throw a [TaskCanceledException](https://msdn.microsoft.com/library/system.threading.tasks.taskcanceledexception.aspx).

## -see-also

## -examples

This example shown here uses a file stream (obtained using a file picker, not shown) to load an image source by calling [SetSourceAsync(IRandomAccessStream)](svgimagesource_setsourceasync_1118221574.md). The file picker, stream and call to [SetSourceAsync(IRandomAccessStream)](svgimagesource_setsourceasync_1118221574.md) are all asynchronous.

```csharp
// Ensure the stream is disposed once the SVG is loaded
using (IRandomAccessStream fileStream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read))
{
    // Set the SVG source to the selected file
    SvgImageSource svgImage = new SvgImageSource();

    await svgImage.SetSourceAsync(fileStream);
    Scenario2Image.Source = svgImage;
}
```

