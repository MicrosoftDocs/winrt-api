---
-api-id: T:Windows.Services.Maps.Guidance.GuidanceUpdatedEventArgs
-api-type: winrt class
---

<!-- Class syntax.
public class GuidanceUpdatedEventArgs : Windows.Services.Maps.Guidance.IGuidanceUpdatedEventArgs
-->

# Windows.Services.Maps.Guidance.GuidanceUpdatedEventArgs

## -description
Provides data for the [GuidanceUpdated](guidancenavigator_guidanceupdated.md) event.

> [!NOTE]
> This API is not available to all Windows apps. Unless your developer account is specially provisioned by Microsoft, calls to this API will fail at runtime. For more information about the [Windows.Services.Maps.Guidance](windows_services_maps_guidance.md) namespace, please work with your Microsoft Account Team representative.

## -remarks
During a guidance update, the geographic location returned by GuidanceUpdatedEventArgs corresponds to the nearest point on the route near the user's actual geographic location. This helps compensate for GPS inaccuracies. If the route is not nearby, a point on the nearest road will be used. For example, if the user misses a turn.

## -examples

## -see-also
