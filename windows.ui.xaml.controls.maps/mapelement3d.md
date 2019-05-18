---
-api-id: T:Windows.UI.Xaml.Controls.Maps.MapElement3D
-api-type: winrt class
---

<!-- Class syntax.
public class MapElement3D : MapElement, MapElement
-->

# Windows.UI.Xaml.Controls.Maps.MapElement3D

## -description
Represents a 3D element displayed on a [MapControl](mapcontrol.md).

## -remarks
To display the 3D object on a map control, add the MapElement3D to the [MapElements](mapelementslayer_mapelements.md) collection of a [MapElementsLayer](mapelementslayer.md). Then, add the [MapElementsLayer](mapelementslayer.md) to the [Layers](mapcontrol_layers.md) collection of the map.

## -see-also

## -examples

This example places a 3D element on the center of the map.

```cs
map3dSphereStreamReference = RandomAccessStreamReference.CreateFromUri
   (new Uri("ms-appx:///Assets/trainengine.3mf"));    

 var myModel = await MapModel3D.CreateFrom3MFAsync(map3dSphereStreamReference,
     MapModel3DShadingOption.Smooth);

 var my3DElement = new MapElement3D();
 my3DElement.Location = myMap.Center;
 my3DElement.Model = myModel;

 var myLayer = new MapElementsLayer();
 myLayer.MapElements.Add(my3DElement);

 myMap.Layers.Add(myLayer);

```
