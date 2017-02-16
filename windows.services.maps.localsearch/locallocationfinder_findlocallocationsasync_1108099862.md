---
-api-id: M:Windows.Services.Maps.LocalSearch.LocalLocationFinder.FindLocalLocationsAsync(System.String,Windows.Devices.Geolocation.Geocircle,System.String,System.UInt32)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Services.Maps.LocalSearch.LocalLocationFinderResult> FindLocalLocationsAsync(System.String searchTerm, Windows.Devices.Geolocation.Geocircle searchArea, System.String localCategory, System.UInt32 maxResults)
-->

# Windows.Services.Maps.LocalSearch.LocalLocationFinder.FindLocalLocationsAsync

## -description
Gets information about businesses and places that meet the specified search criteria.

> [!NOTE]
> This API is not available to all Windows apps. Unless your developer account is specially provisioned by Microsoft, calls to this API will fail at runtime. For more information about the [Windows.Services.Maps.LocalSearch](windows_services_maps_localsearch.md) namespace, please work with your Microsoft Account Team representative.

## -parameters
### -param searchTerm
The query text of the search; that which you're searching for.

### -param searchArea
The geographic area to be included in the search.

### -param localCategory
The search categories used to limit search results. We recommend using one or more [LocalCategories](localcategories.md) properties to specify *localCategory*. Use a semicolon "**;** " separator to specify more than one category.

### -param maxResults
The maximum number of results to return from the search.

## -returns
The relevant businesses or places that meet the specified search criteria, of type [LocalLocationFinderResult](locallocationfinderresult.md).

## -remarks

## -examples

## -see-also
