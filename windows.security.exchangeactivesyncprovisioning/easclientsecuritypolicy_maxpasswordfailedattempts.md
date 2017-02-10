---
-api-id: P:Windows.Security.ExchangeActiveSyncProvisioning.EasClientSecurityPolicy.MaxPasswordFailedAttempts
-api-type: winrt property
---

<!-- Property syntax
public byte MaxPasswordFailedAttempts { get;  set; }
-->

# Windows.Security.ExchangeActiveSyncProvisioning.EasClientSecurityPolicy.MaxPasswordFailedAttempts

## -description
> [!NOTE]
> [EasClientSecurityPolicy](easclientsecuritypolicy.md) may be unavailable for releases after Windows 10.

Gets or sets the maximum number of failed password attempts for logging on. The MS-ASPROV name is MaxDevicePasswordFailedAttempts.

The [MaxPasswordFailedAttempts](easclientsecuritypolicy_maxpasswordfailedattempts.md) property is superseded by the MS-ASPROV DevicePasswordEnabled policy. If the caller received DevicePasswordEnabled equal to FALSE, do not set the [MaxPasswordFailedAttempts](easclientsecuritypolicy_maxpasswordfailedattempts.md) property for evaluation or application. If the caller received DevicePasswordEnabled equal to TRUE, you can set the [MaxPasswordFailedAttempts](easclientsecuritypolicy_maxpasswordfailedattempts.md) property for evaluation or application.

## -property-value
The range is between 4 and 16.

## -remarks

## -examples

## -see-also
