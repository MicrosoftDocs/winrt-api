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
> To call location-override APIs, an app must declare the `runFullTrust` [restricted capability](/windows/uwp/packaging/app-capability-declarations#custom-capabilities).

> [!IMPORTANT]
> The [Windows.Devices.Geolocation.Provider](/uwp/api/windows.devices.geolocation.provider.geolocationprovider) APIs are part of a Limited Access Feature (see [LimitedAccessFeatures class](/uwp/api/windows.applicationmodel.limitedaccessfeatures)). For more information or to request an unlock token, please use the [LAF Access Token Request Form](https://go.microsoft.com/fwlink/?linkid=2271232&clcid=0x409).

## -remarks

You should access a **GeolocationProvider** object from the context of the user for whom location is to be overridden and provided to location-aware apps. The length of a location override session is bound by calls to [SetOverridePosition](geolocationprovider_setoverrideposition_807670976.md) and [ClearOverridePosition](geolocationprovider_clearoverrideposition_399430586.md). Once a session starts successfully, other entities can't obtain override functionality until the original object is cleared.

## -see-also

## -examples

The scenario in this code example involves a server-side app for a remote access client using these APIs to override the location of the machine. In the scenario, client apps run on diverse operating systems (OSes) (such as Windows, MacOS, iOS, or Linux), and post positions periodically (by calling these APIs) to a component that acts as a proxy on the host machine.

```csharp
using Windows.Devices.Geolocation;
using Windows.Devices.Geolocation.Provider;

...

public class OverrideLocation
{
    public struct ClientPositionInfo
    {
        public BasicGeoposition geoposition;
        public PositionSource positionSource;
        public double accuracy;
    };

    private GeolocationProvider geolocationProvide = null;

    // When remote desktop connection is established,
    // call this API to initialize.
    public void Initialize()
    {
        geolocationProvider = new GeolocationProvider();
        geolocationProvider.IsOverriddenChanged +=
            new EventHandler<object>(OnIsOverriddenChanged);
    }

    // Uninitialize when remote desktop connection is stopped.
    public void DeInitialize()
    {
        geolocationProvider.IsOverriddenChanged -= OnIsOverriddenChanged;
        geolocationProvide.ClearOverridePosition();
    }

    private void OnIsOverriddenChanged(object sender, object args)
    {
        if (!geolocationProvider.IsOverridden)
        {
            SetPosition();
        }
    }

    // When remote desktop connection established,
    // call this API to set override position.
    public bool SetPosition()
    {
        // Get client location information from client side.
        ClientPositionInfo clientPositionInfo = GetClientLocationInformation();

        LocationOverrideStatus status = geolocationProvider.SetOverridePosition(
            clientPositionInfo.geoposition,
            clientPositionInfo.positionSource,
            clientPositionInfo.accuracy);

        if (status == LocationOverrideStatus.AlreadyStarted)
        {
            // Failed to get override session.
            return false;
        }
        else if (status == LocationOverrideStatus.AccessDenied)
        {
            // Do not have access to override.
            return false;
        }
        else if (status == LocationOverrideStatus.Other)
        {
            // something else caused the failure.
            return false;
        }
        return true;

    }
    public bool UpdatePosition()
    {
        // Update position.
        return SetPosition();
    }
}
```

## -capabilities
runFullTrust
