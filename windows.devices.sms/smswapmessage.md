---
-api-id: T:Windows.Devices.Sms.SmsWapMessage
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class SmsWapMessage : Windows.Devices.Sms.ISmsMessageBase, Windows.Devices.Sms.ISmsWapMessage
-->

# Windows.Devices.Sms.SmsWapMessage

## -description
Represents an SMS WAP push message.

> [!NOTE]
> This functionality is available only to mobile operator apps and UWP apps given privileged access by mobile network operators, mobile broadband adapter IHV, or OEM. For more information, see [Mobile Broadband](/windows-hardware/drivers/mobilebroadband/index).

## -remarks
Pass the [DeviceId](smswapmessage_deviceid.md) property to [SmsDevice.FromIdAsync](smsdevice_fromidasync_1322863552.md) to activate the device and retrieve additional message details.

## -examples

## -see-also
[ISmsMessageBase](ismsmessagebase.md), [ISmsMessage](ismsmessage.md)

## -capabilities
cellularMessaging, sms
