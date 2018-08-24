---
-api-id: T:Windows.Media.Protection.RenewalStatus
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Media.Protection.RenewalStatus : int
-->

# RenewalStatus

## -description
Defines the possible values returned from [RenewSystemComponentsAsync](componentrenewal_renewsystemcomponentsasync_1438723694.md).

## -enum-fields
### -field NotStarted:0
Specifies that renewal has not started.

### -field UpdatesInProgress:1
Specifies that there are updates and the user has allowed updated to proceed

### -field UserCancelled:2
Specifies that the user declined to allow updates to proceed.

### -field AppComponentsMayNeedUpdating:3
Specifies that no system components were detected that need updating. But app components may need to be updated, in which case the user may need to get an updated application from the store.

### -field NoComponentsFound:4
Specifies that no components were found that need to be updated.


## -remarks

## -examples

## -see-also