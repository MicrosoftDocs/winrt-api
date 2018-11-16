---
-api-id: P:Windows.System.Profile.SystemManufacturers.SystemSupportDeviceInfo.SystemSku
-api-type: winrt property
ms.custom: RS5
---

<!-- Property syntax.
public string SystemSku { get; }
-->

# Windows.System.Profile.SystemManufacturers.SystemSupportDeviceInfo.SystemSku

## -description
Gets the system SKU of the local device.

## -property-value
A string containing the system SKU of the local device.

## -remarks
The **SystemSku** property is retrieved from the registry. If the registry can't be read for any reason, **SystemSku** is returned as an empty string. If **SystemSku** is not empty, **SystemSku** is recommended to be used as the Model string. Otherwise, you can use [SystemManufacturer](systemsupportdeviceinfo_systemmanufacturer.md) and [SystemProductName](systemsupportdeviceinfo_systemproductname.md) to compose **SystemSku**.

## -see-also

## -examples

