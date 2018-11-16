---
-api-id: M:Windows.Devices.PointOfService.Provider.BarcodeScannerFrameReader.TryAcquireLatestFrameAsync
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax.
public IAsyncOperation<BarcodeScannerVideoFrame> BarcodeScannerFrameReader.TryAcquireLatestFrameAsync()
-->

# Windows.Devices.PointOfService.Provider.BarcodeScannerFrameReader.TryAcquireLatestFrameAsync

## -description
Acquires the latest available frame from the camera.

## -returns
A [BarcodeScannerVideoFrame](barcodescannervideoframe.md) containing data for the latest video frame.

## -remarks
Only the first call to **TryAcquireLatestFrameAsync** will return data. Subsequent calls will return **null** until a new frame arrives. Subscribe to the [FrameArrived](barcodescannerframereader_framearrived.md) event to be notified when new frames arrive.

## -see-also

## -examples

