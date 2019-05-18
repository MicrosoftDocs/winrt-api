---
-api-id: P:Windows.Security.ExchangeActiveSyncProvisioning.EasClientSecurityPolicy.MinPasswordLength
-api-type: winrt property
---

<!-- Property syntax
public byte MinPasswordLength { get;  set; }
-->

# Windows.Security.ExchangeActiveSyncProvisioning.EasClientSecurityPolicy.MinPasswordLength

## -description
> [!NOTE]
> [EasClientSecurityPolicy](easclientsecuritypolicy.md) may be unavailable for releases after Windows 10.

Gets or set the minimum length of password allowed. The MS-ASPROV name is MinPasswordLength.

The MinPasswordLength property is superseded by the MS-ASPROV DevicePasswordEnabled policy. If the caller received DevicePasswordEnabled equal to FALSE, do not set the MinPasswordLength property for evaluation or application. If the caller received DevicePasswordEnabled equal to TRUE, you can set the MinPasswordLength property for evaluation or application.

## -property-value
The range is between 1 and 16.

## -remarks

## -examples

## -see-also
