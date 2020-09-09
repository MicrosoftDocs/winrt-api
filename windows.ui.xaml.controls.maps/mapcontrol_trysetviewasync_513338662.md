---
-api-id: M:Windows.UI.Xaml.Controls.Maps.MapControl.TrySetViewAsync(Windows.Devices.Geolocation.Geopoint,Windows.Foundation.IReference{System.Double},Windows.Foundation.IReference{System.Double},Windows.Foundation.IReference{System.Double})
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<bool> TrySetViewAsync(Windows.Devices.Geolocation.Geopoint center, Windows.Foundation.IReference<System.Double> zoomLevel, Windows.Foundation.IReference<System.Double> heading, Windows.Foundation.IReference<System.Double> desiredPitch)
-->

# Windows.UI.Xaml.Controls.Maps.MapControl.TrySetViewAsync

## -description
Sets the view of the map displayed in the [MapControl](mapcontrol.md) using the specified center, zoom level, heading, and pitch.

## -parameters
### -param center
The center to use in the view. For more info, see the [Center](mapcontrol_center.md) property.

### -param zoomLevel
The zoom level to use in the view. For more info, see the [ZoomLevel](mapcontrol_zoomlevel.md) property.

### -param heading
The heading to use in the view. For more info, see the [Heading](mapcontrol_heading.md) property.

### -param desiredPitch
The pitch to use in the view. For more info, see the [DesiredPitch](mapcontrol_desiredpitch.md) property.

## -returns
**true** if the asynchronous operation succeeded; otherwise, **false**.

## -remarks
The maximum and minimum values of pitch/tilt depend on the type of map view: 2D, 3D, or Streetside. <table>
   <tr><th>Property</th><th>2D range</th><th>3D range</th><th>Streetside range</th></tr>
   <tr><td>pitch/tilt</td><td>0-75</td><td>0-90</td><td>0-180</td></tr>
   <tr><td>ZoomLevel</td><td>1-20</td><td>1-20</td><td>24-26</td></tr>
</table>

 For more information, see the [TrySetViewAsync(Geopoint, IReference(Double), IReference(Double), IReference(Double), MapAnimationKind)](mapcontrol_trysetviewasync_2106504554.md) overload.

Heading values greater than 360 degrees are normalized to their equivalent 0-360 degree value.

## -examples

## -see-also
[TrySetViewAsync(Geopoint)](mapcontrol_trysetviewasync_675781320.md), [TrySetViewAsync(Geopoint, IReference(Double))](mapcontrol_trysetviewasync_117228238.md), [TrySetViewAsync(Geopoint, IReference(Double), IReference(Double), IReference(Double), MapAnimationKind)](mapcontrol_trysetviewasync_2106504554.md), [Display maps with 2D, 3D, and Streetside views](/windows/uwp/maps-and-location/display-maps)
