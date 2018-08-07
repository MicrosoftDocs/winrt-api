---
-api-id: P:Windows.Security.ExchangeActiveSyncProvisioning.EasClientDeviceInformation.SystemSku
-api-type: winrt property
---

<!-- Property syntax
public string SystemSku { get; }
-->

# Windows.Security.ExchangeActiveSyncProvisioning.EasClientDeviceInformation.SystemSku

## -description
Gets the system SKU of the local device.

## -property-value
A string containing the system SKU of the local device.

## -remarks
The **SystemSku** property is retrieved from the registry. If the registry can't be read for any reason, **SystemSku** is returned as an empty string. If **SystemSku** is not empty, **SystemSku** is recommended to be used as the Model string. Otherwise, you can use [SystemManufacturer](easclientdeviceinformation_systemmanufacturer.md) and [SystemProductName](easclientdeviceinformation_systemproductname.md) to compose **SystemSku**.

## -examples

## -see-also
