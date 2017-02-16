---
-api-id: M:Windows.UI.Xaml.Controls.Maps.MapControl.StartContinuousZoom(System.Double)
-api-type: winrt method
---

<!-- Method syntax
public void StartContinuousZoom(System.Double rateOfChangePerSecond)
-->

# Windows.UI.Xaml.Controls.Maps.MapControl.StartContinuousZoom

## -description
Starts an asynchronous operation to zoom in continuously until the map's maximum [ZoomLevel](mapcontrol_zoomlevel.md) is reached.

## -parameters
### -param rateOfChangePerSecond
The change in [ZoomLevel](mapcontrol_zoomlevel.md) per second.

## -remarks
The maximum and minimum values of [ZoomLevel](mapcontrol_zoomlevel.md) depend on the type of map view: 2D, 3D, or Streetside.<table>
   <tr><th>Property</th><th>2D range</th><th>3D range</th><th>Streetside range</th></tr>
   <tr><td>ZoomLevel</td><td>1-20</td><td>1-20</td><td>24-26</td></tr>
</table>

 When leaving a Streetside view, the map returns to the previous view settings. The Streetside ZoomLevel is not maintained outside of the Streetside experience.

## -examples

## -see-also
