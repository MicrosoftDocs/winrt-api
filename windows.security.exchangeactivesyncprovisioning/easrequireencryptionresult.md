---
-api-id: T:Windows.Security.ExchangeActiveSyncProvisioning.EasRequireEncryptionResult
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Security.ExchangeActiveSyncProvisioning.EasRequireEncryptionResult : int
-->

# EasRequireEncryptionResult

## -description
> [!NOTE]
> [EasRequireEncryptionResult](easrequireencryptionresult.md) may be unavailable for releases after Windows 10.

Represents the type of encryption required. These values are mapped against the HRESULT codes returned from the EAS policy engine.

## -enum-fields
### -field NotEvaluated:0
The policy is not set for evaluation.

### -field Compliant:1
This computer is already DeviceProtected.HRESULT: S_OK and the user is controlled.

### -field CanBeCompliant:2
This computer can be compliant by using the [ApplyAsync](easclientsecuritypolicy_applyasync.md) method.HRESULT: S_OK but the user is not controlled.

### -field NotProvisionedOnAllVolumes:3
This computer is not provisioned to support device encryption. Enable BitLocker on all volumes to comply with device encryption policy. HRESULT: FVE_E_NOT_PROVISIONED_ON_ALL_VOLUMES

### -field DeFixedDataNotSupported:4
This value is no longer supported. Starting with Windows 8.1, use **FixedDataNotSupported**.

### -field FixedDataNotSupported:4
This computer cannot support device encryption because unencrypted fixed data volumes are present.HRESULT: FVE_E_DE_FIXED_DATA_NOT_SUPPORTED

### -field DeHardwareNotCompliant:5
This value is no longer supported. Starting with Windows 8.1, use **HardwareNotCompliant**.

### -field HardwareNotCompliant:5
This computer does not meet the hardware requirements to support device encryption.HRESULT: FVE_E_DE_HARDWARE_NOT_COMPLIANT

### -field DeWinReNotConfigured:6
This value is no longer supported. Starting with Windows 8.1, use **LockNotConfigured**.

### -field LockNotConfigured:6
This computer cannot support device encryption because WinRE is not properly configured.HRESULT: FVE_E_DE_WINRE_NOT_CONFIGURED

### -field DeProtectionSuspended:7
This value is no longer supported. Starting with Windows 8.1, use **ProtectionSuspended**.

### -field ProtectionSuspended:7
Protection is enabled on this volume but has been suspended. This is most likely due to an update of your computer. Reboot and try again.HRESULT: FVE_E_DE_PROTECTION_SUSPENDED

### -field DeOsVolumeNotProtected:8
This value is no longer supported. Starting with Windows 8.1, use **OsVolumeNotProtected**.

### -field OsVolumeNotProtected:8
This computer is not provisioned with device encryption. Enable Device encryption on all volumes to comply with device encryption policy if it is supported. HRESULT: FVE_E_DE_OS_VOLUME_NOT_PROTECTED

### -field DeProtectionNotYetEnabled:9
This value is no longer supported. Starting with Windows 8.1, use **ProtectionNotYetEnabled**.

### -field ProtectionNotYetEnabled:9
Protection has not been enabled on the volume. Enabling protection requires a connected account. If you already have a connected account and are seeing this error, refer to the event log for more information.HRESULT: FVE_E_DE_PROTECTION_NOT_YET_ENABLED

### -field NoFeatureLicense:10
This computer does not have a feature license.HRESULT: FVE_E_NO_FEATURE_LICENSE

### -field OsNotProtected:11
The operating system drive is not protected by BitLocker drive encryption.HRESULT: FVE_E_OS_NOT_PROTECTED

### -field UnexpectedFailure:12
An unexpected failure occurred.


## -remarks

## -examples

## -see-also
[ApplyAsync](easclientsecuritypolicy_applyasync.md)