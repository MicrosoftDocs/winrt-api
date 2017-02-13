---
-api-id: M:Windows.Devices.Geolocation.Geolocator.GetGeopositionHistoryAsync(Windows.Foundation.DateTime,Windows.Foundation.TimeSpan)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Foundation.Collections.IVectorView<Windows.Devices.Geolocation.Geoposition>> GetGeopositionHistoryAsync(Windows.Foundation.DateTime startTime, Windows.Foundation.TimeSpan duration)
-->

# Windows.Devices.Geolocation.Geolocator.GetGeopositionHistoryAsync

## -description
Starts an asynchronous operation to retrieve the location history of the device.

> [!NOTE]
> This API is not available to all Windows apps. Unless your developer account is specially provisioned by Microsoft, calls to these APIs will fail at runtime.

## -parameters
### -param startTime
Represents the beginning of the time span for which positions are to be returned.

### -param duration
Represents the length of time after *startTime* for which positions are to be returned.

## -returns
Positions (of type [Geoposition](geoposition.md)) that were collected during the specified time span.

## -remarks
Only positions that were collected during the specified *duration* after *startTime* will be returned.

## -examples

## -see-also
[Get current location](http://msdn.microsoft.com/library/24dc9a41-8cc1-48b0-bc6d-24bf571afcc8), [Set up a geofence](http://msdn.microsoft.com/library/a3a46e03-0751-4dbd-a2a1-2323db09bdba), [GetGeopositionHistoryAsync(DateTime)](geolocator_getgeopositionhistoryasync_1254824286.md), [geolocation sample](http://go.microsoft.com/fwlink/p/?linkid=533278)

## -capabilities
locationHistory