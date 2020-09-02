---
-api-id: M:Windows.Graphics.Imaging.PixelDataProvider.DetachPixelData
-api-type: winrt method
---

<!-- Method syntax
public byte[] DetachPixelData()
-->

# Windows.Graphics.Imaging.PixelDataProvider.DetachPixelData

## -description
Returns the internally-stored pixel data.

## -returns
The pixel data.

## -remarks
[PixelDataProvider](pixeldataprovider.md) doesn't retain a copy of the pixel data after a successful call to this method. This means that subsequent calls to the method will fail.

If you are using the [Windows Runtime C++ Template Library (WRL)](/cpp/windows/windows-runtime-cpp-template-library-wrl), you are responsible for releasing the underlying memory for the pixel data. Call [CoTaskMemFree](/windows/desktop/api/combaseapi/nf-combaseapi-cotaskmemfree) after you are done with the data. If you are using a language projection such as C# or C++/WinRT, memory management is handled automatically.

The return value is an array of 8 bit unsigned values. However, depending on the requested pixel format, the pixel data may represent another type. For example, if the pixel format is Rgba16, then each color value is a 16 bit unsigned integer that takes up two 8 bit elements of the array. You must convert the array to the correct type before you use it.

## -examples

## -see-also
