---
-api-id: T:Windows.Management.Update.WindowsUpdateAttentionRequiredReason
-api-type: winrt enum
---

# Windows.Management.Update.WindowsUpdateAttentionRequiredReason

<!--
public enum WindowsUpdateAttentionRequiredReason
-->


## -description

Defines constants that specify a detailed reason as to why attention is required for an update before it can proceed.

## -enum-fields

### -field None: 0
No attention required.

### -field SeekerUpdate: 1
A seeker update is missing user approval.

### -field ReadyToReboot: 2
The update requires a reboot.

### -field NeedNonMeteredNetwork: 3
The update is waiting for a non-metered network.

### -field NeedUserAgreementForMeteredNetwork: 4
The update requires user agreement to download over a metered network.

### -field NeedNetwork: 5
There was no network connectivity when the update was last attempted.

### -field NeedMoreSpace: 6
More disk space is needed to complete the update.

### -field BatterySaverEnabled: 7
The update was blocked due to Battery Saver being enabled.

### -field NeedUserInteraction: 8
The update requires user interaction in order to proceed.

### -field NeedUserAgreementForPolicy: 9
A policy is configured that requires user agreement before the update can proceed.

### -field CompatibilityError: 10
The update encountered a compatibility error.

### -field NeedUserInteractionForEula: 11
User interaction is needed to approve the End-User License Agreement (EULA) associated with the update.

### -field NeedUserInteractionForCta: 12
User interaction is needed to approve the China Type Approval (CTA) block for the update.

### -field Regulated: 13
The update was blocked due to regulation.

### -field ExternalReboot: 14
An external reboot prevented the update from proceeding.

### -field OtherUpdate: 15
The update couldn't proceed due to another update being in progress.

### -field BlockedByProvider: 16
The update was blocked by the update provider.

### -field BlockedByPostRebootFailure: 17
The update was blocked by a post-reboot failure.

### -field UserEngaged: 18
The update could not proceed because a user was actively using the device.

### -field BlockedByBattery: 19
The update was blocked due to the battery level of the device being too low.

### -field Exclusivity: 20
The update could not complete an action due to it being exclusive to one update at a time.

### -field BlockedBySerialization: 21
The update was blocked due to a serialization issue.

### -field ConflictClass: 22
The update was blocked due to a conflict class.

### -field BlockedByAdminApproval: 23
The update was blocked because it requires Windows update administrator approval.

### -field BlockedByTooManyAttempts: 24
The update was blocked due to too many recent attempts.

### -field BlockedByFailure: 25
The update was blocked due to a recent failure.

### -field Demotion: 26
The update was demoted due to many failed recent attempts.

### -field BlockedByActiveHours: 27
The update was blocked due to the active hours configured on the device.

### -field ScheduledForMaintenance: 28
The update was blocked due to being scheduled to install in the next available maintenance window.

### -field PolicyScheduledInstallTime: 29
The update was blocked due to being scheduled to install at a specific time indicated by a configured policy.

### -field BlockedByOobe: 30
The update was blocked due to OOBE constraints.

### -field DeferredDuringOobe: 31
The update was deferred by OOBE blocking criteria.

### -field DeferredForSustainableTime: 32
The update was deferred to attempt again during a more sustainable (eco-friendly) time.

## -remarks

## -see-also

## -examples
