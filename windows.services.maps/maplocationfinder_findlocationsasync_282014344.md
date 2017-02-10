---
-api-id: M:Windows.Services.Maps.MapLocationFinder.FindLocationsAsync(System.String,Windows.Devices.Geolocation.Geopoint)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Services.Maps.MapLocationFinderResult> FindLocationsAsync(System.String searchText, Windows.Devices.Geolocation.Geopoint referencePoint)
-->

# Windows.Services.Maps.MapLocationFinder.FindLocationsAsync

## -description
Converts the specified address to a collection of geographic locations (geocoding), using the specified reference point as a query hint.

## -parameters
### -param searchText
The query for which you want to get locations.

### -param referencePoint
A reference point that provides a query hint.

## -returns
When this method completes successfully, it returns a list of locations contained in the [MapLocationFinderResult](maplocationfinderresult.md).

## -remarks

## -examples

## -see-also
[Perform geocoding and reverse geocoding](http://msdn.microsoft.com/library/b912be80-3e1d-43bb-918f-7a43327597d2), [FindLocationsAsync(String, Geopoint, UInt32)](maplocationfinder_findlocationsasync_522258788.md)