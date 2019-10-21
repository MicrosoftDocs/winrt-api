---
-api-id: P:Windows.Security.ExchangeActiveSyncProvisioning.EasClientSecurityPolicy.MinPasswordComplexCharacters
-api-type: winrt property
---

<!-- Property syntax
public byte MinPasswordComplexCharacters { get;  set; }
-->

# Windows.Security.ExchangeActiveSyncProvisioning.EasClientSecurityPolicy.MinPasswordComplexCharacters

## -description
> [!NOTE]
> [EasClientSecurityPolicy](easclientsecuritypolicy.md) may be unavailable for releases after Windows 10.

Gets or sets the minimum number of complex characters that are required for a password. The MS-ASPROV name is MinDevicePasswordComplexCharacters.

If the caller app receives MS-ASPROV AlphanumericDevicePasswordRequired equal to TRUE, then MinPasswordComplexCharacters must be set to be equal or greater than 2 for evaluation and application.

The MinPasswordComplexCharacters property is superseded by the MS-ASPROV DevicePasswordEnabled policy. If the caller received DevicePasswordEnabled equal to FALSE, do not set the MinPasswordComplexCharacters property for evaluation or application. If the caller received DevicePasswordEnabled equal to TRUE, you can set the MinPasswordComplexCharacters property for evaluation or application.

## -property-value
The range is between 1 and 4.

## -remarks

## -examples

## -see-also
