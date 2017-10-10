---
-api-id: P:Windows.Networking.NetworkOperators.MobileBroadbandDeviceInformation.SubscriberId
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public string SubscriberId { get; }
-->

# Windows.Networking.NetworkOperators.MobileBroadbandDeviceInformation.SubscriberId

## -description
Gets the subscriber identifier for the mobile broadband network device.

## -property-value
The subscriber identifier for the mobile broadband network device.

## -remarks
You can use the [SubscriberId](mobilebroadbanddeviceinformation_subscriberid.md) value to help provision the mobile broadband network device.

For devices that support the GSM cellular class, the [SubscriberId](mobilebroadbanddeviceinformation_subscriberid.md) value represents the International Mobile Subscriber Identity (IMSI), which is up to 15 digits long. For devices that support the CDMA cellular class, the [SubscriberId](mobilebroadbanddeviceinformation_subscriberid.md) value represents the Mobile Identification Number (MIN) string, or the International Roaming MIN (IRM), which is 10 digits long.

## -examples

## -see-also

## -capabilities
cellularDeviceIdentity, cellularDeviceControl
