---
-api-id: M:Windows.Management.Update.WindowsUpdateAdministrator.StartAdministratorScan
-api-type: winrt method
---

# Windows.Management.Update.WindowsUpdateAdministrator.StartAdministratorScan

<!--
public void StartAdministratorScan ();
-->


## -description

Starts a background scan for updates.

## -remarks

This call is required for a scan to proceed if [RegisterForAdministration](./windowsupdateadministrator_registerforadministration_731932711.md) was called with the [RequireAdministratorApprovalForScans](./windowsupdateadministratoroptions.md) flag set.

This call will fail if:

* [RegisterForAdministration](./windowsupdateadministrator_registerforadministration_731932711.md) was not previously called to register a [WindowsUpdateAdministrator](./windowsupdateadministrator.md) on the device, this call will fail.
* The *updateId* provided doesn't match any updates found by a previous scan.

## -see-also

## -examples
