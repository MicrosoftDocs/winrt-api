---
-api-id: M:Windows.UI.Xaml.Controls.Maps.MapScene.CreateFromBoundingBox(Windows.Devices.Geolocation.GeoboundingBox)
-api-type: winrt method
---

<!-- Method syntax
public Windows.UI.Xaml.Controls.Maps.MapScene CreateFromBoundingBox(Windows.Devices.Geolocation.GeoboundingBox bounds)
-->

# Windows.UI.Xaml.Controls.Maps.MapScene.CreateFromBoundingBox

## -description
Creates a scene to appear in a map based on a four-sided geographic area.

## -parameters
### -param bounds
The four-sided geographic area to appear in the scene.

## -returns
Represents a view of a map in the [MapControl](mapcontrol.md).

## -remarks
This constructor is equivalent to calling [CreateFromBoundingBox(GeoboundingBox, Double, Double)](mapscene_createfromboundingbox_1417269839.md) with the following default parameter values: *headingInDegrees* = 0 (North) and *pitchInDegrees* = 0 (looking straight down). For more information, see the remarks section of the [CreateFromBoundingBox(GeoboundingBox, Double, Double)](mapscene_createfromboundingbox_1417269839.md) method.



## -examples

## -see-also
[CreateFromBoundingBox(GeoboundingBox, Double, Double)](mapscene_createfromboundingbox_1417269839.md)