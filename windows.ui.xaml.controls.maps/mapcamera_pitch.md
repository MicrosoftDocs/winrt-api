---
-api-id: P:Windows.UI.Xaml.Controls.Maps.MapCamera.Pitch
-api-type: winrt property
---

<!-- Property syntax
public double Pitch { get;  set; }
-->

# Windows.UI.Xaml.Controls.Maps.MapCamera.Pitch

## -description
Gets or sets the pitch of the map's camera in degrees, where 90 is looking out at the horizon (maximum) and 0 is looking straight down (minimum).

## -property-value
The pitch of the map's camera in degrees, where 90 is looking out at the horizon (maximum) and 0 is looking straight down (minimum).

## -remarks
For more information about pitch, see the remarks section of the [MapCamera(Geopoint, Double, Double, Double, Double)](mapcamera_mapcamera_1532703584.md) overload.

The maximum and minimum values of pitch/tilt depend on the type of map view: 2D, 3D, or Streetside.<table>
   <tr><th>Property</th><th>2D range</th><th>3D range</th><th>Streetside range</th></tr>
   <tr><td>pitch/tilt</td><td>0-75</td><td>0-90</td><td>0-180</td></tr>
</table>

## -examples

## -see-also
