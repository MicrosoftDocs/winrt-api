---
-api-id: M:Windows.UI.Xaml.Controls.Maps.MapControl.TrySetViewAsync(Windows.Devices.Geolocation.Geopoint,Windows.Foundation.IReference{System.Double})
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<bool> TrySetViewAsync(Windows.Devices.Geolocation.Geopoint center, Windows.Foundation.IReference<System.Double> zoomLevel)
-->

# Windows.UI.Xaml.Controls.Maps.MapControl.TrySetViewAsync

## -description
Sets the view of the map displayed in the [MapControl](mapcontrol.md) using the specified center and zoom level.

## -parameters
### -param center
The center to use in the view. For more info, see the [Center](mapcontrol_center.md) property.

### -param zoomLevel
The zoom level to use in the view. For more info, see the [ZoomLevel](mapcontrol_zoomlevel.md) property.

## -returns
**true** if the asynchronous operation succeeded; otherwise, **false**.

## -remarks
The maximum and minimum values of [ZoomLevel](mapcontrol_zoomlevel.md) depend on the type of map view: 2D, 3D, or Streetside.<table>
   <tr><th>Property</th><th>2D range</th><th>3D range</th><th>Streetside range</th></tr>
   <tr><td>ZoomLevel</td><td>1-20</td><td>1-20</td><td>24-26</td></tr>
</table>

 When leaving a Streetside view, the map returns to the previous view settings. The Streetside ZoomLevel is not maintained outside of the Streetside experience.

## -examples

## -see-also
[TrySetViewAsync(Geopoint)](mapcontrol_trysetviewasync_675781320.md), [TrySetViewAsync(Geopoint, IReference(Double), IReference(Double), IReference(Double))](mapcontrol_trysetviewasync_513338662.md), [TrySetViewAsync(Geopoint, IReference(Double), IReference(Double), IReference(Double), MapAnimationKind)](mapcontrol_trysetviewasync_2106504554.md), [Display maps with 2D, 3D, and Streetside views](/windows/uwp/maps-and-location/display-maps)
