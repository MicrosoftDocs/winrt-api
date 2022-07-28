---
-api-id: T:Windows.Security.EnterpriseData.FileProtectionStatus
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Security.EnterpriseData.FileProtectionStatus : int
-->

# FileProtectionStatus

## -description

> [!NOTE]
> Starting in July 2022, Microsoft is deprecating Windows Information Protection (WIP) and the APIs that support WIP. Microsoft will continue to support WIP on supported versions of Windows. New versions of Windows won't include new capabilities for WIP, and it won't be supported in future versions of Windows. For more information, see [Announcing sunset of Windows Information Protection](https://techcommunity.microsoft.com/t5/windows-it-pro-blog/announcing-the-sunset-of-windows-information-protection-wip/ba-p/3579282).
>
> For your data protection needs, Microsoft recommends that you use [Microsoft Purview Information Protection](/microsoft-365/compliance/information-protection) and [Microsoft Purview Data Loss Prevention](/microsoft-365/compliance/dlp-learn-about-dlp). Purview simplifies the configuration set-up and provides an advanced set of capabilities.

Describes the enterprise protection state of a file or folder.

## -enum-fields

### -field Unknown:0

The item is either encrypting or decrypting and the enterprise protection status cannot be determined. Check again later.

### -field Undetermined:0

> [!NOTE]
> **Undetermined** may be unavailable for releases after Windows 10. Instead, use **Unknown**.

The item is either encrypting or decrypting and the enterprise protection status cannot be determined. Check again later.

### -field Unprotected:1

The item is not protected using enterprise protection.

### -field Revoked:2

The item has been revoked using enterprise protection.

### -field Protected:3

The item is protected using enterprise protection and you're app can open this file because it is on the allowed list of the policy.

### -field ProtectedByOtherUser:4

> [!NOTE]
> **ProtectedByOtherUser** may be unavailable for releases after Windows 10. Instead, use **ProtectedToOtherIdentity**.

Another user has protected the item using enterprise protection.

### -field ProtectedToOtherEnterprise:5

> [!NOTE]
> **ProtectedToOtherEnterprise** may be unavailable for releases after Windows 10. Instead, use **ProtectedToOtherIdentity**.

The item is protected for another enterprise id using enterprise protection.

### -field NotProtectable:6

The item is encrypted or is a system file and cannot be protected using enterprise protection.

### -field ProtectedToOtherIdentity:7

The item is protected for another enterprise identity using enterprise protection.

### -field LicenseExpired:8

The item's RMS license has expired.

### -field AccessSuspended:9

The keys to access the protected item have been dropped while the device is locked.

### -field FileInUse:10

The item is being used by another process. You can apply enterprise protection to it only after it becomes exclusively available.

## -remarks

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1511 | 10586 | AccessSuspended |
| 1511 | 10586 | LicenseExpired |
| 1607 | 14393 | FileInUse |

## -examples

## -see-also
