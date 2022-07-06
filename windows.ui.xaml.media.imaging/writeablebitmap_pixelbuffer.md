---
-api-id: P:Windows.UI.Xaml.Media.Imaging.WriteableBitmap.PixelBuffer
-api-type: winrt property
ms.custom: project-verbatim
---

<!-- Property syntax
public Windows.Storage.Streams.IBuffer PixelBuffer { get; }
-->

# Windows.UI.Xaml.Media.Imaging.WriteableBitmap.PixelBuffer

## -description
Gets an access for the direct buffer where each pixel of the [WriteableBitmap](writeablebitmap.md) is written to.



## -property-value
A reference to the pixel buffer.

## -examples
This code example uses the **PixelBuffer** property of [WriteableBitmap](writeablebitmap.md) to write to its pixel content.

The C# example comes from a larger code sample&mdash;the SDK [XAML images sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/XAML%20images%20sample). The C# code shown is part of a transcoding scenario that eventually uses the [WriteableBitmap](writeablebitmap.md) as an [Image.Source](../windows.ui.xaml.controls/image_source.md) value, and displays the image.

The examples in the other languages are a little more scoped and/or self-contained.

```csharp
using (IRandomAccessStream fileStream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read)) 
{
    BitmapDecoder decoder = await BitmapDecoder.CreateAsync(fileStream); 
    // Scale image to appropriate size 
    BitmapTransform transform = new BitmapTransform() {  
        ScaledWidth = Convert.ToUInt32(Scenario4WriteableBitmap.PixelWidth), 
        ScaledHeight = Convert.ToUInt32(Scenario4WriteableBitmap.PixelHeight)
    }; 
    PixelDataProvider pixelData = await decoder.GetPixelDataAsync( 
        BitmapPixelFormat.Bgra8, // WriteableBitmap uses BGRA format 
        BitmapAlphaMode.Straight, 
        transform, 
        ExifOrientationMode.IgnoreExifOrientation, // This sample ignores Exif orientation 
        ColorManagementMode.DoNotColorManage
    ); 
 
    // An array containing the decoded image data, which could be modified before being displayed 
    byte[] sourcePixels = pixelData.DetachPixelData(); 
 
    // Open a stream to copy the image contents to the WriteableBitmap's pixel buffer 
    using (Stream stream = Scenario4WriteableBitmap.PixelBuffer.AsStream()) 
    { 
        await stream.WriteAsync(sourcePixels, 0, sourcePixels.Length); 
    }                     
}
```

```cppwinrt
// You'll need to add the Pictures Library capability to your Package.appxmanifest file.

// MainPage.xaml
...
<Image x:Name="anyExampleImage" Width="100" Height="100"/>
...

// pch.h
...
#include <winrt/Windows.Graphics.Imaging.h>
#include <winrt/Windows.Storage.Streams.h>
#include <winrt/Windows.UI.Xaml.Media.Imaging.h>
struct __declspec(uuid("905a0fef-bc53-11df-8c49-001e4fc686da")) IBufferByteAccess : ::IUnknown
{
    virtual HRESULT __stdcall Buffer(uint8_t** value) = 0;
};
...

// MainPage.h
...
struct MainPage : MainPageT<MainPage>
{
    ...
    Windows::Foundation::IAsyncAction ClickHandler(Windows::Foundation::IInspectable const&, Windows::UI::Xaml::RoutedEventArgs const&);
private:
    Windows::UI::Xaml::Media::Imaging::WriteableBitmap m_writeableBitmap{ nullptr };
};
...

// MainPage.cpp
...
Windows::Foundation::IAsyncAction MainPage::ClickHandler(IInspectable const&, RoutedEventArgs const&)
{
    uint32_t scaledSize = 100;
    m_writeableBitmap = Windows::UI::Xaml::Media::Imaging::WriteableBitmap(scaledSize, scaledSize);

    Windows::Storage::StorageFolder picturesFolder{ Windows::Storage::KnownFolders::PicturesLibrary() };
    auto anyExampleImageFile{ co_await picturesFolder.GetFileAsync(L"anyexampleimage.png") };
    Windows::Storage::Streams::IRandomAccessStream fileStream{ co_await anyExampleImageFile.OpenAsync(Windows::Storage::FileAccessMode::Read) };
    auto decoder{ co_await Windows::Graphics::Imaging::BitmapDecoder::CreateAsync(fileStream) };

    // Scale the image to the appropriate size.
    Windows::Graphics::Imaging::BitmapTransform transform;
    transform.ScaledWidth(scaledSize);
    transform.ScaledHeight(scaledSize);

    Windows::Graphics::Imaging::PixelDataProvider pixelData{ co_await decoder.GetPixelDataAsync(
        Windows::Graphics::Imaging::BitmapPixelFormat::Bgra8, // WriteableBitmap uses BGRA format 
        Windows::Graphics::Imaging::BitmapAlphaMode::Straight,
        transform,
        Windows::Graphics::Imaging::ExifOrientationMode::IgnoreExifOrientation, // This sample ignores Exif orientation 
        Windows::Graphics::Imaging::ColorManagementMode::DoNotColorManage
    ) };

    // An array containing the decoded image data, which could be modified before being displayed 
    winrt::com_array<uint8_t> sourcePixels{ pixelData.DetachPixelData() };

    // COMMENT OUT EXACTLY ONE OF TECHNIQUE 1/2
    // TECHNIQUE 1; QI for IBufferByteAccess.
    auto bufferByteAccess{ m_writeableBitmap.PixelBuffer().as<::IBufferByteAccess>() };
    uint8_t * pTargetBytes{ nullptr };
    bufferByteAccess->Buffer(&pTargetBytes);
    // TECHNIQUE 2; use a C++/WinRT helper function (and delete the definition of IBufferByteAccess in pch.h).
    //uint8_t * pTargetBytes{ m_writeableBitmap.PixelBuffer().data() };

    for (auto & element : sourcePixels)
    {
        *(pTargetBytes++) = element;
    }

    anyExampleImage().Source(m_writeableBitmap);
}
...
```

```cppcx
// pch.h
...
#include <robuffer.h>
...

// MainPage.xaml.cpp
auto writeableBitmap{ ref new Windows::UI::Xaml::Media::Imaging::WriteableBitmap(100, 100) };

::IUnknown* pUnk{ reinterpret_cast<IUnknown*>(writeableBitmap->PixelBuffer) };
Microsoft::WRL::ComPtr<Windows::Storage::Streams::IBufferByteAccess> bufferByteAccess;
HRESULT hr{ pUnk->QueryInterface(IID_PPV_ARGS(&bufferByteAccess)) };

byte *pBuffer{ nullptr };
bufferByteAccess->Buffer(&pBuffer);

// Now, write into the WriteableBitmap by using pBuffer. For example, make the first pixel red.
*pBuffer = 0xFF; ++pBuffer;
*pBuffer = 0xFF; ++pBuffer;
*pBuffer = 0x0; ++pBuffer;
*pBuffer = 0x0;
```

## -remarks

> [!NOTE]
> Use the **Language** picker (near the title) to choose a programming language for the code example.

The [IBuffer](/uwp/api/windows.storage.streams.ibuffer) returned by **PixelBuffer** can't be written to directly. But you can use language-specific techniques to write to the underlying pixel content in the buffer.

- To access the pixel content from C# or Microsoft Visual Basic, you can use the [WindowsRuntimeBufferExtensions.AsStream method](/dotnet/api/system.runtime.interopservices.windowsruntime.windowsruntimebufferextensions.asstream?view=dotnet-uwp-10.0&preserve-view=true) to access the underlying buffer as a stream. This is shown in the C# code example.
- To access the pixel content from C++/WinRT, you have three alternatives. As long as you're not `using namespace winrt;`, then you can include the SDK header file `robuffer.h` to bring in the definition of the [IBufferByteAccess](/previous-versions/hh846267(v%3Dvs.85)) COM interface. However, since `using namespace winrt;` is very common, you can alternatively define the **IBufferByteAccess** interface in one place in your project (see the C++/WinRT code example to see how). Once **IBufferByteAccess** is defined, using either of those two techniques, you can query **PixelBuffer** for an instance of **IBufferByteAccess**. You then call the [IBufferByteAccess::Buffer method](/previous-versions/hh846268%28v%3dvs.85%29) to retrieve a pointer to the buffer of bytes that represents the pixel content. This is shown in the C++/WinRT code example. The third alternative (also shown in the C++/WinRT code example) is to avoid using **IBufferByteAccess** altogether by retrieving the `uint8_t*` that's returned from a helper function that you can call with `WriteableBitmap.PixelBuffer().data()`.
- To access the pixel content from C++/CX, you can query **PixelBuffer** for the [IBufferByteAccess interface](/previous-versions/hh846267(v%3Dvs.85)), which is a COM interface. Include `robuffer.h`. You can then call the the [IBufferByteAccess::Buffer method](/previous-versions/hh846268%28v%3dvs.85%29) to retrieve a pointer to the buffer of bytes that represents the pixel content. This is shown in the C++/CX code example.

## -see-also
[BitmapSource](bitmapsource.md), [BitmapDecoder](../windows.graphics.imaging/bitmapdecoder.md), [IBuffer](/uwp/api/windows.storage.streams.ibuffer), [Windows.Graphics.Imaging namespace](../windows.graphics.imaging/windows_graphics_imaging.md), [XAML images sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/XAML%20images%20sample)
