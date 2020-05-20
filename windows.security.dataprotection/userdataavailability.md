---
-api-id: T:Windows.Security.DataProtection.UserDataAvailability
-api-type: winrt enum
---

<!-- Enumeration syntax.
public enum UserDataAvailability : int 
-->

# Windows.Security.DataProtection.UserDataAvailability

## -description
Identifies the availability of protected data.

## -enum-fields
### -field Always:0
Data are unprotected when associated with this availability, and are always accessible whether the device is locked or unlocked.

### -field AfterFirstUnlock:1
Data protected to this availability are accessible only after the first device unlock, and will continue to stay available thereafter.

Protecting new data to this availability is always possible.

### -field WhileUnlocked:2
Data protected to this availability are only available when the device is unlocked. 

Protecting new data to this availability is always possible.

## -remarks

## -see-also

## -examples

