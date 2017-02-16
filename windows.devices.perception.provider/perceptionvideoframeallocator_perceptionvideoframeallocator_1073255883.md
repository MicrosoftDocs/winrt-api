---
-api-id: M:Windows.Devices.Perception.Provider.PerceptionVideoFrameAllocator.#ctor(System.UInt32,Windows.Graphics.Imaging.BitmapPixelFormat,Windows.Foundation.Size,Windows.Graphics.Imaging.BitmapAlphaMode)
-api-type: winrt method
---

<!-- Method syntax
public PerceptionVideoFrameAllocator(System.UInt32 maxOutstandingFrameCountForWrite, Windows.Graphics.Imaging.BitmapPixelFormat format, Windows.Foundation.Size resolution, Windows.Graphics.Imaging.BitmapAlphaMode alpha)
-->

# Windows.Devices.Perception.Provider.PerceptionVideoFrameAllocator.PerceptionVideoFrameAllocator

## -description
Initializes a new PerceptionVideoFrameAllocator with the required properties for use by the IPerceptionFrameProvider to create PerceptionFrames published via PerceptionFrameProviderManagerService::PublishFrameForProvider.

## -parameters
### -param maxOutstandingFrameCountForWrite
This is the number of buffers in flight required by the FrameProvider to produce its * frames at framerate. The suggestion is at least 2.

### -param format
The Windows::Graphics::Imaging::BitmapPixelFormat describing the format of the bytes of the frame.

### -param resolution
The resolution in pixels of the frame.

### -param alpha
The Windows::Graphics::Imaging::BitmapAlphaMode describing how transparency is handled in the pixels.

## -remarks

## -examples

## -see-also
