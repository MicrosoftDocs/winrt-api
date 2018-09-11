---
-api-id: E:Windows.Devices.PointOfService.ClaimedPosPrinter.ReleaseDeviceRequested
-api-type: winrt event
-api-device-family-note: xbox
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler ReleaseDeviceRequested<Windows.Devices.PointOfService.ClaimedPosPrinter,  Windows.Devices.PointOfService.PosPrinterReleaseDeviceRequestedEventArgs>
-->

# Windows.Devices.PointOfService.ClaimedPosPrinter.ReleaseDeviceRequested

## -description
Occurs when a point-of-service printer gets a request to release its exclusive claim.

## -remarks
When this event occurs, the app has a two-second window of time to call the [RetainDeviceAsync](claimedposprinter_retaindeviceasync_1460106534.md) so that the app can keep exclusive claim on the device. Alternatively, the app can call [Close](claimedposprinter_close_811482585.md) to release the claim and end the window immediately.

## -examples

## -see-also
[PosPrinterReleaseDeviceRequestedEventArgs](posprinterreleasedevicerequestedeventargs.md), [RetainDeviceAsync](claimedposprinter_retaindeviceasync_1460106534.md), [Close](claimedposprinter_close_811482585.md)