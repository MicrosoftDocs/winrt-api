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

### -field OtherMovement:3
The user moved significantly since the last Visit.

### -field Departed:2
The user departed from a Visit.

### -field Arrived:1
The user arrived at a Visit.

## -remarks
When a state change is logged with the value **Arrived**, developers can assume that the device remains in that area until either a **Departed** or **TrackingLost** change is logged.

## -see-also
[Geovisit](Geovisit.md)
[Guidelines for using Visits tracking](/windows/uwp/maps-and-location/guidelines-for-visits)

## -examples


## -capabilities
location
