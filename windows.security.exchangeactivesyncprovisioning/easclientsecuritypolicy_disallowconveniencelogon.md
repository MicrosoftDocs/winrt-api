---
-api-id: P:Windows.Security.ExchangeActiveSyncProvisioning.EasClientSecurityPolicy.DisallowConvenienceLogon
-api-type: winrt property
---

<!-- Property syntax
public bool DisallowConvenienceLogon { get;  set; }
-->

# Windows.Security.ExchangeActiveSyncProvisioning.EasClientSecurityPolicy.DisallowConvenienceLogon

## -description
> [!NOTE]
> [EasClientSecurityPolicy](easclientsecuritypolicy.md) may be unavailable for releases after Windows 10.

 Gets or sets the ability to prevent convenience logons.  [DisallowConvenienceLogon](easclientsecuritypolicy_disallowconveniencelogon.md) is not defined in MS-ASPROV. It is mapped from MS-ASPROV AllowSimplePassword with respect to the Windows password policies.

When DevicePasswordEnabled is equal to TRUE, if AllowSimplePassword is TRUE, then [DisallowConvenienceLogon](easclientsecuritypolicy_disallowconveniencelogon.md) should be set to FALSE. If AllowSimplePassword is FALSE, then [DisallowConvenienceLogon](easclientsecuritypolicy_disallowconveniencelogon.md) should be set to TRUE.

## -property-value
TRUE prevents convenience logons.

## -remarks

## -examples

## -see-also
