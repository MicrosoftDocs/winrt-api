---
-api-id: T:Windows.Services.Maps.OfflineMaps.OfflineMapPackageQueryStatus
-api-type: winrt enumeration
---

<!-- Enumeration syntax.
public enum OfflineMapPackageQueryStatus : int {
	InvalidCredentials = 2
	NetworkFailure = 3
	Success = 0
	UnknownError = 1
}
-->

# Windows.Services.Maps.OfflineMaps.OfflineMapPackageQueryStatus

## -description
Specifies the status of a [OfflineMapPackageQueryResult](offlinemappackagequeryresult.md).

## -enum-fields

## -field UnknownError:1
The query returned an unknown error.

## -field Success:0
The query completed successfully.

## -field NetworkFailure:3
There was a network failure that prevented the query from being completed successfully.

## -field InvalidCredentials:2
The credentials used to perform this query are invalid.

## -remarks
You can query your system for map data by using the [FindPackagesAsync](offlinemappackage_findpackagesasync_1312242741.md), [FindPackagesInBoundingBoxAsync](offlinemappackage_findpackagesinboundingboxasync_121221617.md), and [FindPackagesInGeocircleAsync](offlinemappackage_findpackagesingeocircleasync_917543629.md) methods.

Use the [Status](offlinemappackagequeryresult_status.md) property of the resulting query result to obtain of the enumeration values described in this topic.

## -see-also

## -examples
