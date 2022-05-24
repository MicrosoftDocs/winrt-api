---
-api-id: T:Windows.System.Diagnostics.TraceReporting.PlatformDiagnosticActionState
-api-type: winrt enumeration
---

<!-- Enumeration syntax.
public enum PlatformDiagnosticActionState : int {
	ACPowerNotAvailable = 2
	FreeNetworkNotAvailable = 1
	Success = 0
}
-->

# Windows.System.Diagnostics.TraceReporting.PlatformDiagnosticActionState

## -description
Specifies the outcome of a diagnostic trace operation.

## -enum-fields

## -field Success:0
The operation was successful.

## -field FreeNetworkNotAvailable:1
The operation failed because a non-metered network connection is not available.

## -field ACPowerNotAvailable:2
The operation failed because the device is running on battery power.

## -remarks
> [!IMPORTANT]
> Only first-party applications should use this type.

## -see-also
[DownloadLatestSettingsForNamespace](platformdiagnosticactions_downloadlatestsettingsfornamespace_2049837105.md),
[ForceUpload](platformdiagnosticactions_forceupload_1947368557.md)
