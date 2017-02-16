---
-api-id: M:Windows.UI.Xaml.Controls.Maps.MapCamera.#ctor(Windows.Devices.Geolocation.Geopoint,System.Double,System.Double)
-api-type: winrt method
---

<!-- Method syntax
public MapCamera(Windows.Devices.Geolocation.Geopoint location, System.Double headingInDegrees, System.Double pitchInDegrees)
-->

# Windows.UI.Xaml.Controls.Maps.MapCamera.MapCamera

## -description
Creates a map camera, to define the view of a map based on location, heading, and pitch.

## -parameters
### -param location
The location of the camera in the map.

### -param headingInDegrees
The directional heading of the camera in degrees, where 0 or 360 = North, 90 = East, 180 = South, and 270 = West. The default *headingInDegrees* value is 0.

### -param pitchInDegrees
The pitch of the map's camera in degrees, where 90 is looking out at the horizon (maximum) and 0 is looking straight down (minimum). The default *pitchInDegrees* value is 0.

## -remarks
This constructor is equivalent to calling [MapCamera(Geopoint, Double, Double, Double, Double)](mapcamera_mapcamera_1532703584.md) with the following default parameter values: *rollInDegrees* = 0 (no tilt), and *fieldOfViewInDegrees* = 45.

See additional comments in the [MapCamera(Geopoint, Double, Double, Double, Double)](mapcamera_mapcamera_1532703584.md) overload.

The maximum and minimum values of pitch/tilt depend on the type of map view: 2D, 3D, or Streetside.<table>
   <tr><th>Property</th><th>2D range</th><th>3D range</th><th>Streetside range</th></tr>
   <tr><td>pitch/tilt</td><td>0-75</td><td>0-90</td><td>0-180</td></tr>
</table>

 Heading values greater than 360 degrees are normalized to their equivalent 0-360 degree value.

## -examples

## -see-also
[MapCamera(Geopoint)](mapcamera_mapcamera_430498052.md), [MapCamera(Geopoint, Double)](mapcamera_mapcamera_67312104.md), [MapCamera(Geopoint, Double, Double, Double, Double)](mapcamera_mapcamera_1532703584.md)