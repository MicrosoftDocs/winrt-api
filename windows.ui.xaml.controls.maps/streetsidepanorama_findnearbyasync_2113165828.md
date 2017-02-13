---
-api-id: M:Windows.UI.Xaml.Controls.Maps.StreetsidePanorama.FindNearbyAsync(Windows.Devices.Geolocation.Geopoint,System.Double)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.UI.Xaml.Controls.Maps.StreetsidePanorama> FindNearbyAsync(Windows.Devices.Geolocation.Geopoint location, System.Double radiusInMeters)
-->

# Windows.UI.Xaml.Controls.Maps.StreetsidePanorama.FindNearbyAsync

## -description
Creates a [StreetsidePanorama](streetsidepanorama.md) near the specified geographic location and radius.

## -parameters
### -param location
The center of the panoramic view.

### -param radiusInMeters
The radius to appear in the panoramic view, in meters.

## -returns
If available, the nearest [StreetsidePanorama](streetsidepanorama.md); otherwise, **null**.

## -remarks
Panoramic street-level views are not available for all locations. We recommend checking for **null** return values before proceeding with a [StreetsideExperience](streetsideexperience.md).

## -examples

## -see-also
[FindNearbyAsync(Geopoint)](streetsidepanorama_findnearbyasync_1616880360.md)