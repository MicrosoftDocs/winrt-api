---
-api-id: P:Windows.UI.Xaml.Controls.Maps.HttpMapTileDataSource.UriFormatString
-api-type: winrt property
---

<!-- Property syntax
public string UriFormatString { get;  set; }
-->

# Windows.UI.Xaml.Controls.Maps.HttpMapTileDataSource.UriFormatString

## -description
Gets or sets the format of the Uri for fetching tiles from an HTTP source.

## -property-value
The format of the Uri for fetching tiles from an HTTP source.

## -remarks
The UriFormat property accepts the following case-insensitive replacement strings:


+ *{x}*
+ *{y}*
+ *{zoomlevel}*
+ *{quadkey}*
For more info about the *{x}*, *{y}*, and *{quadkey}* replacement strings, see [Bing Maps Tile System](/bingmaps/articles/bing-maps-tile-system).

> [!TIP]
> If you have to provide a custom Uri for which these arguments aren't sufficient - for example, if you have to provide *{subdomain}* for load balancing - create the custom Uri in a custom handler for the [UriRequested](httpmaptiledatasource_urirequested.md) event. For more info, see [Overlay tiled images on a map](/windows/uwp/maps-and-location/overlay-tiled-images).

## -examples

## -see-also
[Overlay tiled images on a map](/windows/uwp/maps-and-location/overlay-tiled-images)
