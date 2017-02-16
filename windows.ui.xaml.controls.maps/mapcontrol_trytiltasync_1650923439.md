---
-api-id: M:Windows.UI.Xaml.Controls.Maps.MapControl.TryTiltAsync(System.Double)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<bool> TryTiltAsync(System.Double degrees)
-->

# Windows.UI.Xaml.Controls.Maps.MapControl.TryTiltAsync

## -description
Starts an asynchronous operation to tilt the map's camera from its current position.

## -parameters
### -param degrees
The degrees of [Pitch](mapcamera_pitch.md) that the map's camera tilts down to the ground.

## -returns
Contains the results of the operation: **true** if the operation completed successfully; otherwise, **false**.

## -remarks
Consider this method when you want to replace the default UI control with your own.

The valid range of tilt differs between 2D, 3D, and Streetside map views. When switching from 3D to 2D for example, values that are acceptable in the current view may be out of range in the next view. If that’s the case, the current tilt value will be truncated to the nearest acceptable value in the next view.

When leaving a Streetside view, the map returns to the previous view settings. The Streetside pitch is not maintained outside of the Streetside experience.

The maximum and minimum values of pitch/tilt depend on the type of map view: 2D, 3D, or Streetside.<table>
   <tr><th>Property</th><th>2D range</th><th>3D range</th><th>Streetside range</th></tr>
   <tr><td>pitch/tilt</td><td>0-75</td><td>0-90</td><td>0-180</td></tr>
</table>

## -examples

## -see-also
