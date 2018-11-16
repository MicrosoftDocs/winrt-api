---
-api-id: P:Windows.System.Profile.SystemManufacturers.SystemSupportDeviceInfo.SystemManufacturer
-api-type: winrt property
ms.custom: RS5
---

<!-- Property syntax.
public string SystemManufacturer { get; }
-->

# Windows.System.Profile.SystemManufacturers.SystemSupportDeviceInfo.SystemManufacturer

## -description
Gets the system manufacturer of the local device. Use **SystemManufacturer** only if the value of [SystemSku](systemsupportdeviceinfo_systemsku.md) is empty.

## -property-value
A string containing the system manufacturer of the local device. The value is fewer than 1024 characters long.

## -remarks
**SystemManufacturer** is retrieved from the Windows Registry. If the Registry can't be read for any reason, then **SystemManufacturer** returns an empty string.

## -see-also

## -examples

