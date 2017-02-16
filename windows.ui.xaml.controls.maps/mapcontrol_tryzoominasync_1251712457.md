---
-api-id: M:Windows.UI.Xaml.Controls.Maps.MapControl.TryZoomInAsync
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<bool> TryZoomInAsync()
-->

# Windows.UI.Xaml.Controls.Maps.MapControl.TryZoomInAsync

## -description
Starts an asynchronous operation to zoom in, increasing the map's [ZoomLevel](mapcontrol_zoomlevel.md) by one.

## -returns
Contains the results of the operation: **true** if the operation completed successfully; otherwise, **false**.

## -remarks
> [!WARNING]
> We don't recommend changing **ZoomLevel** with 3D views. When the MapControl's view is not looking "straight-down," changes in **ZoomLevel** can lead to unpredictable behavior.

**ZoomLevel** is intended for 2D views. To implement a "zoom" effect with 3D views, use the MapControl's [TrySetSceneAsync](mapcontrol_trysetsceneasync.md) method to move the camera closer. Start by setting a closer [Location](mapcamera_location.md) on a [MapCamera](mapcamera.md) object. Next, create a new [MapScene](mapscene.md) by passing that [MapCamera](mapcamera.md) to [CreateFromCamera](mapscene_createfromcamera.md). Finally, initiate the zoom by passing the new [MapScene](mapscene.md) to [TrySetSceneAsync](mapcontrol_trysetsceneasync.md). You can zoom in immediately or specify [MapAnimationKind](mapanimationkind.md) to create an animated "fly in".

The maximum and minimum values of [ZoomLevel](mapcontrol_zoomlevel.md) depend on the type of map view: 2D, 3D, or Streetside.<table>
   <tr><th>Property</th><th>2D range</th><th>3D range</th><th>Streetside range</th></tr>
   <tr><td>ZoomLevel</td><td>1-20</td><td>1-20</td><td>24-26</td></tr>
</table>

 When leaving a Streetside view, the map returns to the previous view settings. The Streetside ZoomLevel is not maintained outside of the Streetside experience.

Consider this method when you want to replace the default UI control with your own.

## -examples

## -see-also
