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
Data protected to this availability are accessible from the time the user signs in until the user signs out or the system is shut down or restarted.

Protecting new data to this availability is always possible.

This is also known as "Level 1" availability.

### -field WhileUnlocked:2
Data protected to this availability are available only when the user is signed in and the device is unlocked.

Protecting new data to this availability is always possible.

This is also known as "Level 2" availability.

## -remarks

## -see-also

[Personal Data Encryption](/windows/security/operating-system-security/data-protection/personal-data-encryption/)

## -examples

