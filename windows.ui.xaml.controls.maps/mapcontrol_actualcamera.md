---
-api-id: P:Windows.UI.Xaml.Controls.Maps.MapControl.ActualCamera
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Controls.Maps.MapCamera ActualCamera { get; }
-->

# Windows.UI.Xaml.Controls.Maps.MapControl.ActualCamera

## -description
Gets the [MapCamera](mapcamera.md) settings that define the current position of the camera.

## -property-value
The [MapCamera](mapcamera.md) settings that define the current position of the camera.

## -remarks
During an animation of the map, the ActualCamera defines the current position of the map's camera and [TargetCamera](mapcontrol_targetcamera.md) defines the final position of the camera.

The map's camera settings are updated whenever the view of the map is changed. For example, when updating the [Center](mapcontrol_center.md) property or calling the [TrySetSceneAsync](/uwp/api/windows.ui.xaml.controls.maps.mapcontrol.trysetsceneasync) method.

## -examples

## -see-also
