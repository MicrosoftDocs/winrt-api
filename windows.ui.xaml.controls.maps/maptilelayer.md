---
-api-id: T:Windows.UI.Xaml.Controls.Maps.MapTileLayer
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.UI.Xaml.Controls.Maps.MapTileLayer : int
-->

# MapTileLayer

## -description
Specifies the [Layer](maptilesource_layer.md) type of a [MapTileSource](maptilesource.md).

## -enum-fields
### -field LabelOverlay:0
The [MapTileSource](maptilesource.md) is a label overlay.

### -field RoadOverlay:1
The [MapTileSource](maptilesource.md) is a road overlay.

### -field AreaOverlay:2
The [MapTileSource](maptilesource.md) is an area overlay.

### -field BackgroundOverlay:3
The [MapTileSource](maptilesource.md) is a background overlay.

### -field BackgroundReplacement:4
The [MapTileSource](maptilesource.md) is a background replacement overlay.


## -remarks
You can specify one of the named layers of map content to contain the tiles that you overlay on the map. The values of the MapTileLayer enumeration are similar to a range of z-index values, from foreground to background. If you don't specify a value for the [Layer](maptilesource_layer.md) property, the tiles are overlaid in the foreground layer.

To replace the default map entirely:


+ Specify MapTileLayer.**BackgroundReplacement** as the value of the [Layer](maptilesource_layer.md) property of the [MapTileSource](maptilesource.md).
+ Specify [MapStyle](mapstyle.md).**None** as the value of the [Style](mapcontrol_style.md) property of the [MapControl](mapcontrol.md).


## -examples

## -see-also
[Overlay tiled images on a map](/windows/uwp/maps-and-location/overlay-tiled-images)
