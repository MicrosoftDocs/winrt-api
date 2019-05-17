---
-api-id: P:Windows.Security.ExchangeActiveSyncProvisioning.EasClientSecurityPolicy.PasswordExpiration
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.TimeSpan PasswordExpiration { get;  set; }
-->

# Windows.Security.ExchangeActiveSyncProvisioning.EasClientSecurityPolicy.PasswordExpiration

## -description
> [!NOTE]
> [EasClientSecurityPolicy](easclientsecuritypolicy.md) may be unavailable for releases after Windows 10.

Gets or set the length of time that a password is valid. The MS-ASPROV name is DevicePasswordExpiration.

The PasswordExpiration property is superseded by the MS-ASPROV DevicePasswordEnabled policy. If the caller received DevicePasswordEnabled equal to FALSE, do not set the PasswordExpiration property for evaluation or application. If the caller received DevicePasswordEnabled equal to TRUE, you can set the PasswordExpiration property for evaluation or application.

## -property-value
The length of time before the password expires and must be reset.

## -remarks

## -examples

## -see-also
