---
-api-id: M:Windows.Services.Maps.OfflineMaps.OfflineMapPackage.FindPackagesInBoundingBoxAsync(Windows.Devices.Geolocation.GeoboundingBox)
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<OfflineMapPackageQueryResult> OfflineMapPackage.FindPackagesInBoundingBoxAsync(GeoboundingBox queryBoundingBox)
-->

# Windows.Services.Maps.OfflineMaps.OfflineMapPackage.FindPackagesInBoundingBoxAsync


## -description

Starts an asynchronous operation to find a map package that contains map data for specified four-sided geographic area.

## -parameters

### -param queryBoundingBox

A specified four-sided geographic area that defines the area that you want to locate a map package for.

## -returns

An [OfflineMapPackageQueryResult](offlinemappackagequeryresult.md) that contains the result of the query.

## -remarks

This query can find multiple matches. It can also find no matches at all (For example: if you specify a border region or an area in the middle of the ocean).

## -see-also

## -examples

