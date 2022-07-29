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
> Starting in July 2022, Microsoft is deprecating Windows Information Protection (WIP) and the APIs that support WIP. Microsoft will continue to support WIP on supported versions of Windows. New versions of Windows won't include new capabilities for WIP, and it won't be supported in future versions of Windows. For more information, see [Announcing sunset of Windows Information Protection](https://techcommunity.microsoft.com/t5/windows-it-pro-blog/announcing-the-sunset-of-windows-information-protection-wip/ba-p/3579282).
>
> For your data protection needs, Microsoft recommends that you use [Microsoft Purview Information Protection](/microsoft-365/compliance/information-protection) and [Microsoft Purview Data Loss Prevention](/microsoft-365/compliance/dlp-learn-about-dlp). Purview simplifies the configuration set-up and provides an advanced set of capabilities.

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

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1511 | 10586 | AccessSuspended |
| 1511 | 10586 | LicenseExpired |

## -examples

## -see-also
