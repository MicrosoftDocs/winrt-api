---
-api-id: P:Windows.Networking.NetworkOperators.MobileBroadbandDeviceInformation.MobileEquipmentId
-api-type: winrt property
---

<!-- Property syntax
public string MobileEquipmentId { get; }
-->

# Windows.Networking.NetworkOperators.MobileBroadbandDeviceInformation.MobileEquipmentId

## -description
Gets the value that uniquely identifies the mobile broadband device to the network provider.

> [!NOTE]
> This functionality is only available to mobile operator apps and Windows Store app given privileged access by mobile network operators.

For permission to use this API, please reach out to [Network Operators API Permissions](mailto:netopperm@microsoft.com).

For technical help with this API, please reach out to [Network Operators API Help](mailto:netophelp@microsoft.com)

## -property-value
The value that uniquely identifies the mobile broadband device to the network provider.

## -remarks
For GSM devices, the [MobileEquipmentId](mobilebroadbanddeviceinformation_mobileequipmentid.md) value will be the International Mobile Equipment Identitiy (IMEI), which can be up to 15 digits long. For CDMA devices, the [MobileEquipmentId](mobilebroadbanddeviceinformation_mobileequipmentid.md) value must be the electronic serical number (ESNs0, which is 11 digits long, or the mobile equipment identifier (MEID), which is 17 digits long.

## -examples

## -see-also
