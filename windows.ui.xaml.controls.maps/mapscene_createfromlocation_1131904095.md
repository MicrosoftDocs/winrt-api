---
-api-id: M:Windows.UI.Xaml.Controls.Maps.MapScene.CreateFromLocation(Windows.Devices.Geolocation.Geopoint)
-api-type: winrt method
---

<!-- Method syntax
public Windows.UI.Xaml.Controls.Maps.MapScene CreateFromLocation(Windows.Devices.Geolocation.Geopoint location)
-->

# Windows.UI.Xaml.Controls.Maps.MapScene.CreateFromLocation

## -description
Creates a scene to appear in a map based on a single geographic location.

## -parameters
### -param location
The center of the scene.

## -returns
Represents a view of a map in the [MapControl](mapcontrol.md).

## -remarks
This constructor is equivalent to calling [CreateFromLocation(Geopoint, Double, Double)](mapscene_createfromlocation_1703638387.md) with the following default parameter values: *headingInDegrees* = 0 (North) and *pitchInDegrees* = 0 (looking straight down).

For more information, see the remarks section of the [CreateFromLocation(Geopoint, Double, Double)](mapscene_createfromlocation_1703638387.md) method.

## -examples

## -see-also
[CreateFromLocation(Geopoint, Double, Double)](mapscene_createfromlocation_1703638387.md)