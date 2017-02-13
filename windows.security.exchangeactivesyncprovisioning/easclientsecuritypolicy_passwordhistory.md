---
-api-id: P:Windows.Security.ExchangeActiveSyncProvisioning.EasClientSecurityPolicy.PasswordHistory
-api-type: winrt property
---

<!-- Property syntax
public uint PasswordHistory { get;  set; }
-->

# Windows.Security.ExchangeActiveSyncProvisioning.EasClientSecurityPolicy.PasswordHistory

## -description
> [!NOTE]
> [EasClientSecurityPolicy](easclientsecuritypolicy.md) may be unavailable for releases after Windows 10.

Gets or set the password information previously used. The MS-ASPROV name is DevicePasswordHistory.

The [PasswordHistory](easclientsecuritypolicy_passwordhistory.md) property is superseded by the MS-ASPROV DevicePasswordEnabled policy. If the caller received DevicePasswordEnabled equal to FALSE, do not set the [PasswordHistory](easclientsecuritypolicy_passwordhistory.md) property for evaluation or application. If the caller received DevicePasswordEnabled equal to TRUE, you can set the [PasswordHistory](easclientsecuritypolicy_passwordhistory.md) property for evaluation or application.

## -property-value
The password information that was previously used.

## -remarks

## -examples

## -see-also
