---
-api-id: T:Windows.Services.Maps.OfflineMaps.OfflineMapPackageStatus
-api-type: winrt enumeration
---

<!-- Enumeration syntax.
public enum OfflineMapPackageStatus : int {
	Deleting = 3
	Downloaded = 2
	Downloading = 1
	NotDownloaded = 0
}
-->

# Windows.Services.Maps.OfflineMaps.OfflineMapPackageStatus

## -description
Specifies the status of a [OfflineMapPackage](offlinemappackage.md).
## -enum-fields

## -field NotDownloaded:0
The map package is not downloaded to the local system.

## -field Downloading:1
The map packaging is currently downloading to the local system.

## -field Downloaded:2
The map package is downloaded to the local system.

## -field Deleting:3
The map package is being deleted from the local system.

## -remarks
You can download map packages for offline use by using the [RequestStartDownloadAsync](offlinemappackage_requeststartdownloadasync_735451469.md) method.

## -see-also

## -examples
