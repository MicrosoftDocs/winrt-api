---
-api-id: M:Windows.UI.Xaml.Controls.Maps.MapCamera.#ctor(Windows.Devices.Geolocation.Geopoint,System.Double)
-api-type: winrt method
---

<!-- Method syntax
public MapCamera(Windows.Devices.Geolocation.Geopoint location, System.Double headingInDegrees)
-->

# Windows.UI.Xaml.Controls.Maps.MapCamera.MapCamera

## -description
Creates a map camera, to define the view of a map based on location and heading.

## -parameters
### -param location
The location of the camera in the map.

### -param headingInDegrees
The directional heading of the camera in degrees, where 0 or 360 = North, 90 = East, 180 = South, and 270 = West. The default *headingInDegrees* value is 0.

## -remarks
This constructor is equivalent to calling [MapCamera(Geopoint, Double, Double, Double, Double)](mapcamera_mapcamera_1532703584.md) with the following default parameter values: *pitchInDegrees* = 0 (looking straight down), *rollInDegrees* = 0 (no tilt), and *fieldOfViewInDegrees* = 45.

Heading values greater than 360 degrees are normalized to their equivalent 0-360 degree value.

## -examples

## -see-also
[MapCamera(Geopoint)](mapcamera_mapcamera_430498052.md), [MapCamera(Geopoint, Double, Double)](mapcamera_mapcamera_1062529072.md), [MapCamera(Geopoint, Double, Double, Double, Double)](mapcamera_mapcamera_1532703584.md)