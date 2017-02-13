---
-api-id: M:Windows.UI.Xaml.Controls.Maps.StreetsideExperience.#ctor(Windows.UI.Xaml.Controls.Maps.StreetsidePanorama,System.Double,System.Double,System.Double)
-api-type: winrt method
---

<!-- Method syntax
public StreetsideExperience(Windows.UI.Xaml.Controls.Maps.StreetsidePanorama panorama, System.Double headingInDegrees, System.Double pitchInDegrees, System.Double fieldOfViewInDegrees)
-->

# Windows.UI.Xaml.Controls.Maps.StreetsideExperience.StreetsideExperience

## -description
Creates a [StreetsideExperience](streetsideexperience.md) based on the specified panoramic view and camera position.

## -parameters
### -param panorama
The panoramic view to appear in the [StreetsideExperience](streetsideexperience.md).

### -param headingInDegrees
The directional heading of the map's camera in degrees, where 0 or 360 = North, 90 = East, 180 = South, and 270 = West. The default *headingInDegrees* value is 0.

### -param pitchInDegrees
The pitch of the map's camera in degrees, where 90 is looking out at the horizon (maximum) and 0 is looking straight down (minimum). The default *pitchInDegrees* value is 90.

### -param fieldOfViewInDegrees
The horizontal angle of view that appears in the map's camera, in degrees. The default *fieldOfViewInDegrees* value is 75.

## -remarks
The valid range of pitch differs between 2D, 3D, and Streetside map views. When switching from 3D to 2D for example, values that are acceptable in the current view may be out of range in the next view. If that’s the case, the current pitch value will be truncated to the nearest acceptable value in the next view.

When leaving a Streetside view, the map returns to the previous view settings. The Streetside pitch is not maintained outside of the Streetside experience.

The maximum and minimum values of pitch/tilt depend on the type of map view: 2D, 3D, or Streetside. The range for field of view is the same in all views.<table>
   <tr><th>Property</th><th>2D range</th><th>3D range</th><th>Streetside range</th></tr>
   <tr><td>pitch/tilt</td><td>0-75</td><td>0-90</td><td>0-180</td></tr>
   <tr><td>field of view</td><td>22-90</td><td>22-90</td><td>22-90</td></tr>
</table>

Heading values greater than 360 degrees are normalized to their equivalent 0-360 degree value.

## -examples

## -see-also
[StreetsideExperience(StreetsidePanorama)](streetsideexperience_streetsideexperience_2014336380.md)