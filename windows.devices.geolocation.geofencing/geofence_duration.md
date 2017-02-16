---
-api-id: P:Windows.Devices.Geolocation.Geofencing.Geofence.Duration
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.TimeSpan Duration { get; }
-->

# Windows.Devices.Geolocation.Geofencing.Geofence.Duration

## -description
Gets the time window, beginning after the [StartTime](geofence_starttime.md), during which the [Geofence](geofence.md) is monitored.

## -property-value
The time window, beginning after the [StartTime](geofence_starttime.md), during which the [Geofence](geofence.md) is monitored.

## -remarks
This property is read-only. Use one of the overloaded [Geofence](geofence.md) constructors to set the duration value.

When the duration time window expires, the system automatically removes the geofence from the system and stops monitoring it. If you want your app to be notified when a geofence expires, be sure to include the **GeofenceState.Removed** state when initializing the geofence.

The default value for this property is a [TimeSpan](../windows.foundation/timespan.md) with a time interval of 0. A time interval of 0 indicates that the geofence will not expire and will be monitored indefinitely or until the app manually removes the geofence.

## -examples

## -see-also
