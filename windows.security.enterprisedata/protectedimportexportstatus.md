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
> Starting in July 2022, Microsoft is deprecating Windows Information Protection (WIP) and the APIs that support WIP. Microsoft will continue to support WIP on supported versions of Windows. New versions of Windows won't include new capabilities for WIP, and it won't be supported in future versions of Windows. For more information, see [Announcing sunset of Windows Information Protection](https://techcommunity.microsoft.com/t5/windows-it-pro-blog/announcing-the-sunset-of-windows-information-protection-wip/ba-p/3579282).
>
> For your data protection needs, Microsoft recommends that you use [Microsoft Purview Information Protection](/microsoft-365/compliance/information-protection) and [Microsoft Purview Data Loss Prevention](/microsoft-365/compliance/dlp-learn-about-dlp). Purview simplifies the configuration set-up and provides an advanced set of capabilities.

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

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1511 | 10586 | AccessSuspended |
| 1511 | 10586 | LicenseExpired |

## -examples

## -see-also
