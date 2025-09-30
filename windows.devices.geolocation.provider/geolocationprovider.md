---
-api-id: T:Windows.Devices.Geolocation.Provider.GeolocationProvider
-api-type: winrt class
---

# Windows.Devices.Geolocation.Provider.GeolocationProvider

<!--
public sealed class GeolocationProvider
-->

## -description

Provides the ability to override the user's location from a remote source.

> [!NOTE]
> To call location-override APIs, an app must declare the `runFullTrust`
> [restricted capability](/windows/uwp/packaging/app-capability-declarations#custom-capabilities).

> [!IMPORTANT]
> The [Windows.Devices.Geolocation.Provider](/uwp/api/windows.devices.geolocation.provider.geolocationprovider) APIs are
> part of a Limited Access Feature (see
> [LimitedAccessFeatures class](/uwp/api/windows.applicationmodel.limitedaccessfeatures)). For more information or to
> request an unlock token, please use the
> [LAF Access Token Request Form](https://go.microsoft.com/fwlink/?linkid=2271232&clcid=0x409).

## -remarks

You should access a `GeolocationProvider` object from the context of the user for whom location is to be overridden
and provided to location-aware apps. The length of a location override session is bound by calls to
[SetOverridePosition](geolocationprovider_setoverrideposition_807670976.md) and
[ClearOverridePosition](geolocationprovider_clearoverrideposition_399430586.md). Once a session starts successfully,
other entities can't obtain override functionality until the original object is cleared.

### Common use cases

Location override is designed primarily for remote connection scenarios where the physical device location doesn't
match the user's actual location. Common implementations include:

- Remote access applications that need to provide the client's location context
- Virtualization environments where guest systems need host location context
- Testing and development scenarios requiring controlled location data

Override sessions apply across all app types that consume Windows geolocation services, ensuring consistent location
experience regardless of how apps access location data.

### Position source considerations

When setting override positions, consider the appropriate
[PositionSource](../windows.devices.geolocation/positionsource.md) value:

- Use `PositionSource.Cellular` or `PositionSource.WiFi` for typical remote connection scenarios.
- Use `PositionSource.Satellite` when providing GNSS-quality location data.
- Applications can detect override sessions through the
  [IsRemoteSource](../windows.devices.geolocation/geocoordinate_isremotesource.md) property.

> [!NOTE]
> Location override is distinct from obfuscated positioning. Override provides actual location data from a remote
> source, while obfuscated positions intentionally reduce accuracy for privacy protection.

### Error handling and recovery

Location override operations can fail for various reasons. Applications should implement comprehensive error handling
for all [LocationOverrideStatus](locationoverridestatus.md) values:

- `LocationOverrideStatus.Success`: Override was established successfully.
- `LocationOverrideStatus.AccessDenied`: Application lacks necessary permissions or capabilities.
- `LocationOverrideStatus.AlreadyStarted`: Another process currently holds override control.
- `LocationOverrideStatus.Other`: System-level error or unexpected failure condition.

> [!IMPORTANT]
> Applications should validate position data before setting overrides and implement retry logic for transient failures.
> Clean up override sessions when remote connections are lost and handle permission revocation gracefully.

### Session lifecycle management

Override sessions require careful lifecycle management throughout the application's operation:

- Initialize override sessions when remote connections are established.
- Monitor session state using the `GeolocationProvider.IsOverriddenChanged` event to detect when other processes terminate
    your override.
- Clean up sessions during application suspension, connection loss, or unexpected termination.
- Implement proper disposal patterns for long-running override sessions.

> [!NOTE]
> The `GeolocationProvider.IsOverriddenChanged` event fires when the override state changes, including when another
> process clears your override session or when system-level location services become unavailable.

### Background operations

When implementing location override in background scenarios, applications should handle async operations with proper
cancellation support and resource cleanup. Use appropriate thread marshalling mechanisms when interfacing with
thread-sensitive operations.

### Thread safety considerations

Location override operations may be called from multiple threads in complex applications. Implement appropriate
synchronization when managing override sessions across concurrent operations, especially when handling connection
state changes and cleanup operations.

## -examples

This example demonstrates essential error handling and session management patterns for location override operations:

```csharp
using Windows.Devices.Geolocation;
using Windows.Devices.Geolocation.Provider;

public class RemoteLocationManager
{
    private GeolocationProvider geolocationProvider;

    public bool InitializeLocationOverride(BasicGeoposition position)
    {
        try
        {
            geolocationProvider = new GeolocationProvider();
            geolocationProvider.IsOverriddenChanged += OnIsOverriddenChanged;

            var status = geolocationProvider.SetOverridePosition(
                position, PositionSource.Cellular, 10.0);

            switch (status)
            {
                case LocationOverrideStatus.Success:
                    return true;

                case LocationOverrideStatus.AccessDenied:
                    // App-specific: handle permission denial
                    return false;

                case LocationOverrideStatus.AlreadyStarted:
                    // Another process has override control
                    return false;

                case LocationOverrideStatus.Other:
                    // App-specific: handle unexpected failures
                    return false;
            }
        }
        catch (UnauthorizedAccessException)
        {
            // Handle permission revocation during operation
            CleanupSession();
            return false;
        }

        return false;
    }

    private void OnIsOverriddenChanged(object sender, object args)
    {
        if (geolocationProvider?.IsOverridden == false)
        {
            // App-specific: handle session termination
        }
    }

    private void CleanupSession()
    {
        geolocationProvider?.ClearOverridePosition();
        if (geolocationProvider != null)
        {
            geolocationProvider.IsOverriddenChanged -= OnIsOverriddenChanged;
        }
    }
}
```

For comprehensive examples including background operations, error recovery, and advanced patterns, see the [Geolocation sample](https://github.com/microsoft/Windows-universal-samples/tree/main/Samples/Geolocation).

## -see-also

[BasicGeoposition](../windows.devices.geolocation/basicgeoposition.md),
[ClearOverridePosition](geolocationprovider_clearoverrideposition_399430586.md),
[GeolocationProvider.IsOverridden](geolocationprovider_isoverridden.md),
[GeolocationProvider.IsOverriddenChanged](geolocationprovider_isoverriddenchanged.md),
[Geolocator](../windows.devices.geolocation/geolocator.md),
[LocationOverrideStatus](locationoverridestatus.md),
[PositionSource](../windows.devices.geolocation/positionsource.md),
[SetOverridePosition](geolocationprovider_setoverrideposition_807670976.md)

## -capabilities
runFullTrust
