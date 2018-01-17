---
-api-id: P:Windows.Services.Maps.MapRouteDrivingOptions.DepartureTime
-api-type: winrt property
---

<!-- Property syntax.
public IReference<DateTime> DepartureTime { get;  set; }
-->

# Windows.Services.Maps.MapRouteDrivingOptions.DepartureTime

## -description
Gets or sets the date and time of the departure on a route.

## -property-value
The date and time of departure on a route.

## -remarks
This option is useful in cases where you want to compute a route with the traffic conditions that are typical for the specified day and time.

> [!NOTE]
> Map packages that you download for offline use don’t contain traffic information.  Therefore, all routes that are calculated while in offline mode have the same duration regardless of the value of this property.

## -see-also

## -examples
