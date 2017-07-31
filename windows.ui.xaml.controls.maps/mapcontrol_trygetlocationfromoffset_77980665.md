---
-api-id: M:Windows.UI.Xaml.Controls.Maps.MapControl.TryGetLocationFromOffset(Windows.Foundation.Point,Windows.Devices.Geolocation.Geopoint@)
-api-type: winrt method
---

<!-- Method syntax.
public bool MapControl.TryGetLocationFromOffset(Point offset, Geopoint location)
-->

# Windows.UI.Xaml.Controls.Maps.MapControl.TryGetLocationFromOffset

## -description
Converts a point on the map to a geographic location.

## -parameters
### -param offset
A point on the map to convert to a geographic location.

### -param location
When this method returns, contains the corresponding geographic location.

## -returns
Returns **true** if the location is invalid; otherwise, **false**.

## -remarks
Use this method instead of the [GetLocationFromOffset](mapcontrol_getlocationfromoffset_1345615754.md) method. The [GetLocationFromOffset](mapcontrol_getlocationfromoffset_1345615754.md) method has been deprecated.

## -see-also

## -examples
