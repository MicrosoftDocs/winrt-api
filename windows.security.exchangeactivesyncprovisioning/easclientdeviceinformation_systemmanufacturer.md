---
-api-id: P:Windows.Security.ExchangeActiveSyncProvisioning.EasClientDeviceInformation.SystemManufacturer
-api-type: winrt property
---

<!-- Property syntax
public string SystemManufacturer { get; }
-->

# Windows.Security.ExchangeActiveSyncProvisioning.EasClientDeviceInformation.SystemManufacturer

## -description
Gets the system manufacturer of the local device. Use **SystemManufacturer** only if the value of [SystemSku](easclientdeviceinformation_systemsku.md) is empty.

## -property-value
A string containing the system manufacturer of the local device. The value is fewer than 1024 characters long.

## -remarks
**SystemManufacturer** is retrieved from the Windows Registry. If the Registry can't be read for any reason, then **SystemManufacturer** is returned as an empty string.

## -examples

## -see-also
