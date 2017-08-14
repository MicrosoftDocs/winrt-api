---
-api-id: M:Windows.Devices.Sms.SmsDevice.FromIdAsync(System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Devices.Sms.SmsDevice> FromIdAsync(System.String deviceId)
-->

# Windows.Devices.Sms.SmsDevice.FromIdAsync

## -description
Creates an instance of [SmsDevice](ismsdevice.md) for the device that received the SMS message.

## -parameters
### -param deviceId
A string representation of the [DeviceInformation](../windows.devices.enumeration/deviceinformation.md) ID of the SMS device that received the SMS message.

## -returns
The SMS device operation object.

## -remarks
The [SmsReceivedEventDetails](smsreceivedeventdetails.md) interface handles the details of a received message; you can pass the [DeviceInformation](smsreceivedeventdetails_deviceid.md) ID from that interface to this method to activate the device and retrieve additional message details, such as the sender and the body of the message. Because the device might be busy, the operation executes asynchronously. The asynchronous operation object returns immediately.

## -examples

## -see-also


## -capabilities
cellularMessaging, sms
