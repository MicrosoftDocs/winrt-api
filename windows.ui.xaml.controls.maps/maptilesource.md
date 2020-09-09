---
-api-id: T:Windows.UI.Xaml.Controls.Maps.MapTileSource
-api-type: winrt class
---

<!-- Class syntax.
public class MapTileSource : Windows.UI.Xaml.DependencyObject, Windows.UI.Xaml.Controls.Maps.IMapTileSource
-->

# Windows.UI.Xaml.Controls.Maps.MapTileSource

## -description
Represents a source of tiles to overlay on the [MapControl](mapcontrol.md).

## -remarks
Tiles can also be animated on the [MapControl](mapcontrol.md) using a MapTileSource.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1809 | 17763 | AnimationState |
| 1809 | 17763 | AutoPlay |
| 1809 | 17763 | FrameCount |
| 1809 | 17763 | FrameDuration |
| 1809 | 17763 | Pause |
| 1809 | 17763 | Play |
| 1809 | 17763 | Stop |

## -examples

This example overlays tiles from a fictitious web service on the map.

```cs

 // Create the bounding box in which the tiles are displayed.
 // This example represents North America.
 var northWestCorner =
                new BasicGeoposition() { Latitude = 48.38544, Longitude = -124.667360 };
 var southEastCorner =
                new BasicGeoposition() { Latitude = 25.26954, Longitude = -80.30182 };
 var boundingBox = new GeoboundingBox(northWestCorner, southEastCorner);

 // Create an HTTP data source.
 // This example retrieves tiles from a fictitious web service.
 var myHttpDataSource = new HttpMapTileDataSource(
     "http://www.<web service name>.com/z={zoomlevel}&x={x}&y={y}");

 // Create a tile source and add it to the Map control.
 var myTileSource = new MapTileSource(myHttpDataSource);
 myTileSource.Bounds = boundingBox;

 myMap.TileSources.Add(myTileSource);

```

This other example animates tiles from a fictitious web service on the map. The code creates a MapTileSource with the [AutoPlay](maptilesource_autoplay.md) property explicitly set to **true**.

```cs

 // Create an HTTP data source.
 // This example retrieves tiles from a fictitious web service.
 var myHttpDataSource = new HttpMapTileDataSource(
     "http://www.<web service name>.com/{x}/{y}/{zoomlevel}/{frame}.png");

 // Create a tile source and add it to the Map control.
 var myTileSource = new MapTileSource(myHttpDataSource);
 myTileSource.AutoPlay = true;
 myTileSource.FrameCount = 8;
 myTileSource.FrameDuration = TimeSpan.FromSeconds(1);

 myMap.TileSources.Add(myTileSource);

```

## -see-also
[DependencyObject](../windows.ui.xaml/dependencyobject.md), [Overlay tiled images on a map](/windows/uwp/maps-and-location/overlay-tiled-images)
