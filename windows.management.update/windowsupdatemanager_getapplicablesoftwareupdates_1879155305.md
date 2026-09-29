---
-api-id: M:Windows.Management.Update.WindowsUpdateManager.GetApplicableSoftwareUpdates
-api-type: winrt method
---

# Windows.Management.Update.WindowsUpdateManager.GetApplicableSoftwareUpdates

<!--
public System.Collections.Generic.IReadOnlyList<Windows.Management.Update.WindowsSoftwareUpdate> GetApplicableSoftwareUpdates ();
-->


## -description

Gets the software updates that currently apply to the device, as reported by the registered providers.

## -returns

A read-only list of [WindowsSoftwareUpdate](./windowssoftwareupdate.md) objects that apply to the device.

## -remarks

The applicable set reflects the results of the most recent scan. Call [PerformScan](./windowsupdatemanager_performscan_158684574.md) to refresh it.

## -see-also

[WindowsSoftwareUpdate](./windowssoftwareupdate.md)

## -examples

