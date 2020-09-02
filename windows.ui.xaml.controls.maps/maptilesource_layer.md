---
-api-id: P:Windows.UI.Xaml.Controls.Maps.MapTileSource.Layer
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Controls.Maps.MapTileLayer Layer { get;  set; }
-->

# Windows.UI.Xaml.Controls.Maps.MapTileSource.Layer

## -description
Gets or sets the layer that contains the tiles.

## -property-value
The layer that contains the tiles.

## -remarks
You can specify one of the named layers of map content to contain the tiles that you overlay on the map. The values of the [MapTileLayer](maptilelayer.md) enumeration are similar to a range of z-index values, from foreground to background. If you don't specify a value for the Layer property, the tiles are overlaid in the foreground layer.

To replace the default map entirely:


+ Specify [MapTileLayer](maptilelayer.md).**BackgroundReplacement** as the value of the Layer property of the [MapTileSource](maptilesource.md).
+ Specify [MapStyle](mapstyle.md).**None** as the value of the [Style](mapcontrol_style.md) property of the [MapControl](mapcontrol.md).


## -examples

## -see-also
[Overlay tiled images on a map](/windows/uwp/maps-and-location/overlay-tiled-images)
