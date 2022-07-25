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
Setting a SVG source by calling the asynchronous SetSourceAsync(IRandomAccessStream) method avoids blocking the UI thread. For more info on how to use **async** or **await**, see [Call asynchronous APIs in C# or Visual Basic](/windows/uwp/threading-async/call-asynchronous-apis-in-csharp-or-visual-basic).
If the app changes the SVG source again via SetSourceAsync(IRandomAccessStream) or [UriSource](svgimagesource_urisource.md) while a SetSourceAsync(IRandomAccessStream) call is already in progress, the pending SetSourceAsync(IRandomAccessStream) action will throw a [TaskCanceledException](/dotnet/api/system.threading.tasks.taskcanceledexception?view=dotnet-uwp-10.0&preserve-view=true).

## -see-also

## -examples

This example shown here uses a file stream (obtained using a file picker, not shown) to load an image source by calling SetSourceAsync(IRandomAccessStream). The file picker, stream and call to SetSourceAsync(IRandomAccessStream) are all asynchronous.

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

