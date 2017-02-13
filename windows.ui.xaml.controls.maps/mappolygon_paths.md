---
-api-id: P:Windows.UI.Xaml.Controls.Maps.MapPolygon.Paths
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Collections.IVector<Windows.Devices.Geolocation.Geopath> Paths { get; }
-->

# Windows.UI.Xaml.Controls.Maps.MapPolygon.Paths

## -description
Gets a list of [Geopath](../windows.devices.geolocation/geopath.md) objects that define the [MapPolygon](mappolygon.md) shape.

> [!NOTE]
> In Windows 10, version 1511, we recommend using this property instead of [Path](mappolygon_path.md) to create polygons. Do not use both properties ([Paths](mappolygon_paths.md) and [Path](mappolygon_path.md)) at the same time.

## -property-value
A list of [Geopath](../windows.devices.geolocation/geopath.md) objects that define the [MapPolygon](mappolygon.md) shape.

## -remarks
This property allows the [MapPolygon](mappolygon.md) to be defined by one or more [Geopath](../windows.devices.geolocation/geopath.md) objects. With multiple geopaths, you can create complex shapes, such as a polygon with a hole in it.



In this example, a [MapPolygon](mappolygon.md) is created in the shape of a polygon with a hole in it.

```csharp
var pathPositions = new List<BasicGeoposition>();

pathPositions.Add(new BasicGeoposition() { Latitude = 0, Longitude = 0 });
pathPositions.Add(new BasicGeoposition() { Latitude = 1, Longitude = 0 });
pathPositions.Add(new BasicGeoposition() { Latitude = 1, Longitude = 1 });
pathPositions.Add(new BasicGeoposition() { Latitude = 0, Longitude = 1 });

var interiorPositions = new List<BasicGeoposition>();

interiorPositions.Add(new BasicGeoposition() { Latitude = 0.2, Longitude = 0.2 });
interiorPositions.Add(new BasicGeoposition() { Latitude = 0.4, Longitude = 0.2 });
interiorPositions.Add(new BasicGeoposition() { Latitude = 0.4, Longitude = 0.4 });
interiorPositions.Add(new BasicGeoposition() { Latitude = 0.2, Longitude = 0.4 });

var mp = new MapPolygon();

mp.Paths.Add(new Geopath(pathPositions));
mp.Paths.Add(new Geopath(interiorPositions));

this.maps.MapElements.Add(mp);

```



## -examples

## -see-also
