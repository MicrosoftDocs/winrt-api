---
-api-id: T:Windows.Security.EnterpriseData.DataProtectionStatus
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Security.EnterpriseData.DataProtectionStatus : int
-->

# DataProtectionStatus

## -description
> [!NOTE]
> Windows Information Protection (WIP) policy cannot be applied on Windows 10, version 1511 (build 10586) or earlier.

Describes the enterprise identity protection state of a buffer or stream.

## -enum-fields
### -field ProtectedToOtherIdentity:0
The item is protected to another enterprise identity.

### -field Protected:1
The item is protected.

### -field Revoked:2
The protection of the item has been revoked.

### -field Unprotected:3
The item is not protected to an enterprise identity.

### -field LicenseExpired:4
The item's RMS license has expired. This value is not currently supported.

### -field AccessSuspended:5
The keys to access the protected item have been dropped while the device is locked.


## -remarks

### Version history

| Version | SDK version | Value added |
| -- | -- | -- |
| 1511 | 10586 | AccessSuspended |
| 1511 | 10586 | LicenseExpired |

## -examples

## -see-also
