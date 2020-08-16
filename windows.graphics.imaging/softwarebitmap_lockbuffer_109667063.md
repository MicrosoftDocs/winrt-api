---
-api-id: M:Windows.Graphics.Imaging.SoftwareBitmap.LockBuffer(Windows.Graphics.Imaging.BitmapBufferAccessMode)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Graphics.Imaging.BitmapBuffer LockBuffer(Windows.Graphics.Imaging.BitmapBufferAccessMode mode)
-->

# Windows.Graphics.Imaging.SoftwareBitmap.LockBuffer

## -description
Gets a [BitmapBuffer](bitmapbuffer.md) object that allows you to operate directly on the software bitmap's pixel data.

## -parameters
### -param mode
A value indicating the access mode of the returned buffer.

## -returns
The buffer containing pixel data.

## -remarks

Because the returned **BitmapBuffer** represents an exclusive lock on the associated bitmap, apps should not keep the reference to it indefinitely.

## -examples

## -see-also
