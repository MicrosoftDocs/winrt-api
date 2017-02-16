---
-api-id: P:Windows.Security.ExchangeActiveSyncProvisioning.EasClientDeviceInformation.SystemManufacturer
-api-type: winrt property
---

<!-- Property syntax
public string SystemManufacturer { get; }
-->

# Windows.Security.ExchangeActiveSyncProvisioning.EasClientDeviceInformation.SystemManufacturer

## -description
Returns the system manufacturer of the local device. Use this only if the [SystemSku](easclientdeviceinformation_systemsku.md) is empty.

## -property-value
The system manufacturer of the local device. The value must be less than 1024 characters.

## -remarks
> Windows Store app only. [SystemManufacturer](easclientdeviceinformation_systemmanufacturer.md) is retrieved from the registry. If the registry can't be read for any reason, [SystemManufacturer](easclientdeviceinformation_systemmanufacturer.md) is returned as an empty string.

## -examples

## -see-also
