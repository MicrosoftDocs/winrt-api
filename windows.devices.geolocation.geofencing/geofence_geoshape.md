---
-api-id: P:Windows.Devices.Geolocation.Geofencing.Geofence.Geoshape
-api-type: winrt property
---

<!-- Property syntax
public Windows.Devices.Geolocation.IGeoshape Geoshape { get; }
-->

# Windows.Devices.Geolocation.Geofencing.Geofence.Geoshape

## -description
The shape of the geofence region.

## -property-value
The shape of the geofence region.

## -remarks
This property is read-only. You must set the shape of a geofence when you initialize it using one of the constructors.

The type of this property, [IGeoshape](../windows.devices.geolocation/igeoshape.md), is an interface to enable the possibility of supporting multiple shapes for geofences. The only shape that is currently supported is [Geocircle](../windows.devices.geolocation/geocircle.md), so this is the class you should use when initializing your geofences.

## -examples

## -see-also
