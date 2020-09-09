---
-api-id: M:Windows.UI.Xaml.Controls.Maps.MapControl.TrySetViewAsync(Windows.Devices.Geolocation.Geopoint,Windows.Foundation.IReference{System.Double},Windows.Foundation.IReference{System.Double},Windows.Foundation.IReference{System.Double},Windows.UI.Xaml.Controls.Maps.MapAnimationKind)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<bool> TrySetViewAsync(Windows.Devices.Geolocation.Geopoint center, Windows.Foundation.IReference<System.Double> zoomLevel, Windows.Foundation.IReference<System.Double> heading, Windows.Foundation.IReference<System.Double> desiredPitch, Windows.UI.Xaml.Controls.Maps.MapAnimationKind animation)
-->

# Windows.UI.Xaml.Controls.Maps.MapControl.TrySetViewAsync

## -description
Sets the view of the map displayed in the [MapControl ](mapcontrol.md) using the specified center, zoom level, heading, and pitch. The view change uses the specified animation.

## -parameters
### -param center
The center to use in the view. For more info, see the [Center](mapcontrol_center.md) property.

### -param zoomLevel
The zoom level to use in the view. For more info, see the [ZoomLevel](mapcontrol_zoomlevel.md) property.

### -param heading
The heading to use in the view. For more info, see the [Heading](mapcontrol_heading.md) property.

### -param desiredPitch
The pitch to use in the view. For more info, see the [DesiredPitch](mapcontrol_desiredpitch.md) property.

### -param animation
The animation to use when changing the view. For more info, see [MapAnimationKind](mapanimationkind.md).

## -returns
**true** if the asynchronous operation succeeded; otherwise, **false**.

## -remarks
The valid range of pitch and zoom level differs between 2D, 3D, and Streetside map views. When switching from 3D to 2D for example, values that are acceptable in the current view may be out of range in the next view. If that’s the case, the current pitch value will be truncated to the nearest acceptable value in the next view.

When leaving a Streetside view, the map returns to the previous view settings. The Streetside pitch is not maintained outside of the Streetside experience.

The maximum and minimum values of pitch/tilt depend on the type of map view: 2D, 3D, or Streetside. <table>
   <tr><th>Property</th><th>2D range</th><th>3D range</th><th>Streetside range</th></tr>
   <tr><td>pitch/tilt</td><td>0-75</td><td>0-90</td><td>0-180</td></tr>
   <tr><td>ZoomLevel</td><td>1-20</td><td>1-20</td><td>24-26</td></tr>
</table>

Heading values greater than 360 degrees are normalized to their equivalent 0-360 degree value.

## -examples

## -see-also
[TrySetViewAsync(Geopoint)](mapcontrol_trysetviewasync_675781320.md), [TrySetViewAsync(Geopoint, IReference(Double))](mapcontrol_trysetviewasync_117228238.md), [TrySetViewAsync(Geopoint, IReference(Double), IReference(Double), IReference(Double))](mapcontrol_trysetviewasync_513338662.md), [Display maps with 2D, 3D, and Streetside views](/windows/uwp/maps-and-location/display-maps)
