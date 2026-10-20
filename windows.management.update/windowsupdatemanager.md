---
-api-id: T:Windows.Management.Update.WindowsUpdateManager
-api-type: winrt class
---

# Windows.Management.Update.WindowsUpdateManager

<!--
public sealed class WindowsUpdateManager
-->


## -description

Provides a unified view of update activity on a device. Use **WindowsUpdateManager** to start scans, enumerate the updates that apply to the device, review recently completed updates, and monitor scan, work, and progress activity through events — without polling.

Starting with the Windows Software Update provider platform, **WindowsUpdateManager** also enumerates the registered software-update providers and performs software-update scans.

## -remarks

**Create a manager.** Construct a manager with a client ID that distinguishes your instance (see [WindowsUpdateManager(String)](./windowsupdatemanager_windowsupdatemanager_290278668.md)). To scope the manager to a specific set of providers, use the [WindowsUpdateManager(String, String[])](./windowsupdatemanager_windowsupdatemanager_683846879.md) overload.

**Monitor activity without polling.** Subscribe to events rather than polling state:

* [ScanningStateChanged](./windowsupdatemanager_scanningstatechanged.md) / [IsScanning](./windowsupdatemanager_isscanning.md) — scan activity is starting or stopping.
* [WorkingStateChanged](./windowsupdatemanager_workingstatechanged.md) / [IsWorking](./windowsupdatemanager_isworking.md) — download/install work is starting or stopping.
* [ProgressChanged](./windowsupdatemanager_progresschanged.md) — an update's action progress changed.
* [AttentionRequiredReasonChanged](./windowsupdatemanager_attentionrequiredreasonchanged.md) — an update now needs attention before it can proceed.
* [ActionCompleted](./windowsupdatemanager_actioncompleted.md) — an action finished for an update.
* [ScanCompleted](./windowsupdatemanager_scancompleted.md) — a scan finished.

**Scan and read updates.** Call [StartScan](./windowsupdatemanager_startscan_128473791.md) to begin a scan, then read [GetApplicableUpdates](./windowsupdatemanager_getapplicableupdates_881665234.md) when [ScanCompleted](./windowsupdatemanager_scancompleted.md) fires. Use [GetMostRecentCompletedUpdates](./windowsupdatemanager_getmostrecentcompletedupdates_1538937357.md) (or [the async form](./windowsupdatemanager_getmostrecentcompletedupdatesasync_973270461.md)) to review history, and [LastSuccessfulScanTimestamp](./windowsupdatemanager_lastsuccessfulscantimestamp.md) to find when the device last scanned successfully.

**Administrator interaction.** If a [WindowsUpdateAdministrator](./windowsupdateadministrator.md) is registered with approval options, scans, updates, or actions can be blocked until they're approved by the administrator.

**Software-update providers.** Use [ProviderIds](./windowsupdatemanager_providerids.md) and [GetProvider](./windowsupdatemanager_getprovider_70425013.md) to enumerate registered providers, [GetApplicableSoftwareUpdates](./windowsupdatemanager_getapplicablesoftwareupdates_1879155305.md) to read the applicable software updates, and [PerformScan](./windowsupdatemanager_performscan_158684574.md) to run a software-update scan.

## -see-also

[WindowsUpdate](./windowsupdate.md), [WindowsUpdateAdministrator](./windowsupdateadministrator.md), [WindowsSoftwareUpdate](./windowssoftwareupdate.md), [WindowsUpdateManagerScanMode](./windowsupdatemanagerscanmode.md), [Windows.Management.Update](./windows_management_update.md)

## -examples

This C# example monitors scan activity and prints the applicable updates when a scan completes.

```csharp
using System;
using Windows.Management.Update;

var updateManager = new WindowsUpdateManager("MyClientId");

updateManager.ScanningStateChanged += (manager, args) =>
    Console.WriteLine($"IsScanning: {manager.IsScanning}");

updateManager.ScanCompleted += (manager, args) =>
{
    foreach (WindowsUpdate update in manager.GetApplicableUpdates())
    {
        Console.WriteLine($"Applicable update: {update.Title}");
    }
};

updateManager.StartScan(userInitiated: true);
```
