---
-api-id: P:Windows.Services.Maps.MapRouteFinderResult.AlternateRoutes
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Collections.IVectorView<Windows.Services.Maps.MapRoute> AlternateRoutes { get; }
-->

# Windows.Services.Maps.MapRouteFinderResult.AlternateRoutes

## -description
Gets alternate routes between the same start and end points (if available).

## -property-value
Alternate routes, of type [MapRoute](maproute.md), between the same start and end points (if available); otherwise, **null**.

## -remarks
When [MaxAlternateRouteCount](maproutedrivingoptions_maxalternateroutecount.md) is set to 1 or greater, the [GetDrivingRouteAsync](maproutefinder_getdrivingrouteasync_1265171240.md) method will provide additional routes between the same start and end points (when available).

> [!NOTE]
> Some alternative routes may violate route restrictions. Use the [ViolatedRestrictions](maproute_violatedrestrictions.md) property to check for violations.

## -examples

## -see-also
