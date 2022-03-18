---
-api-id: P:Windows.UI.Xaml.Controls.Maps.MapControl.DesiredPitch
-api-type: winrt property
---

<!-- Property syntax
public double DesiredPitch { get;  set; }
-->

# Windows.UI.Xaml.Controls.Maps.MapControl.DesiredPitch

## -description
Gets or sets a value that indicates by how many degrees you want the map to be tilted. Sometimes the desired pitch cannot be set.

## -xaml-syntax
```xaml
<!-- xmlns:Maps="using:Windows.UI.Xaml.Controls.Maps" -->

<Maps:MapControl DesiredPitch="desiredPitch" />
- or -
<Maps:MapControl>
    <Maps:MapControl.DesiredPitch>desiredPitch</Maps:MapControl.DesiredPitch>
</Maps:MapControl>

```


## -xaml-values
<dl><dt>desiredPitch</dt><dd>desiredPitchA value that indicates by how many degrees you want the map to be tilted.</dd>
</dl>
## -property-value
A value that indicates by how many degrees you want the map to be tilted. Sometimes the desired pitch cannot be set.

## -remarks
For more information about pitch, see the remarks section of the [MapCamera(Geopoint, Double, Double, Double, Double)](mapcamera_mapcamera_1532703584.md) overload.

The maximum and minimum values of pitch/tilt depend on the type of map view: 2D, 3D, or Streetside.<table>
   <tr><th>Property</th><th>2D range</th><th>3D range</th><th>Streetside range</th></tr>
   <tr><td>DesiredPitch</td><td>0-75</td><td>0-90</td><td>0-180</td></tr>
</table>

## -examples

## -see-also
[Pitch](mapcontrol_pitch.md), [Display maps with 2D, 3D, and Streetside views](/windows/uwp/maps-and-location/display-maps)
