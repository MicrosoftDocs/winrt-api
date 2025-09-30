---
-api-id: T:Windows.Devices.Geolocation.VisitStateChange
-api-type: winrt enum
---

<!-- Enumeration syntax.
public enum VisitStateChange : int
-->

# Windows.Devices.Geolocation.VisitStateChange

## -description
Contains values that describe a Visit-related state change.

## -enum-fields
### -field TrackingLost:0
The device is unable to track location at this time.

### -field Arrived:1
The user arrived at a visit.

### -field Departed:2
The user departed from a visit.

### -field OtherMovement:3
The user moved significantly since the last visit.

## -remarks
When a state change is logged with the value `Arrived`, the device remains in that area until either a `Departed` or `TrackingLost` change is logged.

## -examples

## -see-also
[Geovisit](geovisit.md),
[Guidelines for using Visits tracking](/windows/uwp/maps-and-location/guidelines-for-visits)

## -capabilities
location
