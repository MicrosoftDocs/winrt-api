---
-api-id: P:Windows.Services.Maps.Guidance.GuidanceMapMatchedCoordinate.Location
-api-type: winrt property
---

<!-- Property syntax
public Windows.Devices.Geolocation.Geopoint Location { get; }
-->

# Windows.Services.Maps.Guidance.GuidanceMapMatchedCoordinate.Location

## -description
Gets the current geographic location.

> [!NOTE]
> This API is not available to all Windows apps. Unless your developer account is specially provisioned by Microsoft, calls to this API will fail at runtime. For more information about the [Windows.Services.Maps.Guidance](windows_services_maps_guidance.md) namespace, please work with your Microsoft Account Team representative.

## -property-value
The current geographic location.

## -remarks
During a guidance update, the geographic location returned by [GuidanceUpdatedEventArgs](guidanceupdatedeventargs.md) corresponds to the nearest point on the route near the user's actual geographic location. This helps compensate for GPS inaccuracies. If the route is not nearby, a point on the nearest road will be used. For example, if the user misses a turn.

## -examples

## -see-also
