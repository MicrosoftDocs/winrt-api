---
-api-id: P:Windows.Devices.Sms.SmsReceivedEventDetails.DeviceId
-api-type: winrt property
---

<!-- Property syntax
public string DeviceId { get; }
-->

# Windows.Devices.Sms.SmsReceivedEventDetails.DeviceId

## -description
Returns the [DeviceInformation](../windows.devices.enumeration/deviceinformation.md) ID of the network interface that received the SMS message. This ID can be passed to [SmsDevice.FromIdAsync](smsdevice_fromidasync.md) to activate the device and retrieve additional message details.

## -property-value
A string containing the [DeviceInformation](../windows.devices.enumeration/deviceinformation.md) ID of the SMS network interface (device). This value is typically used to retrieve details such as the sender and the body of the message. For example, you might use the ID to display a popup telling the user that a new message from a particular person has arrived. The combination of [DeviceId](smsreceivedeventdetails_deviceid.md) and [MessageIndex](smsreceivedeventdetails_messageindex.md) is sufficient to retrieve the new message from the SMS device.

## -remarks

## -examples

## -see-also


## -capabilities
sms, cellularMessaging