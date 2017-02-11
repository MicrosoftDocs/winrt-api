---
-api-id: M:Windows.UI.Xaml.Controls.Maps.MapScene.CreateFromLocations(Windows.Foundation.Collections.IIterable{Windows.Devices.Geolocation.Geopoint})
-api-type: winrt method
---

<!-- Method syntax
public Windows.UI.Xaml.Controls.Maps.MapScene CreateFromLocations(Windows.Foundation.Collections.IIterable<Windows.Devices.Geolocation.Geopoint> locations)
-->

# Windows.UI.Xaml.Controls.Maps.MapScene.CreateFromLocations

## -description
Creates a scene to appear in a map based on multiple geographic locations.

## -parameters
### -param locations
The locations to appear in the scene.

## -returns
Represents a view of a map in the [MapControl](mapcontrol.md).

## -remarks
This constructor is equivalent to calling [CreateFromLocations(IIterable(Geopoint), Double, Double)](mapscene_createfromlocations_326810990.md) with the following default parameter values: *headingInDegrees* = 0 (North) and *pitchInDegrees* = 0 (looking straight down). For more information, see the [CreateFromLocations(IIterable(Geopoint), Double, Double)](mapscene_createfromlocations_326810990.md) method.

## -examples

## -see-also
[CreateFromLocations(IIterable(Geopoint), Double, Double)](mapscene_createfromlocations_326810990.md)