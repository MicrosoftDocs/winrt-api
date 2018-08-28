---
-api-id: T:Windows.Security.EnterpriseData.ProtectedImportExportStatus
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Security.EnterpriseData.ProtectedImportExportStatus : int
-->

# ProtectedImportExportStatus

## -description
> [!NOTE]
> Windows Information Protection (WIP) policy cannot be applied on Windows 10, version 1511 (build 10586) or earlier.

Possible status values for an enterprise protected file that has been imported from or exported to a container file.

## -enum-fields
### -field Ok:0
The file's protection is OK.

### -field Undetermined:1
The file's protection can not be determined.

### -field Unprotected:2
The file is not protected.

### -field Revoked:3
The file's protection has been revoked, and it is inaccessible.

### -field NotRoamable:4
The file cannot be roamed to another device.

### -field ProtectedToOtherIdentity:5
The file is inaccessible, as it is protected to a different enterprise identity.

### -field LicenseExpired:6
The file's RMS license has expired.

### -field AccessSuspended:7
The keys to access the protected file have been dropped while the device is locked.


## -remarks

### Version history

| Version | SDK version | Value added |
| -- | -- | -- |
| 1511 | 10586 | AccessSuspended |
| 1511 | 10586 | LicenseExpired |

## -examples

## -see-also
