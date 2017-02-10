---
-api-id: P:Windows.Security.ExchangeActiveSyncProvisioning.EasClientDeviceInformation.SystemSku
-api-type: winrt property
---

<!-- Property syntax
public string SystemSku { get; }
-->

# Windows.Security.ExchangeActiveSyncProvisioning.EasClientDeviceInformation.SystemSku

## -description
Returns the system SKU of the local device.

## -property-value
The system SKU of the local device.

## -remarks
> Windows Store app only. The [SystemSku](easclientdeviceinformation_systemsku.md) property is retrieved from the registry. If the registry can't be read for any reason, [SystemSku](easclientdeviceinformation_systemsku.md) is returned as an empty string. If [SystemSku](easclientdeviceinformation_systemsku.md) is not empty, [SystemSku](easclientdeviceinformation_systemsku.md) is recommended to be used as the Model string. Otherwise, you can use [SystemManufacturer](easclientdeviceinformation_systemmanufacturer.md) and [SystemProductName](easclientdeviceinformation_systemproductname.md) to compose [SystemSku](easclientdeviceinformation_systemsku.md).

## -examples

## -see-also
