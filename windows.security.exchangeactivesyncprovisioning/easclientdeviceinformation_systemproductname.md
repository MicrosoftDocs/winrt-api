---
-api-id: P:Windows.Security.ExchangeActiveSyncProvisioning.EasClientDeviceInformation.SystemProductName
-api-type: winrt property
---

<!-- Property syntax
public string SystemProductName { get; }
-->

# Windows.Security.ExchangeActiveSyncProvisioning.EasClientDeviceInformation.SystemProductName

## -description
Returns the system product name of the local device.

## -property-value
The system product name of the local device. The value must be less than 1024 characters.

## -remarks
> UWP apps only. Use this only if the [SystemSku](easclientdeviceinformation_systemsku.md) is empty. [SystemProductName](easclientdeviceinformation_systemproductname.md) is retrieved from the registry. If the registry can't be read for any reason, [SystemProductName](easclientdeviceinformation_systemproductname.md) is returned as an empty string.

## -examples

## -see-also
