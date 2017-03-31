---
-api-id: P:Windows.UI.Xaml.Controls.Maps.MapBillboard.ReferenceCamera
-api-type: winrt property
---

<!-- Property syntax.
public MapCamera ReferenceCamera { get; }
-->

# Windows.UI.Xaml.Controls.Maps.MapBillboard.ReferenceCamera

## -description
Gets the [MapCamera](mapcamera.md) settings that define the position and orientation where the image appears at a 1x scale.

## -property-value
The [MapCamera](mapcamera.md) settings that define the position and orientation where the image appears at a 1x scale.

## -remarks

Because a [MapBillboard](mapbillboard.md) image scales in and out as the [ZoomLevel](mapcontrol_zoomlevel.md) of the map changes, it's important to define where in that [ZoomLevel](mapcontrol_zoomlevel.md) the image appears at a normal 1x scale. You define that position in a [Geopoint](../windows.devices.geolocation/geopoint.md), and then pass that [Geopoint](../windows.devices.geolocation/geopoint.md) as a parameter to the [MapBillboard](mapbillboard.md) constructor.

For example, if you use the map's [ActualCamera](mapcontrol_actualcamera.md) as that constructor parameter, the position defined in the reference camera becomes equal to the position defined in the maps internal camera. This becomes the position of the camera where the [MapBillboard](mapbillboard.md) image appears at 1x scale. However, if your app gives users the ability to zoom out on the map, the image decreases in size because the maps internal camera is rising in altitude while the image at 1x scale remains fixed at the reference camera's position.  

## -see-also

## -examples
