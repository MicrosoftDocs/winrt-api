---
-api-id: T:Windows.Security.DataProtection.UserDataStorageItemProtectionStatus
-api-type: winrt enum
---

<!-- Enumeration syntax.
public enum UserDataStorageItemProtectionStatus : int 
-->

# Windows.Security.DataProtection.UserDataStorageItemProtectionStatus

## -description
Result of protecting a storage item.

## -enum-fields
### -field Succeeded:0
Requested protection was successfully applied.

### -field NotProtectable:1
The system does not support protection of the specified storage item.

### -field DataUnavailable:2
Requested protection cannot be applied as the data are currently unavailable. For example, changing availability from 'WhileUnlocked' to 'AfterFirstUnlock' is not possible while the device is locked.

## -remarks

## -see-also

## -examples

