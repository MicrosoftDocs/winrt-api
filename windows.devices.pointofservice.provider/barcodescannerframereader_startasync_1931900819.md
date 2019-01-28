---
-api-id: M:Windows.Devices.PointOfService.Provider.BarcodeScannerFrameReader.StartAsync
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax.
public IAsyncOperation<bool> BarcodeScannerFrameReader.StartAsync()
-->

# Windows.Devices.PointOfService.Provider.BarcodeScannerFrameReader.StartAsync

## -description
Starts reading video frames from the camera.

## -returns
Asynchronous operation.

## -remarks
Subscribe to the [FrameArrived](barcodescannerframereader_framearrived.md) event to be notified when new frames arrive, and call [TryAcquireLatestFrameAsync](barcodescannerframereader_tryacquirelatestframeasync_555563326.md) to read the latest frame at any given time.

## -see-also
[StopAsync](barcodescannerframereader_stopasync_1648475005.md)

## -examples

