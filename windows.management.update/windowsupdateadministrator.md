---
-api-id: T:Windows.Management.Update.WindowsUpdateAdministrator
-api-type: winrt class
---

# Windows.Management.Update.WindowsUpdateAdministrator

<!--
public sealed class WindowsUpdateAdministrator
-->


## -description

Enables a registered administrator to control Windows Update activity on a device — gating scans, updates, and update actions behind explicit approval, and requesting or canceling restarts.

## -remarks

**One administrator per device.** A single administrator can be registered at a time, identified by an organization name. Register with [RegisterForAdministration](./windowsupdateadministrator_registerforadministration_731932711.md), specifying the [WindowsUpdateAdministratorOptions](./windowsupdateadministratoroptions.md) that determine which activities require approval. Retrieve the registered administrator with [GetRegisteredAdministrator](./windowsupdateadministrator_getregisteredadministrator_1823331721.md), read its name with [GetRegisteredAdministratorName](./windowsupdateadministrator_getregisteredadministratorname_1484711373.md), and remove it with [UnregisterForAdministration](./windowsupdateadministrator_unregisterforadministration_1234576495.md). Registration must be performed from a SYSTEM or Administrator context.

**Gate activity.** When registered with approval options:

* [RequireAdministratorApprovalForScans](./windowsupdateadministratoroptions.md) — background scans are blocked; only [StartAdministratorScan](./windowsupdateadministrator_startadministratorscan_459526238.md) can initiate a scan.
* [RequireAdministratorApprovalForUpdates](./windowsupdateadministratoroptions.md) — an update isn't considered applicable until it's approved with [ApproveWindowsUpdate](./windowsupdateadministrator_approvewindowsupdate_1582950728.md) (revoke with [RevokeWindowsUpdateApproval](./windowsupdateadministrator_revokewindowsupdateapproval_1635504675.md)).
* [RequireAdministratorApprovalForActions](./windowsupdateadministratoroptions.md) — an update action doesn't proceed until it's approved with [ApproveWindowsUpdateAction](./windowsupdateadministrator_approvewindowsupdateaction_630494726.md) (revoke with [RevokeWindowsUpdateActionApproval](./windowsupdateadministrator_revokewindowsupdateactionapproval_1047963224.md)).

Approvals can carry additional instructions through [WindowsUpdateApprovalData](./windowsupdateapprovaldata.md), such as metered-network and auto-reboot preferences.

**Review updates.** Use [GetUpdates](./windowsupdateadministrator_getupdates_927795838.md) to enumerate the updates that the administrator can act on.

**Coordinate restarts.** Use [RequestRestart](./windowsupdateadministrator_requestrestart_103435879.md) (with [WindowsUpdateRestartRequestOptions](./windowsupdaterestartrequestoptions.md)) to request a restart, and [CancelRestartRequest](./windowsupdateadministrator_cancelrestartrequest_1241125889.md) to cancel a pending request.

## -see-also

[WindowsUpdateManager](./windowsupdatemanager.md), [WindowsUpdateAdministratorOptions](./windowsupdateadministratoroptions.md), [WindowsUpdateAdministratorStatus](./windowsupdateadministratorstatus.md), [WindowsUpdateApprovalData](./windowsupdateapprovaldata.md), [WindowsUpdateRestartRequestOptions](./windowsupdaterestartrequestoptions.md), [Windows.Management.Update](./windows_management_update.md)

## -examples

This C# example registers an administrator that requires update approval, then approves each known update.

```csharp
using Windows.Management.Update;

string organizationName = "Contoso";

WindowsUpdateAdministratorStatus status = WindowsUpdateAdministrator.RegisterForAdministration(
    organizationName,
    WindowsUpdateAdministratorOptions.RequireAdministratorApprovalForUpdates);

if (status == WindowsUpdateAdministratorStatus.Succeeded)
{
    WindowsUpdateGetAdministratorResult result =
        WindowsUpdateAdministrator.GetRegisteredAdministrator(organizationName);
    WindowsUpdateAdministrator admin = result.Administrator;

    foreach (WindowsUpdate update in admin.GetUpdates())
    {
        admin.ApproveWindowsUpdate(update.UpdateId, new WindowsUpdateApprovalData());
    }
}
```
