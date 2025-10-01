---
-api-id: T:Windows.Devices.Geolocation.Geolocator
-api-type: winrt class
---

<!-- Class syntax.
public class Geolocator : Windows.Devices.Geolocation.IGeolocator, Windows.Devices.Geolocation.IGeolocator2, Windows.Devices.Geolocation.IGeolocatorWithScalarAccuracy
-->

# Windows.Devices.Geolocation.Geolocator

## -description

Provides access to the current geographic location.

## -remarks

The [Geolocator](geolocator.md) class is the primary entry point for accessing location data in Windows applications.
It provides both one-time location requests and continuous location tracking through events.

### Key properties and methods

- [RequestAccessAsync](geolocator_requestaccessasync_380675631.md): Request permission to access location data.
  Always call this before attempting to get location.
- [GetGeopositionAsync](geolocator_getgeopositionasync_189682258.md): Get the current location as a one-time request.
- [PositionChanged](geolocator_positionchanged.md): Event that fires when the device location changes during continuous
  tracking.
- [StatusChanged](geolocator_statuschanged.md): Event that fires when location permissions or service availability
  changes.
- [DesiredAccuracy](geolocator_desiredaccuracy.md) and [DesiredAccuracyInMeters](geolocator_desiredaccuracyinmeters.md):
  Control the accuracy and power consumption tradeoff.

### Permission and privacy considerations

> [!IMPORTANT]
> Always call [RequestAccessAsync](geolocator_requestaccessasync_380675631.md) before attempting to access location data.
> Your app must be in the foreground when requesting access, and the request must be made from the UI thread.


Location access can be denied by the user or disabled by system policy. Handle
[GeolocationAccessStatus.Denied](geolocationaccessstatus.md) appropriately in your app logic.

### Accuracy and power management

The location service balances accuracy with battery consumption. Use [DesiredAccuracy.Default](positionaccuracy.md) for
most scenarios, or specify [DesiredAccuracyInMeters](geolocator_desiredaccuracyinmeters.md) when you need specific
precision requirements.

Key considerations:
- Single-shot requests ([GetGeopositionAsync](geolocator_getgeopositionasync_189682258.md)) have lower battery impact per
  request.
- Continuous tracking ([PositionChanged](geolocator_positionchanged.md) events) significantly drains battery and should
  be used sparingly.
- Lower [ReportInterval](geolocator_reportinterval.md) values (< 30 seconds) increase power consumption exponentially.
- Higher [MovementThreshold](geolocator_movementthreshold.md) values (> 50 meters) reduce GNSS activation frequency.

> [!TIP]
> For battery-sensitive applications, start with [DesiredAccuracy.Default](positionaccuracy.md) and a
> [MovementThreshold](geolocator_movementthreshold.md) of 50+ meters. Monitor actual accuracy in your scenarios and
> adjust only if necessary.

> [!IMPORTANT]
> Continuous location tracking can significantly impact battery life. Always provide users with clear information about
> location usage and consider offering settings to control tracking frequency.

### Threading behavior

> [!NOTE]
> Location events fire on background threads. Use appropriate thread marshalling mechanisms when updating UI or
> performing thread-sensitive operations in event handlers.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1607 | 14393 | AllowFallbackToConsentlessPositions |
| 1607 | 14393 | DefaultGeoposition |
| 1607 | 14393 | IsDefaultGeopositionRecommended |

## -examples

### Basic location access with permission handling

This example shows how to request location access and get the current position with proper error handling.

```csharp
using Windows.Devices.Geolocation;

private async Task GetCurrentLocationAsync()
{
    // Always request access first
    var accessStatus = await Geolocator.RequestAccessAsync();

    switch (accessStatus)
    {
        case GeolocationAccessStatus.Allowed:
            var geolocator = new Geolocator
            {
                DesiredAccuracy = PositionAccuracy.Default
            };

            try
            {
                var position = await geolocator.GetGeopositionAsync();
                var coordinate = position.Coordinate;

                // Use location data for app functionality
                Console.WriteLine($"Location: {coordinate.Latitude:F6}, {coordinate.Longitude:F6}");
                Console.WriteLine($"Accuracy: {coordinate.Accuracy:F0} meters");
                Console.WriteLine($"Source: {coordinate.PositionSource}");

                // App-specific: update map, search nearby places, etc.
            }
            catch (UnauthorizedAccessException)
            {
                // Location access was revoked during the operation
                Console.WriteLine("Location access was denied or revoked");
            }
            catch (Exception ex) when (ex.Message.Contains("timeout") || ex.Message.Contains("unavailable"))
            {
                // Location service timed out or unavailable
                Console.WriteLine("Location service is currently unavailable");
            }
            catch (Exception)
            {
                // Other location service errors
                Console.WriteLine("Unable to retrieve location at this time");
            }
            break;

        case GeolocationAccessStatus.Denied:
            // App-specific: show explanation and guide user to settings
            Console.WriteLine("Location access denied. Enable location in Settings > Privacy & Security > Location.");
            break;

        case GeolocationAccessStatus.Unspecified:
            Console.WriteLine("Location access error occurred");
            break;
    }
}
```

### Continuous location tracking with status monitoring

This C++/WinRT example demonstrates continuous location tracking with proper event handling and resource management.

```cpp
#include <winrt/Windows.Devices.Geolocation.h>
#include <winrt/Windows.Foundation.h>

using namespace winrt;
using namespace Windows::Devices::Geolocation;
using namespace Windows::Foundation;

class LocationTracker
{
private:
    Geolocator m_geolocator{ nullptr };
    event_token m_positionChangedToken;
    event_token m_statusChangedToken;

public:
    IAsyncAction StartTrackingAsync()
    {
        auto accessStatus = co_await Geolocator::RequestAccessAsync();

        if (accessStatus == GeolocationAccessStatus::Allowed)
        {
            m_geolocator = Geolocator();
            m_geolocator.DesiredAccuracyInMeters(50); // 50-meter accuracy
            m_geolocator.MovementThreshold(10);       // Update every 10 meters

            // Set up event handlers
            m_positionChangedToken = m_geolocator.PositionChanged(
                { this, &LocationTracker::OnPositionChanged });
            m_statusChangedToken = m_geolocator.StatusChanged(
                { this, &LocationTracker::OnStatusChanged });
        }
        co_return;
    }

    void StopTracking()
    {
        if (m_geolocator)
        {
            // Unsubscribe using remove_* pattern per C++/WinRT conventions
            m_geolocator.remove_PositionChanged(m_positionChangedToken);
            m_geolocator.remove_StatusChanged(m_statusChangedToken);
            m_geolocator = nullptr;
        }
    }

private:
    void OnPositionChanged(Geolocator const&, PositionChangedEventArgs const& args)
    {
        auto coordinate = args.Position().Coordinate();

        // App-specific: update tracking display, log position, etc.
        // Note: This runs on a background thread
    }

    void OnStatusChanged(Geolocator const&, StatusChangedEventArgs const& args)
    {
        switch (args.Status())
        {
            case PositionStatus::Ready:
                // Location service is available
                break;
            case PositionStatus::NoData:
                // Location service temporarily unavailable
                break;
            case PositionStatus::Disabled:
                // Location service disabled by user or policy
                break;
        }
    }
};
```

## -see-also

[Geocoordinate](geocoordinate.md),
[GeolocationAccessStatus](geolocationaccessstatus.md),
[Geolocation sample](https://github.com/microsoft/Windows-universal-samples/tree/main/Samples/Geolocation),
[Geoposition](geoposition.md),
[Get current location](/windows/uwp/maps-and-location/get-location),
[PositionAccuracy](positionaccuracy.md),
[PositionStatus](positionstatus.md)

## -capabilities

location
