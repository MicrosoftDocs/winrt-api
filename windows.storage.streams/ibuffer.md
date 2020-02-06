---
-api-id: T:Windows.Storage.Streams.IBuffer
-api-type: winrt interface
---

<!-- Interface syntax.
public interface IBuffer : 
-->

# Windows.Storage.Streams.IBuffer

## -description
Represents a referenced array of bytes used by byte stream read and write interfaces. [Buffer](buffer.md) is the class implementation of this interface.

## -remarks
For more info, see [Create, write, and read a file](https://docs.microsoft.com/windows/uwp/files/quickstart-reading-and-writing-files), which shows how to read and write bytes to a file by using a [Buffer](buffer.md).

[WriteableBitmap.PixelBuffer](/uwp/api/windows.ui.xaml.media.imaging.writeablebitmap.pixelbuffer) is an example of a property that returns an **IBuffer** that can't be written to directly. See that topic for a language-specific code example showing to write to the underlying pixel content in the buffer.

## -examples

This code example shows how to retrieve a string from an **IBuffer** of UTF-8 bytes.

```csharp
public string RetrieveStringFromUtf8IBuffer(Windows.Storage.Streams.IBuffer theBuffer)
{
    using (var dataReader = Windows.Storage.Streams.DataReader.FromBuffer(theBuffer))
    {
        dataReader.UnicodeEncoding = Windows.Storage.Streams.UnicodeEncoding.Utf8;
        return dataReader.ReadString(theBuffer.Length);
    }
}
```

## -see-also
[Create, write, and read a file](https://docs.microsoft.com/windows/uwp/files/quickstart-reading-and-writing-files), [Buffer class](buffer.md), [WriteableBitmap.PixelBuffer](/uwp/api/windows.ui.xaml.media.imaging.writeablebitmap.pixelbuffer)