---
-api-id: M:Windows.UI.Xaml.Controls.Maps.MapScene.CreateFromLocationAndRadius(Windows.Devices.Geolocation.Geopoint,System.Double)
-api-type: winrt method
---

<!-- Method syntax
public Windows.UI.Xaml.Controls.Maps.MapScene CreateFromLocationAndRadius(Windows.Devices.Geolocation.Geopoint location, System.Double radiusInMeters)
-->

# Windows.UI.Xaml.Controls.Maps.MapScene.CreateFromLocationAndRadius

## -description
Creates a scene to appear in a map based on a single geographic location and radius.

## -parameters
### -param location
The center of the scene.

### -param radiusInMeters
The radius around the center to appear in the scene, in meters.

## -returns
Represents a view of a map in the [MapControl](mapcontrol.md).

## -remarks
This constructor is equivalent to calling [CreateFromLocationAndRadius(Geopoint, Double, Double, Double)](mapscene_createfromlocationandradius_1545989472.md) with the following default parameter values: *headingInDegrees* = 0 (North) and *pitchInDegrees* = 0 (looking straight down). For more information, see the remarks section of the [CreateFromLocationAndRadius(Geopoint, Double, Double, Double)](mapscene_createfromlocationandradius_1545989472.md) method.

## -examples

## -see-also
[CreateFromLocationAndRadius(Geopoint, Double, Double, Double)](mapscene_createfromlocationandradius_1545989472.md)