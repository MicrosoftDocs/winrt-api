---
-api-id: M:Windows.Graphics.Capture.Direct3D11CaptureFramePool.CreateFreeThreaded(Windows.Graphics.DirectX.Direct3D11.IDirect3DDevice,Windows.Graphics.DirectX.DirectXPixelFormat,System.Int32,Windows.Graphics.SizeInt32)
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax.
public Direct3D11CaptureFramePool Direct3D11CaptureFramePool.CreateFreeThreaded(IDirect3DDevice device, DirectXPixelFormat pixelFormat, Int32 numberOfBuffers, SizeInt32 size)
-->

# Windows.Graphics.Capture.Direct3D11CaptureFramePool.CreateFreeThreaded

## -description

Creates a frame pool where the dependency on the [DispatcherQueue](direct3d11captureframepool_dispatcherqueue.md) is removed and the [FrameArrived](direct3d11captureframepool_framearrived.md) event is raised on the frame pool's internal worker thread.

## -parameters

### -param device

The Direct3D device.

### -param pixelFormat

The DirectX pixel format of the captured frames.

### -param numberOfBuffers

The number of buffers in which to store captured frames.

### -param size

The size of each buffer.

## -returns

A frame pool created with the given inputs.

## -remarks

## -see-also

[Windows.Graphics.Capture.Direct3D11CaptureFramePool class](direct3d11captureframepool.md),
[Windows.Graphics.Capture namespace](windows_graphics_capture.md),
[Windows.System.DispatcherQueue class](../windows.system/dispatcherqueue.md),
[Screen capture](/windows/uwp/audio-video-camera/screen-capture)

## -examples
