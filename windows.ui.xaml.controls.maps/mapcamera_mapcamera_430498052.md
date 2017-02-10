---
-api-id: M:Windows.UI.Xaml.Controls.Maps.MapCamera.#ctor(Windows.Devices.Geolocation.Geopoint)
-api-type: winrt method
---

<!-- Method syntax
public MapCamera(Windows.Devices.Geolocation.Geopoint location)
-->

# Windows.UI.Xaml.Controls.Maps.MapCamera.MapCamera

## -description
Creates a map camera, to define the view of a map based on location.

## -parameters
### -param location
The location of the camera in the map.

## -remarks
This constructor is equivalent to calling [MapCamera(Geopoint, Double, Double, Double, Double)](mapcamera_mapcamera_1532703584.md) with the following default parameter values: *headingInDegrees* = 0 (North), *pitchInDegrees* = 0 (looking straight down), *rollInDegrees* = 0 (no tilt), and *fieldOfViewInDegrees* = 45.

## -examples

## -see-also
[MapCamera(Geopoint, Double)](mapcamera_mapcamera_67312104.md), [MapCamera(Geopoint, Double, Double)](mapcamera_mapcamera_1062529072.md), [MapCamera(Geopoint, Double, Double, Double, Double)](mapcamera_mapcamera_1532703584.md)