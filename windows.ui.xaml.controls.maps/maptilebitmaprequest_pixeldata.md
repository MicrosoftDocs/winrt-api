---
-api-id: P:Windows.UI.Xaml.Controls.Maps.MapTileBitmapRequest.PixelData
-api-type: winrt property
---

<!-- Property syntax
public Windows.Storage.Streams.IRandomAccessStreamReference PixelData { get;  set; }
-->

# Windows.UI.Xaml.Controls.Maps.MapTileBitmapRequest.PixelData

## -description
Gets the bitmap data for the [CustomMapTileDataSource](custommaptiledatasource_custommaptiledatasource_1221375020.md).

## -property-value
The bitmap data.

## -remarks
[CustomMapTileDataSource](custommaptiledatasource_custommaptiledatasource_1221375020.md) supports drawing tiles in memory and returning them as a stream of pixels. The following code sample demonstrates one approach for drawing tiles in memory.

```csharp
        // Create new custom tile source
        CustomMapTileDataSource customDataSource = new CustomMapTileDataSource();
        customDataSource.BitmapRequested += customDataSource_BitmapRequestedAsync;
        customTileSource = new MapTileSource(customDataSource);

        /// <summary>
        /// BitmapRequested event handler for CustomMapTileDataSource.BitmapRequested event
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="args">args for ZoomLevel, X, Y and the PixelData</param>
        private async void customDataSource_BitmapRequestedAsync(CustomMapTileDataSource sender, MapTileBitmapRequestedEventArgs args)
        {
            var deferral = args.Request.GetDeferral();
            args.Request.PixelData = await CreateBitmapAsStreamAsync();
            deferral.Complete();
        }

        /// <summary>
        /// Create memory buffer with length of 256 * 256 * 4.  
        /// This memory buffer is holding 256 * 256 pixels
        /// </summary>
        /// <returns>memory buffer that fills with red opaque pixels.</returns>
        private async Task<Windows.Storage.Streams.RandomAccessStreamReference> CreateBitmapAsStreamAsync()
        {
            int pixelHeight = 256;
            int pixelWidth = 256;
            int bpp = 4;

            byte[] bytes = new byte[pixelHeight * pixelWidth * bpp];

            for (int y = 0; y < pixelHeight; y++)
            {
                for (int x = 0; x < pixelWidth; x++)
                {
                    int pixelIndex = y * pixelWidth + x;
                    int byteIndex = pixelIndex * bpp;

                    bytes[byteIndex] = 0xff;        // Red
                    bytes[byteIndex + 1] = 0x00;    // Green
                    bytes[byteIndex + 2] = 0x00;    // Blue
                    bytes[byteIndex + 3] = 0x80;    // Alpha (0xff = fully opaque)
                }
            }

            // Create RandomAccessStream from byte array
            InMemoryRandomAccessStream randomAccessStream = new InMemoryRandomAccessStream();
            IOutputStream outputStream = randomAccessStream.GetOutputStreamAt(0);
            DataWriter writer = new DataWriter(outputStream);
            writer.WriteBytes(bytes);
            await writer.StoreAsync();
            await writer.FlushAsync();
            return RandomAccessStreamReference.CreateFromStream(randomAccessStream);
        }
```

```cppwinrt
Windows::Foundation::IAsyncOperation<Windows::Storage::Streams::InMemoryRandomAccessStream> TileSources::CustomRandomAccessStreamAsync()
{
    const int pixelHeight{ 256 };
    const int pixelWidth{ 256 };
    const int bpp{ 4 };

    std::array<byte, pixelHeight * pixelWidth * bpp> bytes;

    for (int y = 0; y < pixelHeight; ++y)
    {
        for (int x = 0; x < pixelWidth; ++x)
        {
            int pixelIndex = y * pixelWidth + x;
            int byteIndex = pixelIndex * bpp;

            // Set current pixel bytes
            bytes[byteIndex] = (byte)(std::rand() % 256);        // Red
            bytes[byteIndex + 1] = (byte)(std::rand() % 256);    // Green
            bytes[byteIndex + 2] = (byte)(std::rand() % 256);    // Blue
            bytes[byteIndex + 3] = (byte)((std::rand() % 56) + 200);    // Alpha (0xff = fully opaque)
        }
    }

    // Create RandomAccessStream from byte array
    Windows::Storage::Streams::InMemoryRandomAccessStream randomAccessStream;
    Windows::Storage::Streams::IOutputStream outputStream{ randomAccessStream.GetOutputStreamAt(0) };
    Windows::Storage::Streams::DataWriter writer{ outputStream };
    writer.WriteBytes(bytes);

    co_await writer.StoreAsync();
    co_await writer.FlushAsync();

    co_return randomAccessStream;
}
```

```cppcx
InMemoryRandomAccessStream^ TileSources::CustomRandomAccessStream::get()
{
       int pixelHeight = 256;
       int pixelWidth = 256;
       int bpp = 4;
 
       Array<byte>^ bytes = ref new Array<byte>(pixelHeight * pixelWidth * bpp);
       
       for (int y = 0; y < pixelHeight; y++)
       {
              for (int x = 0; x < pixelWidth; x++)
              {
                     int pixelIndex = y * pixelWidth + x;
                     int byteIndex = pixelIndex * bpp;
 
                     // Set current pixel bytes
                     bytes[byteIndex] = (byte)(std::rand() % 256);        // Red
                     bytes[byteIndex + 1] = (byte)(std::rand() % 256);    // Green
                     bytes[byteIndex + 2] = (byte)(std::rand() % 256);    // Blue
                     bytes[byteIndex + 3] = (byte)((std::rand() % 56) + 200);    // Alpha (0xff = fully opaque)
              }
       }
 
       // Create RandomAccessStream from byte array
       InMemoryRandomAccessStream^ randomAccessStream = ref new InMemoryRandomAccessStream();
       IOutputStream^ outputStream = randomAccessStream->GetOutputStreamAt(0);
       DataWriter^ writer = ref new DataWriter(outputStream);
       writer->WriteBytes(bytes);
 
       create_task(writer->StoreAsync()).then([writer](unsigned int)
       {
              create_task(writer->FlushAsync());
       });
 
       return randomAccessStream;
}
```

## -examples

## -see-also
[Overlay tiled images on a map](/windows/uwp/maps-and-location/overlay-tiled-images)
