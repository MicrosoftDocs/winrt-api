---
-api-id: M:Windows.UI.Xaml.Controls.Maps.MapControlDataHelper.CreateMapControl(System.Boolean)
-api-type: winrt method
---

<!-- Method syntax.
public MapControl MapControlDataHelper.CreateMapControl(Boolean rasterRenderMode)
-->

# Windows.UI.Xaml.Controls.Maps.MapControlDataHelper.CreateMapControl

## -description
Creates a [MapControl](mapcontrol.md) in raster-mode.

> [!NOTE]
> This API is not available to all Windows apps. Unless your developer account is specially provisioned by Microsoft, calls to this API will fail at runtime. For more information about this API and the [Windows.Services.Maps.LocalSearch](../windows.services.maps.localsearch/windows_services_maps_localsearch.md) namespace, please work with your Microsoft Account Team representative.

## -parameters
### -param rasterRenderMode
Specifies whether to create the [MapControl](mapcontrol.md) in raster-mode.

## -returns
A [MapControl](mapcontrol.md)

## -remarks
If you create a [MapControl](mapcontrol.md) in raster-mode, you can't change the map control into vector mode.

## -see-also

## -examples

This example creates a [MapControl](mapcontrol.md) in raster-mode.

```csharp
public void AddMapControl()
{
  var map = MapControlDataHelper.CreateMapControl(true);

  // Configure the map control and register for events
  map.Center = new Geopoint(new BasicGeoposition()
  {
    Latitude = 47.604,
    Longitude = -122.329
  });
  map.ZoomLevel = 12;

  map.PanInteractionMode = MapPanInteractionMode.Disabled;
  map.RotateInteractionMode = MapInteractionMode.Disabled;
  map.TiltInteractionMode = MapInteractionMode.Disabled;
  map.ZoomInteractionMode = MapInteractionMode.Disabled;

  map.MapContextRequested += MapControl_MapContextRequested;

  MyParentGrid.Children.Add(map);
}

```
