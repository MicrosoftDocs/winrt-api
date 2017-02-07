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
> This functionality is only available to mobile operator apps and Windows Store app given privileged access by mobile network operators, mobile broadband adapter IHV, or OEM. For more information, see [Mobile Broadband:  device apps](http://msdn.microsoft.com/library/windows/hardware/hh852368.aspx).

> [!NOTE]
> Note that this class and its methods are supported for the maintenance of legacy desktop apps that used it in earlier versions of Windows; and if you do use this class, you must specify the **Windows.Devices.Sms.LegacySmsApiContract** in your app's manifest. Do not use this class if you are developing new apps for Windows 10. Instead, use the members of this namespace that do not require the **Windows.Devices.Sms.LegacySmsApiContract**.

## -remarks

## -examples

## -see-also


## -capabilities
sms, cellularMessaging