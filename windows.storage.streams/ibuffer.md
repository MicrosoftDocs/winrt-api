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

This interface is used for resizing the buffer while preserving the contents. If your C++/WinRT class implements `IBuffer` and does not need or support resizing, you should throw [hresult_not_implemented](/uwp/cpp-ref-for-winrt/error-handling/hresult-not-implemented).

For more info, see [Create, write, and read a file](/windows/uwp/files/quickstart-reading-and-writing-files), which shows how to read and write bytes to a file by using a [Buffer](buffer.md).

[WriteableBitmap.PixelBuffer](/uwp/api/windows.ui.xaml.media.imaging.writeablebitmap.pixelbuffer) is an example of a property that returns an **IBuffer** that can't be written to directly. See that topic for a language-specific code example showing to write to the underlying pixel content in the buffer.

### C++/WinRT extension functions

> [!NOTE]
> Extension functions exist on the C++/WinRT projection types for certain Windows Runtime APIs. For example, **winrt::Windows::Foundation::IAsyncAction** is the C++/WinRT projection type for [IAsyncAction](/uwp/api/windows.foundation.iasyncaction). The extension functions aren't part of the application binary interface (ABI) surface of the actual Windows Runtime types, so they're not listed as members of the Windows Runtime APIs. But you can call them from within any C++/WinRT project. See [C++/WinRT functions that extend Windows Runtime APIs](/uwp/cpp-ref-for-winrt/winrt#cwinrt-functions-that-extend-windows-runtime-apis).

```cppwinrt
uint8_t* data() const;
```

Returns a pointer to the data held inside the buffer.

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

[Create, write, and read a file](/windows/uwp/files/quickstart-reading-and-writing-files), [Buffer class](buffer.md), [WriteableBitmap.PixelBuffer](/uwp/api/windows.ui.xaml.media.imaging.writeablebitmap.pixelbuffer)
