---
-api-id: T:Windows.UI.Xaml.Controls.Maps.MapControl
-api-type: winrt class
---

<!-- Class syntax.
public class MapControl : Windows.UI.Xaml.Controls.Control, Windows.UI.Xaml.Controls.Maps.IMapControl, Windows.UI.Xaml.Controls.Maps.IMapControl2, Windows.UI.Xaml.Controls.Maps.IMapControl3, Windows.UI.Xaml.Controls.Maps.IMapControl4, Windows.UI.Xaml.Controls.Maps.IMapControl5
-->

# Windows.UI.Xaml.Controls.Maps.MapControl

## -description

Represents a symbolic or photorealistic map of the Earth.

## -xaml-syntax

```xaml
<!-- xmlns:Maps="using:Windows.UI.Xaml.Controls.Maps" -->

<Maps:MapControl/>
- or -
<Maps:MapControl></Maps:MapControl>

```

## -remarks

> [!IMPORTANT]
> **Bing Maps for Enterprise service retirement**
>
> The UWP [MapControl](mapcontrol.md) and map services from the [Windows.Services.Maps](../windows.services.maps/windows_services_maps.md) namespaces rely on Bing Maps. Bing Maps for Enterprise is deprecated and will be retired, at which point the MapControl and services will no longer receive data.
>
> For more information, see the [Bing Maps Developer Center](https://www.bingmapsportal.com/) and [Bing Maps documentation](/bingmaps/getting-started/).

### XAML attached properties

MapControl is the host service class for several [XAML attached properties](/windows/uwp/xaml-platform/attached-properties-overview).

In order to support XAML processor access to the attached properties, and also to expose equivalent _get_ and _set_ operations to code, each XAML attached property has a pair of Get and Set accessor methods. Another way to get or set the value in code is to use the dependency property system, calling either [GetValue](../windows.ui.xaml/dependencyobject_getvalue_1188551207.md) or [SetValue](../windows.ui.xaml/dependencyobject_setvalue_52578133.md) and passing the identifier field as the dependency property identifier.

| Attached property | Description |
| - | - |
| [Location](mapcontrol_location.md) | Gets or sets the location of a child element of the MapControl. |
| [NormalizedAnchorPoint](mapcontrol_normalizedanchorpoint.md) | Gets or sets the anchor point of a child element of the MapControl. |

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1511 | 10586 | MapRightTapped |
| 1607 | 14393 | BusinessLandmarksEnabled |
| 1607 | 14393 | GetVisibleRegion |
| 1607 | 14393 | TransitFeaturesEnabled |
| 1703 | 15063 | FindMapElementsAtOffset(Point,Double) |
| 1703 | 15063 | GetLocationFromOffset(Point,AltitudeReferenceSystem,Geopoint&) |
| 1703 | 15063 | MapContextRequested |
| 1703 | 15063 | MapProjection |
| 1703 | 15063 | StartContinuousPan |
| 1703 | 15063 | StopContinuousPan |
| 1703 | 15063 | StyleSheet |
| 1703 | 15063 | TryPanAsync |
| 1703 | 15063 | TryPanToAsync |
| 1703 | 15063 | ViewPadding |
| 1709 | 16299 | Layers |
| 1709 | 16299 | TryGetLocationFromOffset(Point,Geopoint&) |
| 1709 | 16299 | TryGetLocationFromOffset(Point,AltitudeReferenceSystem,Geopoint&) |
| 1803 | 17134 | Region |
| 1903 | 18362 | CanTiltDown |
| 1903 | 18362 | CanTiltUp |
| 1903 | 18362 | CanZoomIn |
| 1903 | 18362 | CanZoomOut |

## -examples

## -see-also

[Display maps with 2D, 3D, and Streetside views](/windows/uwp/maps-and-location/display-maps), [Control](../windows.ui.xaml.controls/control.md), [MapControl sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/MapControl)