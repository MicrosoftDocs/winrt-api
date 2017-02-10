---
-api-id: M:Windows.UI.Xaml.Controls.Maps.MapScene.CreateFromLocation(Windows.Devices.Geolocation.Geopoint,System.Double,System.Double)
-api-type: winrt method
---

<!-- Method syntax
public Windows.UI.Xaml.Controls.Maps.MapScene CreateFromLocation(Windows.Devices.Geolocation.Geopoint location, System.Double headingInDegrees, System.Double pitchInDegrees)
-->

# Windows.UI.Xaml.Controls.Maps.MapScene.CreateFromLocation

## -description
Creates a scene to appear in a map based on a single geographic location, heading, and pitch.

## -parameters
### -param location
The center of the scene.

### -param headingInDegrees
The directional heading of the map's camera in degrees, where 0 or 360 = North, 90 = East, 180 = South, and 270 = West. The default *headingInDegrees* value is 0.

### -param pitchInDegrees
The pitch of the map's camera in degrees, where 90 is looking out at the horizon (maximum) and 0 is looking straight down (minimum). The default *pitchInDegrees* value is 0.

## -returns
Represents a view of a map in the [MapControl](mapcontrol.md).

## -remarks
> [!TIP]
> Use the [CreateFromCamera](mapscene_createfromcamera.md) method to create a scene by specifying the position of the map's camera. The location specified in this method by the *location* parameter is the location that will appear in the scene, it's not the location of the map's camera.

The following image demonstrates the location of the scene relative to the map's camera. The location specified in this method by the *location* parameter corresponds to the **MapScene location**.

<img src="images/MapControl_TechDiagram.png" alt="The relationship between MapCamera location and MapScene location relative to the map." />
The valid range of pitch differs between 2D, 3D, and Streetside map views. When switching from 3D to 2D for example, values that are acceptable in the current view may be out of range in the next view. If that’s the case, the current pitch value will be truncated to the nearest acceptable value in the next view.

When leaving a Streetside view, the map returns to the previous view settings. The Streetside pitch is not maintained outside of the Streetside experience.

The maximum and minimum values of pitch/tilt depend on the type of map view: 2D, 3D, or Streetside.<table>
   <tr><th>Property</th><th>2D range</th><th>3D range</th><th>Streetside range</th></tr>
   <tr><td>pitch/tilt</td><td>0-75</td><td>0-90</td><td>0-180</td></tr>
</table>

 Heading values greater than 360 degrees are normalized to their equivalent 0-360 degree value.

## -examples

## -see-also
[CreateFromLocation(Geopoint)](mapscene_createfromlocation_1131904095.md)