---
-api-id: E:Windows.Devices.PointOfService.Provider.BarcodeScannerFrameReader.FrameArrived
-api-type: winrt event
ms.custom: RS5
---

<!-- Event syntax.
public event TypedEventHandler FrameArrived<BarcodeScannerFrameReader, BarcodeScannerFrameReaderFrameArrivedEventArgs>
-->

# Windows.Devices.PointOfService.Provider.BarcodeScannerFrameReader.FrameArrived

## -description
Event that is raised when a frame is ready to be acquired. This event will not be raised until the frame reader is started by using [StartAsync](barcodescannerframereader_startasync_1931900819.md).

## -remarks
To acquire a frame after it arrives, call [TryAcquireLatestFrameAsync](barcodescannerframereader_tryacquirelatestframeasync_555563326.md). Note that calling **TryAcquireLatestFrameAsync** will always return the latest frame, not the frame that caused this event to be raised.

Use [BarcodeScannerFrameReaderFrameArrivedEventArgs.GetDeferral](barcodescannerframereaderframearrivedeventargs_getdeferral_254836512.md) if processing needs to be done asynchronously outside the scope of the method handler.

## -see-also
[TryAcquireLatestFrameAsync](barcodescannerframereader_tryacquirelatestframeasync_555563326.md)

## -examples

