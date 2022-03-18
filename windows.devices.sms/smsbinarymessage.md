---
-api-id: T:Windows.Devices.Sms.SmsBinaryMessage
-api-type: winrt class
---

<!-- Class syntax.
public class SmsBinaryMessage : Windows.Devices.Sms.ISmsBinaryMessage, Windows.Devices.Sms.ISmsMessage
-->

# Windows.Devices.Sms.SmsBinaryMessage

## -description
Represents an SMS message in raw PDU format. The data format differs depending on whether the message format (indicated by the value of the [Format](smsbinarymessage_format.md) property) is GSM or CDMA.

> [!NOTE]
> This functionality is only available to mobile operator apps and UWP apps given privileged access by mobile network operators, mobile broadband adapter IHV, or OEM. For more information, see [Mobile Broadband:  device apps](/windows-hardware/drivers/mobilebroadband/index).

> [!NOTE]
> Note that this class and its methods are supported for the maintenance of legacy desktop apps that used it in earlier versions of Windows; and if you do use this class, you must specify the **Windows.Devices.Sms.LegacySmsApiContract** in your app's manifest. Do not use this class if you are developing new apps for Windows 10. Instead, use the members of this namespace that do not require the **Windows.Devices.Sms.LegacySmsApiContract**.

## -remarks

## -examples

## -see-also


## -capabilities
cellularMessaging, sms
