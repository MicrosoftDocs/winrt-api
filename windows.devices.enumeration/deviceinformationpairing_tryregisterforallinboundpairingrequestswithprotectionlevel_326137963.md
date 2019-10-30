---
-api-id: M:Windows.Devices.Enumeration.DeviceInformationPairing.TryRegisterForAllInboundPairingRequestsWithProtectionLevel(Windows.Devices.Enumeration.DevicePairingKinds,Windows.Devices.Enumeration.DevicePairingProtectionLevel)
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax.
public bool DeviceInformationPairing.TryRegisterForAllInboundPairingRequestsWithProtectionLevel(DevicePairingKinds pairingKindsSupported, DevicePairingProtectionLevel minProtectionLevel)
-->

# Windows.Devices.Enumeration.DeviceInformationPairing.TryRegisterForAllInboundPairingRequestsWithProtectionLevel

## -description

Registers the application to handle all inbound pairing requests with the specified minimum level of protection.

## -parameters

### -param pairingKindsSupported

The pairing kinds your app supports.

### -param minProtectionLevel

The required minimum level of protection to accept for the pairing requests.

## -returns

Whether or not the attempt was successful.

## -remarks

This API only works with Windows 10 IoT Core (IoT Core) applications.

## -see-also

## -examples
