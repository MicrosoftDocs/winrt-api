---
-api-id: M:Windows.Devices.Geolocation.Geocircle.#ctor(Windows.Devices.Geolocation.BasicGeoposition,System.Double)
-api-type: winrt method
---

<!-- Method syntax
public Geocircle(Windows.Devices.Geolocation.BasicGeoposition position, System.Double radius)
-->

# Windows.Devices.Geolocation.Geocircle.Geocircle

## -description
Create a geographic circle object for the given position and radius.

## -parameters
### -param position
The geographic position of the new circle.

### -param radius
The radius of the new circle, in meters.

## -remarks
The constructor will throw an exception if the provided [BasicGeoposition](basicgeoposition.md) has a latitude is less than -90 or greater than 90 or if the supplied [Radius](geocircle_radius.md) is outside of the allowed range.

## -examples

## -see-also

## -capabilities
location
