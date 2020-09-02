---
-api-id: M:Windows.UI.Xaml.Controls.Maps.MapControl.GetLocationFromOffset(Windows.Foundation.Point,Windows.Devices.Geolocation.Geopoint@)
-api-type: winrt method
---

<!-- Method syntax
public void GetLocationFromOffset(Windows.Foundation.Point offset, Windows.Devices.Geolocation.Geopoint location)
-->

# Windows.UI.Xaml.Controls.Maps.MapControl.GetLocationFromOffset

## -description
Converts a point on the map to a geographic location.
> [!NOTE]
This method is deprecated. Use the [TryGetLocationFromOffset](mapcontrol_trygetlocationfromoffset_77980665.md) method instead.

## -parameters
### -param offset
A point on the map to convert to a geographic location.

### -param location
When this method returns, contains the corresponding geographic location.

## -remarks
This method will throw an exception if the point is invalid.


## -examples

## -see-also
[Display maps with 2D, 3D, and Streetside views](/windows/uwp/maps-and-location/display-maps)
