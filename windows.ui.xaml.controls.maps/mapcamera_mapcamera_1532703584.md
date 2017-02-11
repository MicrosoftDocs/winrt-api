---
-api-id: M:Windows.UI.Xaml.Controls.Maps.MapCamera.#ctor(Windows.Devices.Geolocation.Geopoint,System.Double,System.Double,System.Double,System.Double)
-api-type: winrt method
---

<!-- Method syntax
public MapCamera(Windows.Devices.Geolocation.Geopoint location, System.Double headingInDegrees, System.Double pitchInDegrees, System.Double rollInDegrees, System.Double fieldOfViewInDegrees)
-->

# Windows.UI.Xaml.Controls.Maps.MapCamera.MapCamera

## -description
Creates a map camera, to define the view of a map based on location, heading, pitch, roll, and field of view.

## -parameters
### -param location
The location of the camera in the map.

### -param headingInDegrees
The directional heading of the camera in degrees, where 0 or 360 = North, 90 = East, 180 = South, and 270 = West. The default *headingInDegrees* value is 0.

### -param pitchInDegrees
The pitch of the map's camera in degrees, where 90 is looking out at the horizon (maximum) and 0 is looking straight down (minimum). The default *pitchInDegrees* value is 0.

### -param rollInDegrees
The roll of the camera in degrees, where -90 is tilting to the left and +90 is tilting to the right. The default *rollInDegrees* value is 0.

### -param fieldOfViewInDegrees
The horizontal angle of view that appears in the camera, in degrees. The default *fieldOfViewInDegrees* value is 45.0.

## -remarks
> [!NOTE]
> Adjusting [Roll](mapcamera_roll.md) may interfere with normal gesture operations and leave the map in an inconsistent state. We do not recommend adjusting [Roll](mapcamera_roll.md) without thoroughly testing your app.

The valid range of pitch differs between 2D, 3D, and Streetside map views. When switching from 3D to 2D for example, values that are acceptable in the current view may be out of range in the next view. If that’s the case, the current pitch value will be truncated to the nearest acceptable value in the next view.

When leaving a Streetside view, the map returns to the previous view settings. The Streetside pitch is not maintained outside of the Streetside experience.

The maximum and minimum values of pitch/tilt depend on the type of map view: 2D, 3D, or Streetside. The range for field of view is the same in all views.<table>
   <tr><th>Property</th><th>2D range</th><th>3D range</th><th>Streetside range</th></tr>
   <tr><td>pitch/tilt</td><td>0-75</td><td>0-90</td><td>0-180</td></tr>
   <tr><td>field of view</td><td>1-120</td><td>1-120</td><td>1-120</td></tr>
</table>

Heading values greater than 360 degrees are normalized to their equivalent 0-360 degree value.

## -examples

## -see-also
[MapCamera(Geopoint)](mapcamera_mapcamera_430498052.md), [MapCamera(Geopoint, Double)](mapcamera_mapcamera_67312104.md), [MapCamera(Geopoint, Double, Double)](mapcamera_mapcamera_1062529072.md)