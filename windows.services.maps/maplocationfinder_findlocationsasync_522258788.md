---
-api-id: M:Windows.Services.Maps.MapLocationFinder.FindLocationsAsync(System.String,Windows.Devices.Geolocation.Geopoint,System.UInt32)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Services.Maps.MapLocationFinderResult> FindLocationsAsync(System.String searchText, Windows.Devices.Geolocation.Geopoint referencePoint, System.UInt32 maxCount)
-->

# Windows.Services.Maps.MapLocationFinder.FindLocationsAsync

## -description
Converts the specified address to a collection of geographic locations (geocoding), using the specified reference point as a query hint. The list contains no more than the specified maximum number of results.

## -parameters
### -param searchText
The query for which you want to get locations.

### -param referencePoint
A reference point that provides a query hint.

### -param maxCount
The maximum number of locations to get.

## -returns
When this method completes successfully, it returns a list of locations contained in the [MapLocationFinderResult](maplocationfinderresult.md).

## -remarks

## -examples

## -see-also
[Perform geocoding and reverse geocoding](/windows/uwp/maps-and-location/geocoding), [FindLocationsAsync(String, Geopoint)](maplocationfinder_findlocationsasync_282014344.md)
