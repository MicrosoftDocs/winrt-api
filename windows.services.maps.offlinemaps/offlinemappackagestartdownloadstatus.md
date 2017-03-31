---
-api-id: T:Windows.Services.Maps.OfflineMaps.OfflineMapPackageStartDownloadStatus
-api-type: winrt enumeration
---

<!-- Enumeration syntax.
public enum OfflineMapPackageStartDownloadStatus : int {
	DeniedWithoutCapability = 3
	InvalidCredentials = 2
	Success = 0
	UnknownError = 1
}
-->

# Windows.Services.Maps.OfflineMaps.OfflineMapPackageStartDownloadStatus

## -description
Specifies the status of an [OfflineMapPackageStartDownloadResult](offlinemappackagestartdownloadresult.md).

## -enum-fields

## -field UnknownError:1
The operation returned an unknown error.

## -field Success:0
The operation completed successfully.

## -field InvalidCredentials:2
The credentials used to complete this operation are invalid.

## -field DeniedWithoutCapability:3
The ``<uap4:Capability Name="offlineMapsManagement" />`` has not been added to the package manifest.

## -remarks

## -see-also

## -examples
