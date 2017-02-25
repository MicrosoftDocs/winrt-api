---
-api-id: E:Windows.Services.Maps.OfflineMaps.OfflineMapPackage.StatusChanged
-api-type: winrt event
---

<!-- Event syntax.
public event TypedEventHandler StatusChanged<OfflineMapPackage,  object>
-->

# Windows.Services.Maps.OfflineMaps.OfflineMapPackage.StatusChanged

## -description
Occurs when the status of an [OfflineMapPackageQueryResult](offlinemappackagequeryresult.md) changes.

## -remarks
Handle this event if you want to know whether a status of map package that you previously searched for has changed. For example, if the [Status](offlinemappackage_status.md) property of a map package previously returned a value of **Downloading**, this event notifies you when the status changes to **Downloaded**.

## -see-also

## -examples
