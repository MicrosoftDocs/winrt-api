---
-api-id: M:Windows.System.Update.SystemUpdateManager.UnblockAutomaticRebootAsync(System.String)
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax.
public IAsyncOperation<bool> SystemUpdateManager.UnblockAutomaticRebootAsync(String lockId)
-->

# Windows.System.Update.SystemUpdateManager.UnblockAutomaticRebootAsync

## -description
Unblock automatic update reboots, if blocked.

## -parameters
### -param lockId
Identifier consisting of A-Z,a-z,0-9.  Use Guid.NewGuid.ToString() to generate a new random id. Must match the value passed into [BlockAutomaticRebootAsync](systemupdatemanager_blockautomaticrebootasync_2067935084.md).

## -returns
Returns true if no blocks remain on automatic reboots.

## -remarks

## -see-also
[Windows.System.Update.SystemUpdateManager.GetAutomaticRebootBlockIds](systemupdatemanager_getautomaticrebootblockids_1156258545.md), [Windows.System.Update.SystemUpdateManager.BlockAutomaticRebootAsync](systemupdatemanager_blockautomaticrebootasync_2067935084.md)

## -examples

