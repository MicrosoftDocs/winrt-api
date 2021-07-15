---
-api-id: P:Windows.Security.ExchangeActiveSyncProvisioning.EasClientDeviceInformation.SystemProductName
-api-type: winrt property
---

<!-- Property syntax
public string SystemProductName { get; }
-->

# Windows.Security.ExchangeActiveSyncProvisioning.EasClientDeviceInformation.SystemProductName

## -description
Gets the system product name of the local device. Use **SystemProductName** only if the value of [SystemSku](easclientdeviceinformation_systemsku.md) is empty.

## -property-value
A string containing the system product name of the local device. The value is fewer than 1024 characters long.

## -remarks
**SystemProductName** is retrieved from the Windows Registry. If the Registry can't be read for any reason, **SystemProductName** returns an empty string.

## -examples

## -see-also
