---
-api-id: P:Windows.System.Profile.SystemManufacturers.SystemSupportDeviceInfo.SystemProductName
-api-type: winrt property
ms.custom: RS5
---

<!-- Property syntax.
public string SystemProductName { get; }
-->

# Windows.System.Profile.SystemManufacturers.SystemSupportDeviceInfo.SystemProductName

## -description
Gets the system product name of the local device. Use **SystemProductName** only if the value of [SystemSku](systemsupportdeviceinfo_systemsku.md) is empty.

## -property-value
A string containing the system product name of the local device. The value is fewer than 1024 characters long.

## -remarks
**SystemProductName** is retrieved from the Window Registry. If the Registry can't be read for any reason, **SystemProductName** returns an empty string.

## -see-also

## -examples

