---
-api-id: T:Windows.System.Update.SystemUpdateManagerState
-api-type: winrt enum
ms.custom: RS5
---

<!-- Enumeration syntax.
public enum SystemUpdateManagerState : int 
-->

# Windows.System.Update.SystemUpdateManagerState

## -description
Enumeration that describes the current state of system updates.

## -enum-fields
### -field RebootRequired:6
A reboot is required to complete the install.

### -field ReadyToInstall:4
System updates are ready to install.

### -field ReadyToFinalize:7
System updates are ready to finalize.

### -field ReadyToDownload:2
System updates are ready to download.

### -field Installing:5
System updates are installing.

### -field Idle:0
The SystemUpdateManager is idle.

### -field Finalizing:8
System updates are finalizing.

### -field Error:11
An error has occurred. Check [ExtendedError](systemupdatemanager_extendederror.md).

### -field Downloading:3

### -field Detecting:1

### -field Completed:9

### -field AttentionRequired:10

## -remarks

## -see-also

## -examples

