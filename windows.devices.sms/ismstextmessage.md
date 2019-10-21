---
-api-id: T:Windows.Devices.Sms.ISmsTextMessage
-api-type: winrt interface
---

<!-- Interface syntax.
public interface ISmsTextMessage : Windows.Devices.Sms.ISmsMessage
-->

# Windows.Devices.Sms.ISmsTextMessage

## -description
This interface manipulates a decoded SMS text message. It provides direct access to the plain text body of the message, as well as key header properties, such as time stamp.

> [!NOTE]
> This functionality is only available to mobile operator apps and UWP apps given privileged access by mobile network operators, mobile broadband adapter IHV, or OEM. For more information, see [Mobile Broadband:  device apps](https://docs.microsoft.com/windows-hardware/drivers/mobilebroadband/index).

> [!NOTE]
> Note that this class and its methods are supported for the maintenance of legacy desktop apps that used it in earlier versions of Windows; and if you do use this class, you must specify the **Windows.Devices.Sms.LegacySmsApiContract** in your app's manifest. Do not use this class if you are developing new apps for Windows 10. Instead, use the members of this namespace that do not require the **Windows.Devices.Sms.LegacySmsApiContract**.

## -remarks
### Interface inheritance

ISmsTextMessage inherits [ISmsMessage](ismsmessage.md). Types that implement ISmsTextMessage also implement the interface members of [ISmsMessage](ismsmessage.md).

## -examples

## -see-also
[ISmsMessage](ismsmessage.md)

## -capabilities
cellularMessaging, sms
