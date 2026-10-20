---
-api-id: T:Windows.Management.Update.WindowsUpdate
-api-type: winrt class
---

# Windows.Management.Update.WindowsUpdate

<!--
public sealed class WindowsUpdate
-->


## -description

A **WindowsUpdate** is a property bag that describes a single pending or in-progress update — its identity and metadata, classification flags, End-User License Agreement (EULA) state, deadline, and the progress and result of the action currently being performed on it.

## -remarks

**Obtaining a WindowsUpdate.** You can obtain a **WindowsUpdate** from [WindowsUpdateManager](./windowsupdatemanager.md) via its event callbacks (for example, the updates carried by [WindowsUpdateScanCompletedEventArgs](./windowsupdatescancompletedeventargs.md)) or from [GetApplicableUpdates](./windowsupdatemanager_getapplicableupdates_881665234.md). You can also obtain one from [WindowsUpdateAdministrator](./windowsupdateadministrator.md) via the [GetUpdates](./windowsupdateadministrator_getupdates_927795838.md) method.

The properties fall into the following groups:

* **Identity and metadata** — [ProviderId](./windowsupdate_providerid.md), [UpdateId](./windowsupdate_updateid.md), [Title](./windowsupdate_title.md), [Description](./windowsupdate_description.md), [MoreInfoUrl](./windowsupdate_moreinfourl.md), and [SupportUrl](./windowsupdate_supporturl.md).
* **Classification** — Boolean flags describe what kind of update it is: [IsFeatureUpdate](./windowsupdate_isfeatureupdate.md), [IsMinorImpact](./windowsupdate_isminorimpact.md), [IsSecurity](./windowsupdate_issecurity.md), [IsCritical](./windowsupdate_iscritical.md), [IsForOS](./windowsupdate_isforos.md), [IsDriver](./windowsupdate_isdriver.md), [IsMandatory](./windowsupdate_ismandatory.md), [IsUrgent](./windowsupdate_isurgent.md), and [IsSeeker](./windowsupdate_isseeker.md).
* **Licensing** — When [IsEulaAccepted](./windowsupdate_iseulaaccepted.md) is `false`, present [EulaText](./windowsupdate_eulatext.md) to the user and call [AcceptEula](./windowsupdate_accepteula_1007985360.md) before the update can proceed.
* **Timing and attention** — [Deadline](./windowsupdate_deadline.md) indicates when the update should be installed by, and [AttentionRequiredInfo](./windowsupdate_attentionrequiredinfo.md) explains why an update can't currently proceed.
* **Progress and result** — [CurrentAction](./windowsupdate_currentaction.md), [ActionProgress](./windowsupdate_actionprogress.md), and [ActionResult](./windowsupdate_actionresult.md) describe the action currently running and its outcome.
* **Extensibility** — [GetPropertyValue](./windowsupdate_getpropertyvalue_1972570050.md) retrieves additional provider-defined values by name.

## -see-also

[WindowsUpdateManager](./windowsupdatemanager.md), [WindowsUpdateAdministrator](./windowsupdateadministrator.md), [WindowsUpdateAttentionRequiredInfo](./windowsupdateattentionrequiredinfo.md), [WindowsUpdateActionResult](./windowsupdateactionresult.md), [Windows.Management.Update](./windows_management_update.md)

## -examples

This C# example accepts the EULA for any applicable update that requires it.

```csharp
using System;
using Windows.Management.Update;

var updateManager = new WindowsUpdateManager("MyClientId");

foreach (WindowsUpdate update in updateManager.GetApplicableUpdates())
{
    if (!update.IsEulaAccepted)
    {
        Console.WriteLine(update.EulaText);
        update.AcceptEula();
    }
}
```
