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
You can specify one of the named layers of map content to contain the tiles that you overlay on the map. The values of the [MapTileLayer](maptilelayer.md) enumeration are similar to a range of z-index values, from foreground to background. If you don't specify a value for the [Layer](maptilesource_layer.md) property, the tiles are overlaid in the foreground layer.

To replace the default map entirely:


+ Specify [MapTileLayer](maptilelayer.md).**BackgroundReplacement** as the value of the [Layer](maptilesource_layer.md) property of the [MapTileSource](maptilesource.md).
+ Specify [MapStyle](mapstyle.md).**None** as the value of the [Style](mapcontrol_style.md) property of the [MapControl](mapcontrol.md).


## -examples

## -see-also
[Overlay tiled images on a map](http://msdn.microsoft.com/library/066bd6e2-c22b-4f5b-aa94-5d6c86a09bdf)