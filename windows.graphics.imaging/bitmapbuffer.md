---
-api-id: T:Windows.Graphics.Imaging.BitmapBuffer
-api-type: winrt class
---

<!-- Class syntax.
public class BitmapBuffer : Windows.Foundation.IClosable, Windows.Foundation.IMemoryBuffer, Windows.Graphics.Imaging.IBitmapBuffer
-->

# Windows.Graphics.Imaging.BitmapBuffer

## -description
Represents the pixel data buffer of a bitmap.

## -remarks
Get an instance of this class by calling [SoftwareBitmap.LockBuffer](softwarebitmap_lockbuffer_109667063.md). Because the **BitmapBuffer** represents an exclusive lock on the associated bitmap, apps should not keep the reference to it indefinitely.

## -examples

## -see-also
[IMemoryBuffer](../windows.foundation/imemorybuffer.md), [IClosable](../windows.foundation/iclosable.md)
