---
-api-id: T:Windows.Services.Maps.OfflineMaps.OfflineMapPackageStartDownloadResult
-api-type: winrt class
---

<!-- Class syntax.
public class OfflineMapPackageStartDownloadResult
-->

# Windows.Services.Maps.OfflineMaps.OfflineMapPackageStartDownloadResult

## -description
Represents the result of an asynchronous request to queue the download of a map package onto the local system.

## -remarks
This class doesn't represent the final result of a download. It represents the result of requesting the download to be queued. Downloads are queued even if the network isn't available. Download attempts run in the background. If you want to know when a download completes, and the package is fully available for use, handle the [StatusChanged](offlinemappackage_statuschanged.md) event of the [OfflineMapPackage](offlinemappackage.md). You can use the package offline when the [Status](offlinemappackage_status.md) property of the [OfflineMapPackage](offlinemappackage.md) has a value of **Downloaded**. Packages may take a while to download. You can test download times by using the **Offline Maps** page in system settings to manually download regions.

## -see-also

## -examples
