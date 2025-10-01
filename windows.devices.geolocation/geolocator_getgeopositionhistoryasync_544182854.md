---
-api-id: M:Windows.Devices.Geolocation.Geolocator.GetGeopositionHistoryAsync(Windows.Foundation.DateTime,Windows.Foundation.TimeSpan)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Foundation.Collections.IVectorView<Windows.Devices.Geolocation.Geoposition>> GetGeopositionHistoryAsync(Windows.Foundation.DateTime startTime, Windows.Foundation.TimeSpan duration)
-->

# Windows.Devices.Geolocation.Geolocator.GetGeopositionHistoryAsync

## -description

> [!IMPORTANT]
> The `Geolocator.GetGeopositionHistoryAsync` method is deprecated as of SDK version 10.0.26100.3037 and will be removed entirely in a future version.

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

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 24H2 | 26100.3037 | Method deprecated |
| 24H2 | 26100.3323 | Returns errors |

## -examples

## -see-also

[Geolocation sample](https://github.com/microsoft/Windows-universal-samples/tree/main/Samples/Geolocation),
[Get current location](/windows/uwp/maps-and-location/get-location),
[GetGeopositionHistoryAsync(DateTime)](geolocator_getgeopositionhistoryasync_1254824286.md),
[Set up a geofence](/windows/uwp/maps-and-location/set-up-a-geofence)

## -capabilities

locationHistory
location
