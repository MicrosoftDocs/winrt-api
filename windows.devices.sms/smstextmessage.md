---
-api-id: T:Windows.Devices.Sms.SmsTextMessage
-api-type: winrt class
---

<!-- Class syntax.
public class SmsTextMessage : Windows.Devices.Sms.ISmsMessage, Windows.Devices.Sms.ISmsTextMessage
-->

# Windows.Devices.Sms.SmsTextMessage

## -description
Manages a decoded SMS text message, providing direct access to the plain text body of the message, as well as key header properties, such as time stamp.

> [!NOTE]
> This functionality is available only to mobile operator apps and UWP apps given privileged access by mobile network operators, mobile broadband adapter IHV, or OEM. For more information, see [Mobile Broadband](/windows-hardware/drivers/mobilebroadband/index).

> [!NOTE]
> This class and its methods are supported for the maintenance of legacy desktop apps that used it in earlier versions of Windows. If you do use this class, then you must specify the **Windows.Devices.Sms.LegacySmsApiContract** in your app's manifest. Don't use this class if you're developing a new app for Windows. Instead, use the APIs in this namespace that don't require the **Windows.Devices.Sms.LegacySmsApiContract**.

## -remarks

## -examples

## -see-also


## -capabilities
cellularMessaging, sms
