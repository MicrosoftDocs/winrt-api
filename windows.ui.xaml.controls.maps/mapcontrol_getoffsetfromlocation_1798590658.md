---
-api-id: M:Windows.UI.Xaml.Controls.Maps.MapControl.GetOffsetFromLocation(Windows.Devices.Geolocation.Geopoint,Windows.Foundation.Point@)
-api-type: winrt method
---

<!-- Method syntax
public void GetOffsetFromLocation(Windows.Devices.Geolocation.Geopoint location, Windows.Foundation.Point offset)
-->

# Windows.UI.Xaml.Controls.Maps.MapControl.GetOffsetFromLocation

## -description
Converts a geographic location to a point on the map.

## -parameters
### -param location
A geographic location to convert to a point on the map.

### -param offset
When this method returns, contains the corresponding point on the map.

## -remarks
This method returns a valid point only when the geographic location appears within the map control view.
 
Compare the [GetLocationFromOffset](mapcontrol_getlocationfromoffset_1281571330.md) method.

## -examples

## -see-also
[Display maps with 2D, 3D, and Streetside views](/windows/uwp/maps-and-location/display-maps)
